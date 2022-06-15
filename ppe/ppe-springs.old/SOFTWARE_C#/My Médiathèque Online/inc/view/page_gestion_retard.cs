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
 * Judicael 04/05/2022
 * 
 * **/

namespace My_Médiathèque_Online.inc.view
{
    public partial class page_gestion_retard : Form
    {

        private List<Panel> panels = new();
        private List<RetardDTO> dtoList;
        private  ControleurRetard controleurRetard = new();
        public page_gestion_retard()
        {
            InitializeComponent();
        }

        private void btn_retour_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("accueil", "gestionRetards");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dtoList = controleurRetard.GetAllRetards();
            InitUserComp();
        }
        private void InitUserComp()// Initialisation des carrés de la liste user
        {
            panels.Clear();//vider la liste panels
            int xPos = 10, yPos = 10, tabIndex = 0;//déclaration des int utilisable
            for (int i = 0; i < this.dtoList.Count; i++)// Boucle for de création affichage graphique
            {
                //mise en place des labels
                Label IdAdministre = new();
                Label isbnlivre = new();
                Label idRetard = new();
                //
                // Panel
                //
                panels.Add(new Panel());//création et ajout du panel dans la liste
                containerPanel.Controls.Add(panels[i]);//ajout du panel dans le panel contenair
                panels[i].BackColor = Color.Gainsboro;// color bg
                panels[i].Controls.Add(IdAdministre);// ajout de label
                panels[i].Controls.Add(isbnlivre);// ajout de label
                panels[i].Controls.Add(idRetard);// ajout de label
                panels[i].Location = new Point(xPos, yPos);//positionnement
                panels[i].Name = i.ToString();//Nommage du panel
                panels[i].Size = new Size(140, 80);//def taille du panel
                panels[i].TabIndex = ++tabIndex;//indexation de la tabulation
                long idPanel = dtoList[i].GetIdRetard();
                panels[i].Click += new EventHandler((sender, e) => ShowUser_Click(sender, e, idPanel));

                //
                //Configuration des labels
                // 
                // IdAdministre
                // 
                IdAdministre.AutoSize = true;
                IdAdministre.Location = new System.Drawing.Point(25, 49);
                IdAdministre.Name = "IdAdministre" + i;
                IdAdministre.Size = new System.Drawing.Size(107, 15);
                IdAdministre.TabIndex = 2;
                IdAdministre.Text = dtoList[i].GetNomAdm().ToString();
                // 
                // isbnlivre
                // 
                isbnlivre.AutoSize = true;
                isbnlivre.Location = new System.Drawing.Point(3, 25);
                isbnlivre.Name = "isbnlivre";
                isbnlivre.Size = new System.Drawing.Size(90, 15);
                isbnlivre.TabIndex = 1;
                isbnlivre.Text = dtoList[i].GetIsbn().ToString();
                // 
                // idRetard
                // 
                idRetard.AutoSize = true;
                idRetard.Location = new System.Drawing.Point(3, 0);
                idRetard.Name = "idRetard";
                idRetard.Size = new System.Drawing.Size(75, 15);
                idRetard.TabIndex = 0;
                idRetard.Text = dtoList[i].GetIdRetard().ToString();


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
                Program.SetNbr(id);
                Program.ChangePage("ficheRetard", "gestionRetards");

        }
    }
}
