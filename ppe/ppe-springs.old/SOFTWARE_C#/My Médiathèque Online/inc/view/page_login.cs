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
 * judicael 11/04/2022
 *
 */

namespace My_Médiathèque_Online
{
    public partial class page_login : Form
    {
        private ControleurAdministre controleur = new();
        public static string log_text = "";
        public page_login()
        {
            System.Diagnostics.Debug.WriteLine("public page_login");
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("page login button click");

            //this.Close();
            //Program.ChangePage("accueil");

            if (idTextBox.Text != "" && pwTextBox.Text != "")
            {
                                
                if(controleur.login(idTextBox.Text, pwTextBox.Text))
                {
                    Program.ChangePage("accueil", "login");
                }
                else
                {
                    infoConnexion.Text = "Désolé, mot de passe ou identifiant incorrect";
                }

            }
            else
            {
                infoConnexion.Text = "Désolé, mot de passe ou identifiant incorrect";
            }
        }

        private void PwChangeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ChangePage("mdp_demande", "login");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
