using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace My_Médiathèque_Online.dao
{
    class RetardMapper
    {
        public Retard MapRow(DbDataReader reader)
        {
            if (reader.HasRows)
            {

                int _id_AdministreIndex = reader.GetOrdinal("_id_Administre");
                long _id_Administre = long.Parse(reader.GetString(_id_AdministreIndex));

                int _isbn_livreIndex = reader.GetOrdinal("_isbn_livre");
                long _isbn_livre = long.Parse(reader.GetString(_isbn_livreIndex));

                int _id_RetardIndex = reader.GetOrdinal("_id_Retard_en_cours");
                long _id_Retard = long.Parse(reader.GetString(_id_RetardIndex));



                return new Retard(_id_Administre, _isbn_livre, _id_Retard);

            }
            else
            {
                return null;
            }
        }
    }
}
