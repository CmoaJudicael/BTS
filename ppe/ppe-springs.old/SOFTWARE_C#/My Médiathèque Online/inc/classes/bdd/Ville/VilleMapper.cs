using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class VilleMapper
    {
        public Ville MapRow(DbDataReader reader)
        {
            if (reader.HasRows)
            {

                int _id_VilleIndex = reader.GetOrdinal("_id_ville");
                long _id_Ville = long.Parse(reader.GetString(_id_VilleIndex));

                int _nom_villeIndex = reader.GetOrdinal("_nom_ville");
                string _nom_ville = reader.GetString(_nom_villeIndex);

                int _cp_villeIndex = reader.GetOrdinal("_CP_ville");
                string _cp_ville = reader.GetString(_cp_villeIndex);


                return new Ville(_id_Ville, _nom_ville, _cp_ville);
            }
            else
            {
                return null;
            }
        }


    }
}
