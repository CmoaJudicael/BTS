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
 *Judicael 26/04/2022
 */
namespace My_Médiathèque_Online.inc.view
{
    public partial class page_userRecord : Form
    {
        private AdministreDTO administreDTO;
        private List<VilleDTO> villes;
        private ControleurAdministre controleurAdm;
        private ControleurVille controleurVille;

        public page_userRecord()
        {
            this.controleurAdm = new();
            this.controleurVille = new();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            administreDTO = controleurAdm.GetAdministreById(Program.GetNbr());
            villes = controleurVille.GetAllVille();
            InitUserInfo();
            infoText.Text = "";
        }
        private void InitUserInfo()
        {
            nomTxtBox_userRcord.Text = this.administreDTO.Get_nom_Administre();
            prenomTxtBox_userRcord.Text = this.administreDTO.Get_prenom_Administre();
            adressTxtBox_userRcord.Text = this.administreDTO.Get_adresse_Administre();
            mailTxtBox_userRcord.Text = this.administreDTO.Get_mail_Administre();
            phoneTxtBox_userRcord.Text = this.administreDTO.Get_telephone_Administre();
            codeTxtBox_userRcord.Text = this.administreDTO.Get_code_Administre();


            foreach (VilleDTO ville in this.villes)
            {
                if (this.administreDTO.Get_id_ville_Administre() == ville.Get_id())
                {
                    cpCombBox_userRcord.Text = ville.Get_CP();
                    villeTxtBox_userRcord.Text = ville.Get_Name();
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.ChangePage("login", "userRecord");
        }

        private void btn_return_gestUsers_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestion_users", "userRecord");
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            initDto();
        }
        private void initDto()
        {
            infoText.Text = "";
                System.Diagnostics.Debug.WriteLine("click " );
            foreach (VilleDTO ville in this.villes)
            {
                System.Diagnostics.Debug.WriteLine("ville "+ ville.ToString());
                if (cpCombBox_userRcord.Text == ville.Get_Name())
                {
                    System.Diagnostics.Debug.WriteLine("nom : " + nomTxtBox_userRcord.Text);
                    administreDTO.Set_id_ville_Administre(ville.Get_id());
                }
            }
            if (nomTxtBox_userRcord.Text != "" && prenomTxtBox_userRcord.Text != "" && adressTxtBox_userRcord.Text != "" && cpCombBox_userRcord.Text != "" && villeTxtBox_userRcord.Text != "" && phoneTxtBox_userRcord.Text != "" && mailTxtBox_userRcord.Text != "")
            {
                System.Diagnostics.Debug.WriteLine("coucou ");
                administreDTO.Set_nom_Administre(nomTxtBox_userRcord.Text);
                administreDTO.Set_prenom_Administre(prenomTxtBox_userRcord.Text);
                administreDTO.Set_adresse_Administre(adressTxtBox_userRcord.Text);
                administreDTO.Set_telephone_Administre(phoneTxtBox_userRcord.Text);
                administreDTO.Set_mail_Administre(mailTxtBox_userRcord.Text);

                administreDTO = controleurAdm.UpdateAdministre(administreDTO);

                InitUserInfo();
                infoText.Text = "Utilisateur Modifié";
            }
            else
            {

                System.Diagnostics.Debug.WriteLine("problema ");
            }
        }
    }
}
