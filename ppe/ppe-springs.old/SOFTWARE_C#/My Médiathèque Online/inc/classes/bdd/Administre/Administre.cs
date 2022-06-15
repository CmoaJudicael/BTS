using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.secure;

/*
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online.dao
{
    class Administre
    {

        private long _id_Administre, _id_ville_Administre, _id_role_Administre;
        private string _nom_Administre, _prenom_Administre, _adresse_Administre, _mail_Administre, _log_id_Administre, _telephone_Administre, _log_password_Administre, _code_Administre;
        private SecureScrypt secure = new();
        public Administre(long id_Administre, long id_ville_Administre, long id_role_Administre, string nom_Administre, string prenom_Administre, string adresse_Administre, string mail_Administre, string log_id_Administre, string telephone_Administre, string log_password_Administre, string code_Administre)
        {
            this._id_Administre = id_Administre;
            this._id_ville_Administre = id_ville_Administre;
            this._id_role_Administre = id_role_Administre;
            this._nom_Administre = nom_Administre;
            this._prenom_Administre = prenom_Administre;
            this._adresse_Administre = adresse_Administre;
            this._mail_Administre = mail_Administre;
            this._log_id_Administre = log_id_Administre;
            this._telephone_Administre = telephone_Administre;
            this._log_password_Administre = log_password_Administre;
            this._code_Administre = code_Administre;
        }
        public long Get_id_Administre()
        {
            return _id_Administre;
        }

        public void Set_id_Administre(long _id_Administre)
        {
            this._id_Administre = _id_Administre;
        }

        public long Get_id_ville_Administre()
        {
            return _id_ville_Administre;
        }

        public void Set_id_ville_Administre(long _id_ville_Administre)
        {
            this._id_ville_Administre = _id_ville_Administre;
        }

        public long Get_id_role_Administre()
        {
            return _id_role_Administre;
        }

        public void Set_id_role_Administre(long _id_role_Administre)
        {
            this._id_role_Administre = _id_role_Administre;
        }

        public string Get_nom_Administre()
        {
            return secure.DeChiffrage(_nom_Administre);
        }

        public void Set_nom_Administre(string _nom_Administre)
        {
            this._nom_Administre = _nom_Administre;
        }

        public string Get_prenom_Administre()
        {
            return secure.DeChiffrage(_prenom_Administre);
        }

        public void Set_prenom_Administre(string _prenom_Administre)
        {
            this._prenom_Administre = _prenom_Administre;
        }

        public string Get_adresse_Administre()
        {
            return secure.DeChiffrage(_adresse_Administre);
        }

        public void Set_adresse_Administre(string _adresse_Administre)
        {
            this._adresse_Administre = _adresse_Administre;
        }

        public string Get_mail_Administre()
        {
            return secure.DeChiffrage(_mail_Administre);
        }

        public void Set_mail_Administre(string _mail_Administre)
        {
            this._mail_Administre = _mail_Administre;
        }

        public string Get_log_id_Administre()
        {
            return _log_id_Administre;
        }

        public void Set_log_id_Administre(string _log_id_Administre)
        {
            this._log_id_Administre = _log_id_Administre;
        }

        public string Get_telephone_Administre()
        {
            return secure.DeChiffrage(_telephone_Administre);   
        }

        public void Set_telephone_Administre(string _telephone_Administre)
        {
            this._telephone_Administre = _telephone_Administre;
        }

        public string Get_log_password_Administre()
        {
            return _log_password_Administre;
        }

        public void Set_log_password_Administre(string _log_password_Administre)
        {
            this._log_password_Administre = _log_password_Administre;
        }

        public string Get_code_Administre()
        {
            return secure.DeChiffrage(_code_Administre);
        }

        public void Set_code_Administre(string _code_Administre)
        {
            this._code_Administre = _code_Administre;
        }

        public override bool Equals(object obj)
        {
            return obj is Administre administre &&
                   _id_Administre == administre._id_Administre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id_Administre);
        }

        public override string ToString()
        {
            return "Administre{" +
                "_id_Administre=" + _id_Administre +
                ", _id_ville_Administre=" + _id_ville_Administre +
                ", _id_role_Administre=" + _id_role_Administre +
                ", _nom_Administre='" + _nom_Administre + '\'' +
                ", _prenom_Administre='" + _prenom_Administre + '\'' +
                ", _adresse_Administre='" + _adresse_Administre + '\'' +
                ", _mail_Administre='" + _mail_Administre + '\'' +
                ", _log_id_Administre='" + _log_id_Administre + '\'' +
                ", _telephone_Administre='" + _telephone_Administre + '\'' +
                ", _log_password_Administre='" + _log_password_Administre + '\'' +
                ", _code_Administre='" + _code_Administre + '\'' +
                "}";
        }

    }
}
