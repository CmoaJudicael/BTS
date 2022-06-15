using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * judicael 19/04/2022
 *
 */
namespace My_Médiathèque_Online
{
    class BibliothequeDTO
    {
        private long _id_bibliothèque;
        private string _localisation_bibliothèque;

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


    }
}
