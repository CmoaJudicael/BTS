using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * judicael 19/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class BibliothequeQueries
    {
        public static string GetFindById(long idBibliotheque)
        {
            return "SELECT * FROM bibliotheque WHERE _id_bibliotheque = " + idBibliotheque + ";";
        }
        public static string GetDeleteById(long idBibliotheque)
        {
            return "DELETE FROM bibliotheque WHERE ID = " + idBibliotheque + ";";

        }
        public static string GetInsertById(Bibliotheque bibliotheque)
        {
            return "INSERT INTO `bibliotheque`(`_localisation_bibliothèque`) VALUES ('"+ bibliotheque.GetLocalisation()+"');";
        }
        public static string GetFindAll()
        {
            return "SELECT * FROM bibliotheque;";
        }
    }
}
