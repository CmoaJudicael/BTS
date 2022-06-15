using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Threading.Tasks;
/*
 * judicael 19/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class BibliothequeDAO
    {
        private C_bdd database;
        private BibliothequeMapper mapper;

        public BibliothequeDAO()
        {
            this.database = new C_bdd();
            this.mapper = new BibliothequeMapper();
        }

        public List<Bibliotheque> FindAll()
        {
            string sql = BibliothequeQueries.GetFindAll();
            List<Bibliotheque> bibliothequesList = new List<Bibliotheque>();
            DbDataReader dataReader = database.RequestRead(sql);

            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        bibliothequesList.Add(mapper.MapRow(dataReader));
                    }
                }
            }
            database.CloseConnexion();
            return bibliothequesList;
        }
        public Bibliotheque FindById(long _id_bibliotheque)
        {
            string sql = AdministreQueries.GetFindById(_id_bibliotheque);
            Bibliotheque bibliotheque;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return bibliotheque = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }
        public Bibliotheque Insert(Bibliotheque bibliotheque)
        {
            return FindById(database.RequestInsert(BibliothequeQueries.GetInsertById(bibliotheque)));
        }
        public void Delete(long id)
        {
            database.RequestDelete(BibliothequeQueries.GetDeleteById(id));
        }



    }
}
