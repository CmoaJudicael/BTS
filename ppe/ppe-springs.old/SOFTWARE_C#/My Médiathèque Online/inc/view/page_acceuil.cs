using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * judicael 11/04/2022
 *
 */

namespace My_Médiathèque_Online.inc.view
{
    public partial class page_acceuil : Form
    {
        public page_acceuil()
        {
            System.Diagnostics.Debug.WriteLine("public page_accueil");
            InitializeComponent();
            Program.IsConnected();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Program.ChangePage("login", "accueil");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestionLivres", "accueil");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestionBiblio", "accueil");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestion_users", "accueil");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Program.ChangePage("gestionRetards", "accueil");
        }
    }
}
