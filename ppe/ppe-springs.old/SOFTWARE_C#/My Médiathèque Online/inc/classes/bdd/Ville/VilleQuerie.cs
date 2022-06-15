using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class VilleQuerie
    {
        public static string GetFindAll()
        {
            return "SELECT * from ville ;";
        }
        public static string GetFindId(long id)
        {
            return "SELECT * from ville WHERE _id_ville = '"+id+"' ;";
        }
    }
}
