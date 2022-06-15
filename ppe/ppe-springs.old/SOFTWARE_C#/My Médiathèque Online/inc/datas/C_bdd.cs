using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography;
using My_Médiathèque_Online.inc.view;
/*
 * judicael 11/04/2022
 *
 */

namespace My_Médiathèque_Online
{
    class C_bdd
    {
        private MySqlConnection conn;
        public C_bdd()
        {

        }
        //Méthode de hash sha256
        private static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
        //close connexion
        public void CloseConnexion()
        {
            conn.Close();
        }
        // Methode de connexion à la bdd
        private MySqlConnection Connectsql()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }
            return conn;

        }

        // C R U D

        // requette sql Insert /C
        public long RequestInsert(string sql)
        {
            MySqlConnection conn = Connectsql();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;

        }
        // requette sql Read /R
        public DbDataReader RequestRead(string sql)
        {
            this.conn = Connectsql();
            MySqlCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        // requette sql Update /U
        public bool RequestUpdate(string sql)
        {
            MySqlConnection conn = Connectsql();
            MySqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true ;
            }
            catch
            {
                return false;
            } 
        }
        // requette sql delete /D
        public int RequestDelete(string sql)
        {
            MySqlConnection conn = Connectsql();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery(); ;
        }


    }
}
