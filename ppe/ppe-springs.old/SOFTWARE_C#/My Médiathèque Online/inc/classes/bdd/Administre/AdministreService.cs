using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.dao;
using My_Médiathèque_Online.secure;

/*
 * judicael 11/04/2022
 *
 */
namespace My_Médiathèque_Online.service
{
    class AdministreService
    {
        private AdministreDAO dao;
        private SecureScrypt secure;

        public AdministreService()
        {
            this.dao = new AdministreDAO();
            this.secure = new SecureScrypt();
        }

        public List<AdministreDTO> FindAll()
        {
            List<Administre> stream = dao.FindAll();
            List<AdministreDTO> administreDTO = new List<AdministreDTO>();
            foreach(Administre administre in stream)
            {
                administreDTO.Add(ToDTO(administre));
            }
            return administreDTO;
        }
        public AdministreDTO FindById(long id)
        {
            Administre Administre = dao.FindById(id);
            if (Administre != null)
            {
                return ToDTO(Administre);
            }
            else
            {
                return null;
            }
        }
        public AdministreDTO FindByName(string name)
        {
            Administre Administre = dao.FindByName(name);
            if(Administre != null)
            {
                return ToDTO(Administre);
            }
            else
            {
                return null;
            }
        }
        public AdministreDTO FindByLog(string log, string pw)
        {
            Administre Administre = dao.FindByLog(log, pw);
            if (Administre != null)
            {
                return ToDTO(Administre);
            }
            else
            {
                return null;
            }
        }

        public long Insert(AdministreDTO dto)
        {
            Administre Administre = ToEntity(dto);
            return dao.Insert(Administre);
        }

        public void Delete(long id)
        {
            dao.Delete(id);
        }
        public AdministreDTO Update(AdministreDTO dto)
        {
            return ToDTO(dao.Update(ToEntity(dto)));
        }

        private Administre ToEntity(AdministreDTO dto)
        {
            return new Administre(dto.Get_id_Administre(), dto.Get_id_ville_Administre(), dto.Get_id_role_Administre(), secure.Chiffrage(dto.Get_nom_Administre()), secure.Chiffrage(dto.Get_prenom_Administre()), secure.Chiffrage(dto.Get_adresse_Administre()), secure.Chiffrage(dto.Get_mail_Administre()), dto.Get_log_id_Administre(), secure.Chiffrage(dto.Get_telephone_Administre()), dto.Get_log_password_Administre(), dto.Get_code_Administre());
        }
        private static AdministreDTO ToDTO(Administre administre)
        {
            AdministreDTO AdministreDTO = new AdministreDTO();
            AdministreDTO.Set_id_Administre(administre.Get_id_Administre());
            AdministreDTO.Set_nom_Administre(administre.Get_nom_Administre());
            AdministreDTO.Set_prenom_Administre(administre.Get_prenom_Administre());
            AdministreDTO.Set_adresse_Administre(administre.Get_adresse_Administre());
            AdministreDTO.Set_mail_Administre(administre.Get_mail_Administre());
            AdministreDTO.Set_log_id_Administre(administre.Get_log_id_Administre());
            AdministreDTO.Set_telephone_Administre(administre.Get_telephone_Administre());
            AdministreDTO.Set_log_password_Administre(administre.Get_log_password_Administre());
            AdministreDTO.Set_code_Administre(administre.Get_code_Administre());
            AdministreDTO.Set_id_ville_Administre(administre.Get_id_ville_Administre());
            AdministreDTO.Set_id_role_Administre(administre.Get_id_role_Administre());

            return AdministreDTO;
        }
    }
}
