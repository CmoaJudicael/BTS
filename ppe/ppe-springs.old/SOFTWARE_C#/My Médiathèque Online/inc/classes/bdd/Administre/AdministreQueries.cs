using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.secure;
/*
 * judicael 11/04/2022
 *
 */

namespace My_Médiathèque_Online.dao
{
    class AdministreQueries
    {
        private static SecureScrypt secure = new SecureScrypt();
        public static string GetFindById(long idAdministre)
        {
            return "SELECT * FROM Administre WHERE _id_Administre = "+idAdministre + ";";
        }
        public static string GetFindByName(string nameAdministre)
        {
            return "SELECT * FROM Administre WHERE _nom_Administre = '" + nameAdministre + "' OR _prenom_Administre = '"+ nameAdministre +"';";
        }
        public static string GetFindByLog(string logAdministre, string pwAdministre)
        {
            return "SELECT * FROM Administre WHERE _log_id_Administre = '" + logAdministre + "' AND _log_password_Administre = '" + pwAdministre + "';";
        }

        public static string GetDeleteById(long idAdministre)
        {
            return "DELETE FROM Administre WHERE ID = "+ idAdministre + ";";
        }

        public static string GetUpdate(Administre administre)
        {
            return "UPDATE `Administre` SET `_nom_Administre`='" + secure.Chiffrage(administre.Get_nom_Administre()) + "',`_prenom_Administre`='" + secure.Chiffrage(administre.Get_prenom_Administre()) + "',`_adresse_Administre`='" + secure.Chiffrage(administre.Get_adresse_Administre()) + "',`_mail_Administre`='" + secure.Chiffrage(administre.Get_mail_Administre()) + "',`_telephone_Administre`='" + secure.Chiffrage(administre.Get_telephone_Administre()) + "',`_id_ville`='" + administre.Get_id_ville_Administre() + "',`_id_role`='1' WHERE _id_Administre = " + administre.Get_id_Administre() + " ;";
        }
        //UPDATE `Administre` SET `_nom_Administre`='ANTONIA',`_prenom_Administre`='BANDRAS',`_adresse_Administre`='6 PIED SOUS TERRE',`_mail_Administre`='NOPE@PASDSOUS.GRO',`_telephone_Administre`='0526523565',`_id_ville`='1' WHERE _id_Administre = 1

        public static string GetFindAll()
        {
            return "SELECT * from Administre ORDER BY _id_Administre;";
        }
        public static string GetFindPw()
        {

            string sql = "SELECT _log_id_Administre, _log_password_Administre FROM `Administre` WHERE _id_role = 2;";
            return sql;
        }
        public static string GetInsert(Administre administre)
        {

            string sql = "INSERT INTO `Administre`(`_nom_Administre`, `_prenom_Administre`, `_adresse_Administre`, `_mail_Administre`, `_telephone_Administre`, `_log_id_Administre`, `_log_password_Administre`, `_code_Administre`, `_id_ville`, `_id_role`) VALUES ('" + secure.Chiffrage(administre.Get_nom_Administre())+ "','" + secure.Chiffrage(administre.Get_prenom_Administre()) + "','" + secure.Chiffrage(administre.Get_adresse_Administre()) + "','" + secure.Chiffrage(administre.Get_mail_Administre()) + "','" + secure.Chiffrage(administre.Get_telephone_Administre()) + "','NOPE','NOPE','" + secure.Chiffrage(administre.Get_code_Administre()) + "'," + administre.Get_id_ville_Administre() + ",1 );";

            System.Diagnostics.Debug.WriteLine("string sql :"+sql);
            return sql;
        }
        public static string GetLastId()
        {
            string sql = "SELECT LAST_INSERT_ID();";
            return sql;
        }
    }
}
