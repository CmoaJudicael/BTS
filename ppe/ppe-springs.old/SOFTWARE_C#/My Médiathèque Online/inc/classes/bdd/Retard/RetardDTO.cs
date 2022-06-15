using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online
{
    class RetardDTO
    {
        private long  _isbn_livre, _id_Retard_en_cours, _id_administre;
        private string _nom_Administre;

        public string GetNomAdm()
        {
            return this._nom_Administre;
        }
        public void SetNomAdm(string id)
        {
            this._nom_Administre = id;
        }
        public long GetIdAdm()
        {
            return this._id_administre;
        }
        public void SetIdAdm(long id)
        {
            this._id_administre = id;
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

        
        public override string ToString()
        {
            return "idAdministre : " + this._nom_Administre + " ISBN : " + this._isbn_livre + " IdRetard : " + this._id_Retard_en_cours + "";
        }

        public override bool Equals(object obj)
        {
            return obj is RetardDTO dTO &&
                   _nom_Administre == dTO._nom_Administre &&
                   _isbn_livre == dTO._isbn_livre &&
                   _id_Retard_en_cours == dTO._id_Retard_en_cours;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_nom_Administre, _isbn_livre, _id_Retard_en_cours);
        }
    }
}
