using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class LivresQueries 
    {
        public static string GetFindAll() 
        {
            return "SELECT * FROM `livre` ;"; //Requet pour trouver tout des livres
        }

        public static string GetBookById(long id)  // La Function (methode) GetBookById pour recupere un livre specifique par rapport a son id
                                                  //J'ai crée la variable id pour pouvre ajouter le ID (_isbn_livre) a chaque fois que je voudre chercher un livre especifique
        {
            return "SELECT * FROM `livre` WHERE _isbn_livre = "+id+" ;";
        }
    }
}
