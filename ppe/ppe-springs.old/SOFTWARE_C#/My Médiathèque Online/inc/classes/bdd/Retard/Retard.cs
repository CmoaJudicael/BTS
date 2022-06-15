using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao
{
    class Retard
    {
        private long _id_Administre, _isbn_livre, _id_Retard_en_cours;

        public Retard(long id_Administre, long isbn_livre, long id_Retard_en_cours)
        {
            _id_Administre = id_Administre;
            _isbn_livre = isbn_livre;
            _id_Retard_en_cours = id_Retard_en_cours;
        }

        public long GetIdAdm()
        {
            return this._id_Administre;
        }
        public void SetIdAdm(long id)
        {
            this._id_Administre = id;
        }
        public long GetIsbn()
        {
            return this._isbn_livre;
        }
        public void SetIsbn(long id)
        {
            this._isbn_livre = id;
        }
        public long GetIdRetard()
        {
            return this._id_Retard_en_cours;
        }
        public void SetIdRetard(long id)
        {
            this._id_Retard_en_cours = id;
        }

        public override bool Equals(object obj)
        {
            return obj is Retard retard &&
                   _id_Administre == retard._id_Administre &&
                   _isbn_livre == retard._isbn_livre &&
                   _id_Retard_en_cours == retard._id_Retard_en_cours;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id_Administre, _isbn_livre, _id_Retard_en_cours);
        }

        public override string ToString()
        {
            return "idAdministre : "+this._id_Administre+ " ISBN : " + this._isbn_livre + " IdRetard : " + this._id_Retard_en_cours + "";
        }
    }
}
