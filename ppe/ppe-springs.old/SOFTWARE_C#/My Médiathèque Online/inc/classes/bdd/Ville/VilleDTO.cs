using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online
{
    class VilleDTO
    {
        private long _id_ville;
        private string _nom_ville, _CP_ville;


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
            return obj is VilleDTO dTO &&
                   _id_ville == dTO._id_ville &&
                   _nom_ville == dTO._nom_ville &&
                   _CP_ville == dTO._CP_ville;
        }

        public override string ToString()
        {
            return "ville : nom " + _nom_ville + " CP " + _CP_ville + " id " + _id_ville;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id_ville, _nom_ville, _CP_ville);
        }
    }
}
