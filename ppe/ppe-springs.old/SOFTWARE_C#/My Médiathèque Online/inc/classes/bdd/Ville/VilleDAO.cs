using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class VilleDAO
    {
        private C_bdd database;
        private VilleMapper mapper;
        public VilleDAO()
        {
            this.database = new C_bdd();
            this.mapper = new VilleMapper();
        }

        public List<Ville> FindAll()
        {

            string sql = VilleQuerie.GetFindAll();
            List<Ville> villes = new List<Ville>();
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        villes.Add(mapper.MapRow(dataReader));
                    }
                }
            }
            database.CloseConnexion();
            return villes;

        }
        public Ville FindById(long _id_ville)
        {
            string sql = VilleQuerie.GetFindId(_id_ville);
            Ville ville;
            DbDataReader dataReader = database.RequestRead(sql);
            using (dataReader)
            {

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return ville = mapper.MapRow(dataReader);
                    }
                }
            }
            database.CloseConnexion();
            return null;
        }

    }
}
