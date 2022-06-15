using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online
{
    class LivresDTO
    {

        private long _isbn_livre, _id_bibliotheque;
        private bool _est_emprunte;
        private string _nom_livre, _nom_editeur_livre, _date_edition_livre, _nom_collection_livre, _resume_livre;


        public long GetIsbn()
        {
            return this._isbn_livre;
        }
        public void SetIsbn(long isbn)
        {
            this._isbn_livre = isbn;
        }
        public long GetId()
        {
            return this._id_bibliotheque;
        }
        public void SetId(long isbn)
        {
            this._id_bibliotheque = isbn;
        }

        public bool GetEmprunte()
        {
            return this._est_emprunte;
        }
        public void SetEmprunte(bool emprunte)
        {
            this._est_emprunte = emprunte;
        }

        public string GetNomLivre()
        {
            return this._nom_livre;
        }

        public void SetNomLivre(string NomLivre)
        {
            this._nom_livre = NomLivre;
        }

        public string GetEditeurLivre()
        {
            return this._nom_editeur_livre;
        }

        public void SetEditeurLivre(string EditeurLivre)
        {
            this._nom_editeur_livre = EditeurLivre;
        }

        public string GetDateEdition()
        {
            return this._date_edition_livre;
        }

        public void SetDateEdition(string DateEdition)
        {
            this._date_edition_livre = DateEdition;
        }

        public string GetNomCollection()
        {
            return _nom_collection_livre;
        }

        public void SetNomCollection(string NomCollection)
        {
            this._nom_collection_livre = NomCollection;
        }

        public string GetResumeLivre()
        {
            return this._resume_livre;
        }

        public void SetResumeLivre(string ResumeLivre)
        {
            this._resume_livre = ResumeLivre;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
