using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Médiathèque_Online.controler;
/*
 * judicael 11/04/2022 création de la page, insertion des cadres users connecté à la bdd
 *
 */
namespace My_Médiathèque_Online.inc.view
{
    public partial class page_gestion_users : Form
    {
        private List<Panel> panels = new();
        private List<AdministreDTO> dtoList;
        private ControleurAdministre controleur =new();
        public page_gestion_users()
        {
            InitializeComponent();
            this.dtoList = controleur.GetListAdministre(); //Recupération d'une liste de dto
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitUserComp();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.SetConnected(false);
            Program.ChangePage("login", "gestion_users");
        }

        private void btn_retour_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("accueil", "gestion_users");
        }
        private void InitUserComp()// Initialisation des carrés de la liste user
        {
            panels.Clear();//vider la liste panels
            int xPos = 10, yPos = 10, tabIndex = 0;//déclaration des int utilisable
            for (int i = 0 ; i < this.dtoList.Count ; i++)// Boucle for de création affichage graphique
            {
                //mise en place des labels
                Label prenomAdministre = new();
                Label nomAdministre = new();
                Label idAdministre = new();
                //
                // Panel
                //
                panels.Add(new Panel());//création et ajout du panel dans la liste
                containerPanel.Controls.Add(panels[i]);//ajout du panel dans le panel contenair
                panels[i].BackColor = Color.Gainsboro;// color bg
                panels[i].Controls.Add(prenomAdministre);// ajout de label
                panels[i].Controls.Add(nomAdministre);// ajout de label
                panels[i].Controls.Add(idAdministre);// ajout de label
                panels[i].Location = new Point(xPos, yPos);//positionnement
                panels[i].Name = i.ToString();//Nommage du panel
                panels[i].Size = new Size(140, 80);//def taille du panel
                panels[i].TabIndex = ++tabIndex;//indexation de la tabulation
                long idPanel = dtoList[i].Get_id_Administre();
                panels[i].Click += new EventHandler((sender, e) => ShowUser_Click(sender, e, idPanel));

                //
                //Configuration des labels
                // 
                // prenomAdministre
                // 
                prenomAdministre.AutoSize = true;
                prenomAdministre.Location = new System.Drawing.Point(25, 49);
                prenomAdministre.Name = "prenomAdministre"+i;
                prenomAdministre.Size = new System.Drawing.Size(107, 15);
                prenomAdministre.TabIndex = 2;
                prenomAdministre.Text = dtoList[i].Get_prenom_Administre();
                // 
                // nomAdministre
                // 
                nomAdministre.AutoSize = true;
                nomAdministre.Location = new System.Drawing.Point(3, 25);
                nomAdministre.Name = "nomAdministre";
                nomAdministre.Size = new System.Drawing.Size(90, 15);
                nomAdministre.TabIndex = 1;
                nomAdministre.Text = dtoList[i].Get_nom_Administre();
                // 
                // idAdministre
                // 
                idAdministre.AutoSize = true;
                idAdministre.Location = new System.Drawing.Point(3, 0);
                idAdministre.Name = "idAdministre0";
                idAdministre.Size = new System.Drawing.Size(75, 15);
                idAdministre.TabIndex = 0;
                idAdministre.Text = dtoList[i].Get_id_Administre().ToString();


                if (xPos >= 1060)
                {
                    xPos = 10;
                    yPos += 90;
                }
                else
                {
                    xPos += 150;
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btn_reinit_gestionUsers.Visible = true;
            er404msg_gestionUsers.Text = "";
            AdministreDTO search = controleur.GetAdministreByName(searchTextBox.Text);
            if(search != null)
            {
                this.dtoList.Clear();
                this.dtoList.Add(search);
                foreach (var element in panels)
                {
                    element.Dispose();
                }
                InitUserComp();

            }
            else
            {
                er404msg_gestionUsers.Text = "Désolé, nous ne trouvons pas de résultat pour votre recherche";
            }

        }

        private void btn_reinit_gestionUsers_Click(object sender, EventArgs e)
        {
            btn_reinit_gestionUsers.Visible = false;
            er404msg_gestionUsers.Text = "";
            this.dtoList.Clear();
            this.dtoList = controleur.GetListAdministre();
            foreach (var element in panels)
            {
                element.Dispose();
            }
            InitUserComp();

        }
        private void ShowUser_Click(object sender, EventArgs e, long id)
        {
            System.Diagnostics.Debug.WriteLine("id : "+ id);
            Program.SetNbr(id);
            Program.ChangePage("userRecord", "gestion_users");

        }

        private void btn_add_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("newUserRecord", "gestion_users");
        }
    }
}
