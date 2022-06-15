using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class AdministreMapper
    {

        public Administre MapRow(DbDataReader reader)
        {
            if(reader.HasRows)
            {
                
                int _id_AdministreIndex = reader.GetOrdinal("_id_Administre");
                long _id_Administre = long.Parse(reader.GetString(_id_AdministreIndex));

                int _nom_AdministreIndex = reader.GetOrdinal("_nom_Administre");
                string _nom_Administre = reader.GetString(_nom_AdministreIndex);

                int _prenom_AdministreIndex = reader.GetOrdinal("_prenom_Administre");
                string _prenom_Administre = reader.GetString(_prenom_AdministreIndex);

                int _adresse_AdministreIndex = reader.GetOrdinal("_adresse_Administre");
                string _adresse_Administre = reader.GetString(_adresse_AdministreIndex);

                int _mail_AdministreIndex = reader.GetOrdinal("_mail_Administre");
                string _mail_Administre = reader.GetString(_mail_AdministreIndex);

                int _telephone_AdministreIndex = reader.GetOrdinal("_telephone_Administre");
                string _telephone_Administre = reader.GetString(_telephone_AdministreIndex);

                int _log_id_AdministreIndex = reader.GetOrdinal("_log_id_Administre");
                string _log_id_Administre = reader.GetString(_log_id_AdministreIndex);

                int _id_villeIndex = reader.GetOrdinal("_id_ville");
                long _id_ville = long.Parse(reader.GetString(_id_villeIndex));

                int _log_password_AdministreIndex = reader.GetOrdinal("_log_password_Administre");
                string _log_password_Administre = reader.GetString(_log_password_AdministreIndex);

                int _code_AdministreIndex = reader.GetOrdinal("_code_Administre");
                string _code_Administre = reader.GetString(_code_AdministreIndex);

                int _id_roleIndex = reader.GetOrdinal("_id_role");
                long _id_role = long.Parse(reader.GetString(_id_roleIndex));



                return new Administre(_id_Administre, _id_ville, _id_role, _nom_Administre, _prenom_Administre, _adresse_Administre, _mail_Administre, _log_id_Administre, _telephone_Administre, _log_password_Administre, _code_Administre);

            }
            else
            {
                return null;
            }
        }


    }
}
