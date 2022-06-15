using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * judicael 19/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class BibliothequeMapper
    {
        public Bibliotheque MapRow(DbDataReader reader)
        {
            if (reader.HasRows)
            {

                int _id_BibliothequeIndex = reader.GetOrdinal("_id_bibliotheque");
                long _id_bibliotheque = long.Parse(reader.GetString(_id_BibliothequeIndex));


                int _localisation_BibliothequeIndex = reader.GetOrdinal("_localisation_bibliotheque");
                string _localisation_bibliotheque = reader.GetString(_localisation_BibliothequeIndex);


                return new Bibliotheque(_id_bibliotheque, _localisation_bibliotheque);
            }
            else
            {
                return null;
            }
        }

    }
}
