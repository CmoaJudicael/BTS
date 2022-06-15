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
    class Bibliotheque
    {
        private long _id_bibliothèque;
        private string _localisation_bibliothèque;

        public Bibliotheque(long id_bibliothèque, string localisation_bibliothèque)
        {
            _id_bibliothèque = id_bibliothèque;
            _localisation_bibliothèque = localisation_bibliothèque;
        }
        public long GetId()
        {
            return this._id_bibliothèque;
        }
        public void SetId(long id)
        {
            this._id_bibliothèque = id;
        }
        public string GetLocalisation()
        {
            return this._localisation_bibliothèque;
        }
        public void SetLocalisation(string localisation)
        {
            this._localisation_bibliothèque = localisation;
        }

        public override bool Equals(object obj)
        {
            return obj is Bibliotheque bibliotheque &&
                   _id_bibliothèque == bibliotheque._id_bibliothèque &&
                   _localisation_bibliothèque == bibliotheque._localisation_bibliothèque;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id_bibliothèque, _localisation_bibliothèque);
        }
    }
}
