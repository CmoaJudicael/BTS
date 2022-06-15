using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class Ville
    {
        private long _id_ville;
        private string _nom_ville, _CP_ville;

        public Ville(long id_ville, string nom_ville, string cp_ville)
        {
            this._id_ville = id_ville;
            this._nom_ville = nom_ville;
            this._CP_ville = cp_ville;
        }

        public void Set_id(long id)
        {
            this._id_ville = id;
        }
        public long Get_id()
        {
            return this._id_ville;
        }
        public void Set_Name(string name)
        {
            this._nom_ville = name;
        }
        public string Get_Name()
        {
            return this._nom_ville;
        }
        public void Set_cp(string cp)
        {
            this._CP_ville = cp;
        }
        public string Get_CP()
        {
            return this._CP_ville;
        }

        public override bool Equals(object obj)
        {
            return obj is Ville ville &&
                   _id_ville == ville._id_ville;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id_ville);
        }
    }
}
