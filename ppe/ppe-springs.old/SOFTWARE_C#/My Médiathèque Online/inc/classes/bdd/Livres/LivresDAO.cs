using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class LivresDAO //liasion base de donne
    {

        private C_bdd database;
        private LivresMappers mapper;

        public LivresDAO()
        {
            this.database = new C_bdd();
            this.mapper = new LivresMappers();
        }

        public List<Livres> FindAll()
        {
            string sql = LivresQueries.GetFindAll(); //recupere la requet envoye a la base de donnee 
            List<Livres> Livrelist = new List<Livres>(); // entre <> indique quelle type de valeur il stocke. // instanciate 
            DbDataReader reader = database.RequestRead(sql); //DbDataReader class qui a tout les colection des information que tu a fait dans la requete a la database
            //readear il recoit tout l'information qui la base de donne envoye// al interieur de un objet dans la classe de  C_bdd
            using (reader)
            {
                if (reader.HasRows) //HasRows c'est juste pour verifie qui a un ligne
                {
                    while (reader.Read()) //le bucle il va lire chaque ligne 
                    {
                        Livrelist.Add(mapper.MapRow(reader)); //  le objet mapper il va recuperer le columne de la ligne de reader  dans MapRow, et vas a renvoyer un objet livre qui sera ajouter dans la liste

                    }

                }
            }
            return Livrelist;
        }
        public Livres GetBookById(long id)// function (method) GetBookById, le parametre de id      
        {
            string sql = LivresQueries.GetBookById(id); //GetBookId(id) pour recuperer la requet envoye a la base de donne (LivresQueries)
            Livres livres;
            DbDataReader reader = database.RequestRead(sql);
            using (reader)
            {
                if (reader.HasRows) //HasRows c'est juste pour verifie qui a un ligne
                {
                    while (reader.Read()) //le bucle il va lire chaque ligne 
                    {
                        return livres = mapper.MapRow(reader); //  le objet mapper il va recuperer le columne de la ligne de reader  dans MapRow, et vas a renvoyer un objet livre qui sera ajouter dans la liste

                    }

                }
            }
            return null;
        }
    }
}
