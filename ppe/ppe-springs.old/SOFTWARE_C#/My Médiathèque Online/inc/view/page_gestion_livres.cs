using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * 
 * Alexandra 16/04/2022 création de la form 
 * 
 */

namespace My_Médiathèque_Online.inc.view
{
    public partial class page_gestion_livres : Form
    {
        //Siempre empiezo mi clase declarando mis atributos. Un atributo es una variable o un objeto. TODO EL TIEMPO
        private List<Panel> panels = new(); 
        private List<LivresDTO> dtoList;
        private ControleurLivres Controleur = new();

        // después de los atributos, creo mi constructor.TODO EL TIEMPO
        public page_gestion_livres()
        {
            InitializeComponent();

        }
        //después de agregar los métodos que necesito.TODO EL TIEMPO

        //creacion automatica con boton derecho 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dtoList = Controleur.GetAllBook();
            InitialiseBookComponent();
        }
        private void InitialiseBookComponent()
        {
            panels.Clear();//vider la liste panels quand la method est appelle

            int xPos = 10, yPos = 10, tabIndex = 0;//déclaration des int utilisable

            for (int i = 0; i < this.dtoList.Count; i++)// Boucle for de création affichage graphique
            {
                //mise en place des labels
                Label isbnLivre = new();
                Label nomLivre = new();
            
                //
                // Panel
                //
                panels.Add(new Panel());//création et ajout du panel dans la liste

                containerPanel.Controls.Add(panels[i]);//ajout du panel dans le panel contenair

                panels[i].BackColor = Color.Gainsboro;// color bg

                panels[i].Controls.Add(isbnLivre);// ajout de label
                panels[i].Controls.Add(nomLivre);// ajout de label

                panels[i].Location = new Point(xPos, yPos);//positionnement

                panels[i].Name = i.ToString();//Nommage du panel

                panels[i].Size = new Size(140, 80);//def taille du panel

                panels[i].TabIndex = ++tabIndex;//indexation de la tabulation

                long idPanel = dtoList[i].GetIsbn();

                panels[i].Click += new EventHandler((sender, e) => ShowUser_Click(sender, e, idPanel));

                //
                //Configuration des labels
                // 
                // isbnLivre
                // 
                isbnLivre.AutoSize = true;
                isbnLivre.Location = new System.Drawing.Point(3, 0); 
                isbnLivre.Name = "isbnLivre" + i;
                isbnLivre.Size = new System.Drawing.Size(107, 15);
                isbnLivre.TabIndex = 1;
                isbnLivre.Text = dtoList[i].GetIsbn().ToString();
                // 
                // nomLivre
                // 
                nomLivre.AutoSize = true;
                nomLivre.Location = new System.Drawing.Point(3, 25);
                nomLivre.Name = "nomLivre";
                nomLivre.Size = new System.Drawing.Size(50, 60);
                nomLivre.TabIndex = 2;
                nomLivre.Text = dtoList[i].GetNomLivre();
                // 
                //
               


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




        /*

        private void button_Alexandra_Click(object sender, EventArgs e)
        {
            
            //listBoxAlexandra.Items.Clear();
            List<LivresDTO> livresDTOs = new List<LivresDTO>(); //Pour la creation de list on utilice list et ajouter le nom de la liste, pour creer le objet

            livresDTOs = Program.GetAllBook();// GetallBook la funtion (method) qui va a chercher dans le controler (program) le livres, et ajoutera dans livresDTO

            foreach (LivresDTO livresDTO in livresDTOs) // par chacun Livres al interior de LivresDTos 
            {
              
                //listBoxAlexandra.Items.Add(livresDTO.GetNomLivre()); //pour chaque element dans ma liste il va affiche dans la list BoxAlexandra le nom de livre (string) dans la function (method) deja cree GetNomLivre


            }
            
            


             

        }*/


    }
}
