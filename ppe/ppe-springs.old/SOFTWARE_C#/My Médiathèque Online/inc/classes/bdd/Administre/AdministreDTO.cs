using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online
{
    class AdministreDTO
    {
        private long _id_Administre, _id_ville_Administre, _id_role_Administre;
        private string _nom_Administre, _prenom_Administre, _adresse_Administre, _mail_Administre, _log_id_Administre, _telephone_Administre, _log_password_Administre, _code_Administre;
        
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
            return _nom_Administre;
        }

        public void Set_nom_Administre(string _nom_Administre)
        {
            this._nom_Administre = _nom_Administre;
        }

        public string Get_prenom_Administre()
        {
            return _prenom_Administre;
        }

        public void Set_prenom_Administre(string _prenom_Administre)
        {
            this._prenom_Administre = _prenom_Administre;
        }

        public string Get_adresse_Administre()
        {
            return _adresse_Administre;
        }

        public void Set_adresse_Administre(string _adresse_Administre)
        {
            this._adresse_Administre = _adresse_Administre;
        }

        public string Get_mail_Administre()
        {
            return _mail_Administre;
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
            return _telephone_Administre;
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
            return _code_Administre;
        }

        public void Set_code_Administre(string _code_Administre)
        {
            this._code_Administre = _code_Administre;
        }

        public override bool Equals(object obj)
        {
            return obj is AdministreDTO dTO &&
                   _id_Administre == dTO._id_Administre &&
                   _id_ville_Administre == dTO._id_ville_Administre &&
                   _id_role_Administre == dTO._id_role_Administre &&
                   _nom_Administre == dTO._nom_Administre &&
                   _prenom_Administre == dTO._prenom_Administre &&
                   _adresse_Administre == dTO._adresse_Administre &&
                   _mail_Administre == dTO._mail_Administre &&
                   _log_id_Administre == dTO._log_id_Administre &&
                   _telephone_Administre == dTO._telephone_Administre &&
                   _log_password_Administre == dTO._log_password_Administre &&
                   _code_Administre == dTO._code_Administre;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_id_Administre);
            hash.Add(_id_ville_Administre);
            hash.Add(_id_role_Administre);
            hash.Add(_nom_Administre);
            hash.Add(_prenom_Administre);
            hash.Add(_adresse_Administre);
            hash.Add(_mail_Administre);
            hash.Add(_log_id_Administre);
            hash.Add(_telephone_Administre);
            hash.Add(_log_password_Administre);
            hash.Add(_code_Administre);
            return hash.ToHashCode();
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
