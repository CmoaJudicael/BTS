using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Médiathèque_Online.dao

{/**
 *
 * Alexandra Calonico 19/04/2022 creation de la classe
 *
 */
    class LivresMappers
    {
        public Livres MapRow(DbDataReader reader)
        {
            if (reader.HasRows)
            {
                int _isbn_livreIndex = reader.GetOrdinal("_isbn_livre");
                long _isbn_livre = long.Parse(reader.GetString(_isbn_livreIndex));

                int _id_bibliothequeIndex = reader.GetOrdinal("_id_bibliotheque");
                long _id_bibliotheque = long.Parse(reader.GetString(_id_bibliothequeIndex));

                int _est_emprunteIndex = reader.GetOrdinal("_est_emprunte");
                bool _est_emprunte = bool.Parse(reader.GetString(_est_emprunteIndex)); 

                int _nom_livreIndex = reader.GetOrdinal("_nom_livre");
                string _nom_livree  = reader.GetString (_nom_livreIndex); 

                int _nom_editeur_livreIndex = reader.GetOrdinal("_nom_editeur_livre");
                string _nom_editeur_livre = reader.GetString(_nom_editeur_livreIndex); 

                int _date_edition_livreIndex = reader.GetOrdinal("_date_edition_livre");
                string _date_edition_livre = reader.GetString(_date_edition_livreIndex); 


                int _nom_collection_livreIndex = reader.GetOrdinal("_nom_collection_livre");
                string _nom_collection_livre = reader.GetString(_nom_collection_livreIndex);

                int _resume_livreIndex = reader.GetOrdinal("_resume_livre");
                string _resume_livre = reader.GetString(_resume_livreIndex);






                return new Livres(_isbn_livre, _id_bibliotheque, _est_emprunte, _nom_livree, _nom_editeur_livre, _date_edition_livre, _nom_collection_livre, _resume_livre);


            }
            else
            {
                return null;
            }
        }
    }
}
