using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Médiathèque_Online.inc.view
{
    public partial class page_gestion_bibliotheque : Form
    {
        private List<Panel> panels = new();
        private List<BibliothequeDTO> dtoList;
        private ControleurBibliotheque controleur = new();
        public page_gestion_bibliotheque()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("gestion biblio construct");
            this.dtoList = controleur.GetAllbibliotheques(); //Recupération d'une liste de dto
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitUserComp();
        }

        private void InitUserComp()// Initialisation des carrés de la liste user
        {
            panels.Clear();//vider la liste panels
            int xPos = 10, yPos = 10, tabIndex = 0;//déclaration des int utilisable
            for (int i = 0; i < this.dtoList.Count; i++)// Boucle for de création affichage graphique
            {
                //mise en place des labels
                Label localisationBiblio = new();
                Label idBibliotheque = new();
                //
                // Panel
                //
                panels.Add(new Panel());//création et ajout du panel dans la liste
                containerPanel.Controls.Add(panels[i]);//ajout du panel dans le panel contenair
                panels[i].BackColor = Color.Gainsboro;// color bg
                panels[i].Controls.Add(localisationBiblio);// ajout de label
                panels[i].Controls.Add(idBibliotheque);// ajout de label
                panels[i].Location = new Point(xPos, yPos);//positionnement
                panels[i].Name = i.ToString();//Nommage du panel
                panels[i].Size = new Size(300, 80);//def taille du panel
                panels[i].TabIndex = ++tabIndex;//indexation de la tabulation
                long idPanel = dtoList[i].GetId();
                panels[i].Click += new EventHandler((sender, e) => ShowUser_Click(sender, e, idPanel));

                //
                //Configuration des labels
                // 
                // localisationBiblio
                // 
                localisationBiblio.AutoSize = true;
                localisationBiblio.Location = new System.Drawing.Point(25, 49);
                localisationBiblio.Name = "localisationBiblio" + i;
                localisationBiblio.Size = new System.Drawing.Size(107, 15);
                localisationBiblio.TabIndex = 2;
                localisationBiblio.Text = dtoList[i].GetLocalisation();
                System.Diagnostics.Debug.WriteLine("localisation : " + dtoList[i].GetLocalisation());
                // 
                // idAdministre
                // 
                idBibliotheque.AutoSize = true;
                idBibliotheque.Location = new System.Drawing.Point(3, 0);
                idBibliotheque.Name = "idBibliotheque";
                idBibliotheque.Size = new System.Drawing.Size(75, 15);
                idBibliotheque.TabIndex = 0;
                idBibliotheque.Text = dtoList[i].GetId().ToString();


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
        private void ShowUser_Click(object sender, EventArgs e, long id)
        {
            System.Diagnostics.Debug.WriteLine("id : " + id);
            //Program.SetNbr(id);
            //Program.ChangePage("userRecord", "gestion_users");

        }

        private void btn_retour_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("accueil", "gestionBiblio");
        }
    }
}
