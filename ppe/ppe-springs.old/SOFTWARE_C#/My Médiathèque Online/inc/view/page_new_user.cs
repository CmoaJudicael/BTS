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
using System.Security.Cryptography;
/**
 * Judicael création form 28/04/2022
 *
 */
namespace My_Médiathèque_Online.inc.view
{
    public partial class page_new_user : Form
    {

        private List<VilleDTO> villes;
        private ControleurAdministre controleurAdm;
        private ControleurVille controleurVille;
        public page_new_user()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.controleurAdm = new();
            this.controleurVille = new();
            villes = controleurVille.GetAllVille();
            foreach(VilleDTO ville in villes)
            {
                cpCombBox_NewUserRcord.Items.Add(ville.Get_CP());
            }
        }
        private void cpCombBox_NewUserRcord_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(VilleDTO ville in villes)
            {
                if(ville.Get_CP() == cpCombBox_NewUserRcord.Text)
                {
                    villeTxtBox_NewUserRcord.Text = ville.Get_Name();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.ChangePage("login", "newUserRecord");
        }

        private void btn_retour_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestion_users", "newUserRecord");
        }

        private void btn_add_gestUsers_Click(object sender, EventArgs e)
        {
            if(nomTxtBox_NewUserRcord.Text!="" && prenomTxtBox_NewUserRcord.Text!="" && adressTxtBox_NewUserRcord.Text != "" && mailTxtBox_userRcord.Text != "" && phoneTxtBox_NewUserRcord.Text != "" && villeTxtBox_NewUserRcord.Text != "" && cpCombBox_NewUserRcord.Text != "")
            {
                AdministreDTO administreDTO = new AdministreDTO();
                administreDTO.Set_nom_Administre(nomTxtBox_NewUserRcord.Text);
                administreDTO.Set_prenom_Administre(prenomTxtBox_NewUserRcord.Text);
                administreDTO.Set_adresse_Administre(adressTxtBox_NewUserRcord.Text);
                administreDTO.Set_mail_Administre(mailTxtBox_userRcord.Text);
                administreDTO.Set_telephone_Administre(phoneTxtBox_NewUserRcord.Text);
                string code = "";
                for(int i = 0; i < 10; i++)
                {
                    if(i < 3)
                    {
                        code += nomTxtBox_NewUserRcord.Text[i];
                    }
                    else if (i < 6)
                    {
                        code += prenomTxtBox_NewUserRcord.Text[i-3];
                    }
                    else if(i < 9)
                    {
                        code += phoneTxtBox_NewUserRcord.Text[i - 6];
                    }
                    else
                    {
                        code += "@";
                    }
                }
                administreDTO.Set_code_Administre(code);
                foreach(VilleDTO ville in villes)
                {
                    if(ville.Get_Name() == villeTxtBox_NewUserRcord.Text)
                    {
                        administreDTO.Set_id_ville_Administre(ville.Get_id());
                    }
                }
                long id = controleurAdm.InsertAdministre(administreDTO);
                Mail mail = new();
                string destinataire = administreDTO.Get_mail_Administre() ;
                string objet = "Envoie de votre code";
                string body = "Voici votre code pour la création de votre compte sur le site web : "+administreDTO.Get_code_Administre();
                mail.SendMail(destinataire,)
                Program.SetNbr(id);
                Program.ChangePage("userRecord", "newUserRecord");

            }
        }
    }
}
