using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class RetardQueries
    {
        public static string GetFindAll()
        {
            return "SELECT * from `en_retard`;";
        }
        public static string GetFindBy(long id)
        {
            return "SELECT * from `en_retard` WHERE _id_Retard_en_cours = '" + id + "';";
        }
    }
}
