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
 * Judicael 05/05/2022
 * 
 * **/
namespace My_Médiathèque_Online.inc.view
{
    public partial class page_ficheRetard : Form
    {
        private RetardDTO retard;
        private ControleurRetard controleur;
        public page_ficheRetard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            controleur = new();
            retard = controleur.GetRetardById(Program.GetNbr());
            System.Diagnostics.Debug.WriteLine("ertard : "+retard.ToString());

            initialisation();
        }
        private void initialisation()
        {
            idRetard.Text = retard.GetIdRetard().ToString();
            nomAdm.Text = retard.GetNomAdm();
            isbnRetard.Text = retard.GetIsbn().ToString();
        }

        private void button_ficheAdm_Click(object sender, EventArgs e)
        {
            Program.SetNbr(retard.GetIdAdm());
            Program.ChangePage("userRecord", "ficheRetard");
        }

        private void button_ficheLivre_Click(object sender, EventArgs e)
        {
            //en Attente
            //Program.SetNbr(retard.GetIdAdm());
            //Program.ChangePage("ficheLivre", "ficheRetard");
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestionRetards", "ficheRetard");
        }
    }
}
