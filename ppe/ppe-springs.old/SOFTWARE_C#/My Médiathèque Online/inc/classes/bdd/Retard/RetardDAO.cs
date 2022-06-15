using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace My_Médiathèque_Online.dao
{
    class RetardDAO
    {
        private C_bdd database;
        private RetardMapper mapper;

        public RetardDAO()
        {
            this.database = new C_bdd();
            this.mapper = new RetardMapper();
        }
        public List<Retard> FindAll()
        {

            string sql = RetardQueries.GetFindAll();
            List<Retard> retardList = new List<Retard>();
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        retardList.Add(mapper.MapRow(dataReader));
                    }
                }
            }
            database.CloseConnexion();
            return retardList;

        }
        public Retard FindById(long _id_retard)
        {
            string sql = RetardQueries.GetFindBy(_id_retard);
            Retard retard;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return retard = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }


    }
}
