using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using My_Médiathèque_Online.controler;



namespace My_Médiathèque_Online
{
    public partial class Form1 : Form
    {
        private ControleurAdministre controleur = new();
        public Form1()
        {
            InitializeComponent();

            connText.Text = "";
        }
        private void connectsql()
        {
            texteCode.Text = "Getting Connection ...\n";

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                texteCode.Text += "Openning Connection ...\n";

                conn.Open();

                texteCode.Text = "Connection successful!";
                button1.Dispose();
                RecuperationNom(conn);


            }
            catch (Exception e)
            {
                texteCode.Text = "Error: " + e.Message;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectsql();
        }
        private void RecuperationNom(MySqlConnection conn)
        {
            String sql = "SELECT _id_Administre, _nom_Administre FROM Administre;";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Récupérez l'index de Column Emp_ID dans l'instruction de requête SQL.
                        int _id_AdministreIndex = reader.GetOrdinal("_id_Administre"); // 0
                        long _id_Administre = Convert.ToInt64(reader.GetValue(_id_AdministreIndex));


                        int _nom_AdministreIndex = reader.GetOrdinal("_nom_Administre");// 2
                        string _nom_Administre = reader.GetString(_nom_AdministreIndex);

                        
                        listNom.Items.Add("Id administré :" + _id_Administre + " Nom:" + _nom_Administre);
                    }
                }
            }


        }

        private void testModel_Click(object sender, EventArgs e)
        {
            List<AdministreDTO> dto = controleur.GetListAdministre();
            foreach(AdministreDTO admDTO in dto)
            {
                listNom.Items.Add(admDTO.ToString());
            }
        }
    }
}
