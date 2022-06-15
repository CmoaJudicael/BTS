using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using My_Médiathèque_Online.secure;

/*
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            //string host = "mysql-springs.alwaysdata.net";
            //string port = "3306";
            //string database = "springs_bdd_ppe";
            //string username = "springs_";
            //string password = "gcNpIKsZsm1LtoU12Sye";
            SecureScrypt secure = new();
                    var appSettings = ConfigurationManager.AppSettings;

                    string host = secure.DeChiffrage(appSettings["host"]);
                    string port = secure.DeChiffrage(appSettings["port"]);
                    string database = secure.DeChiffrage(appSettings["database"]);
                    string username = secure.DeChiffrage(appSettings["username"]);
                    string password = secure.DeChiffrage(appSettings["password"]);

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

         

    }
}
