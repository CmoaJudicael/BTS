using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

/*
 * 
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class AdministreDAO
    {
        private C_bdd database;
        private AdministreMapper mapper;

        public AdministreDAO()
        {
            this.database = new C_bdd();
            this.mapper = new AdministreMapper();
        }

        public List<Administre> FindAll()
        {

            string sql = AdministreQueries.GetFindAll();
            List<Administre> administreList = new List<Administre>();
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        administreList.Add(mapper.MapRow(dataReader));
                    }
                }
            }
            database.CloseConnexion();
            return administreList;

        }
        public Administre FindById(long _id_Administre)
        {
            string sql = AdministreQueries.GetFindById(_id_Administre);
            Administre administre;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return administre = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }
        public Administre FindByName(string _name_Administre)
        {
            string sql = AdministreQueries.GetFindByName(_name_Administre);
            Administre administre;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return administre = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }
        public Administre FindByLog(string _log_id_Administre, string _log_pw_Administre)
        {
            string sql = AdministreQueries.GetFindByLog(_log_id_Administre, _log_pw_Administre);
            Administre administre;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return administre = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }

        public long Insert(Administre administre)
        {
            return database.RequestInsert(AdministreQueries.GetInsert(administre));
        }



        public void Delete(long _id_Administre)
        {
            database.RequestDelete(AdministreQueries.GetDeleteById(_id_Administre));
        }


        public Administre Update(Administre administre)
        {
            if(database.RequestUpdate(AdministreQueries.GetUpdate(administre)))
            {
                Administre administre1 = FindById(administre.Get_id_Administre());
                return administre1 ;

            }
            return administre;
        }
    }
}
