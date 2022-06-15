using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *
 * Alexandra Calonico 19/04/2022 creation de la classe
 *
 */

namespace My_Médiathèque_Online.dao
{
    class Livres // Creation de objet Livre qui a l'information des livres 
    {
        // Attribut
        private long _isbn_livre, _id_bibliotheque; //private pour eviter que tout les autrhes classes peut acceder
        private bool _est_emprunte;
        private string _nom_livre, _nom_editeur_livre, _date_edition_livre, _nom_collection_livre, _resume_livre;

        //constructeur                //parametre constructeur
        public Livres(long isbn_livre, long id_bibliotheque, bool est_emprunte, string nom_livre, string nom_editeur_livre, string date_edition_livre, string nom_collection_livre, string resume_livre)
        
        {  //this, pour faire reference al objet que nous avons creer  et aussi pour assinge le valeur des parametres 
            this._isbn_livre = isbn_livre;
            this._id_bibliotheque = id_bibliotheque;
            this._est_emprunte = est_emprunte;
            this._nom_livre = nom_livre;
            this._nom_editeur_livre = nom_editeur_livre;
            this._date_edition_livre = date_edition_livre;
            this._nom_collection_livre = nom_collection_livre;
            this._resume_livre = resume_livre;
        }

        //getter and setter //getter c'est pour get des valeurs des attributes 
        public long GetIsbn()
        {
            return this._isbn_livre;
        }
        // setter// c'est pour modifier des valeurs des attributes 
        public void SetIsbn(long isbn)
        {
            this._isbn_livre=isbn;
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
        public void SetEmprunte (bool emprunte)
        {
            this._est_emprunte = emprunte;
        }

        public string GetNomLivre ()
        {
            return this._nom_livre;
        }

        public void  SetNomLivre ( string NomLivre )
        {
            this._nom_livre = NomLivre;
        }

        public string GetEditeurLivre ()
        {
            return this._nom_editeur_livre;
        }

        public void SetEditeurLivre( string EditeurLivre)
        {
            this._nom_editeur_livre = EditeurLivre; 
        }

        public string GetDateEdition ()
        {
            return this._date_edition_livre; 
        }

        public void SetDateEdition (string DateEdition)
        {
            this._date_edition_livre = DateEdition;
        }

        public string GetNomCollection ()
        {
            return _nom_collection_livre;
        }

        public void SetNomCollection (string NomCollection)
        { 
            this._nom_collection_livre = NomCollection;
        }

        public string GetResumeLivre ()
        {
         return this._resume_livre;
        }

        public void SetResumeLivre (string ResumeLivre) 
        { 
            this._resume_livre = ResumeLivre; 
        }

        // Determine si les deux instances d'objet sont egales 
        public override bool Equals(object obj)
        {

            //Il return true o flase 
            return obj is Livres livres &&
                   _isbn_livre == livres._isbn_livre &&
                   _id_bibliotheque == livres._id_bibliotheque &&
                   _est_emprunte == livres._est_emprunte &&
                   _nom_livre == livres._nom_livre &&
                   _nom_editeur_livre == livres._nom_editeur_livre &&
                   _date_edition_livre == livres._date_edition_livre &&
                   _nom_collection_livre == livres._nom_collection_livre &&
                   _resume_livre == livres._resume_livre;
        }
        //GetHashCode c'est un methode que return the hash code// hash code = c'est a numerique valeur qui c'est utilice pour insert et identifie un objet.
        public override int GetHashCode()
        {
            return HashCode.Combine(_isbn_livre, _id_bibliotheque, _est_emprunte, _nom_livre, _nom_editeur_livre, _date_edition_livre, _nom_collection_livre, _resume_livre);
        }

        public override string ToString()
        {
            return "livre : " + _nom_livre + " \nisbn : " +_isbn_livre;
        }
    }


}
