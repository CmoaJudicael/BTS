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
    public partial class StartUp : Form
    {
        public  StartUp()
        {
            InitializeComponent();
            IsLoad();
        }
        private void IsLoad()
        {
            Program.ChangePage("accueil", "none");
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DLogButton_Click(object sender, EventArgs e)
        {
            Program.ChangePage("login", "none");
        }
    }
}
