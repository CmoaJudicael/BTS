using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.dao;
/*
 * judicael 19/04/2022
 *
 */
namespace My_Médiathèque_Online.service
{

    class BibliothequeService
    {
        private BibliothequeDAO dao;

        public BibliothequeService()
        {
            this.dao = new BibliothequeDAO();
        }

        public List<BibliothequeDTO> FindAll()
        {
            List<Bibliotheque> stream = dao.FindAll();
            List<BibliothequeDTO> bibliothequeDTO = new List<BibliothequeDTO>();
            foreach (Bibliotheque bibliotheque in stream)
            {
                bibliothequeDTO.Add(ToDTO(bibliotheque));
            }
            return bibliothequeDTO;
        }
        public BibliothequeDTO FindById(long id)
        {
            Bibliotheque bibliotheque = dao.FindById(id);
            if (bibliotheque != null)
            {
                return ToDTO(bibliotheque);
            }
            else
            {
                return null;
            }
        }
        public BibliothequeDTO Insert(BibliothequeDTO dto)
        {
            Bibliotheque bibliotheque = ToEntity(dto);
            return ToDTO(dao.Insert(bibliotheque));
        }
        public void Delete(long id)
        {
            dao.Delete(id);
        }
        /*
        public bool Update(AdministreDTO administreDTO)
        {
            return dao.U;
        }
        */
        public Bibliotheque ToEntity(BibliothequeDTO dto)
        {
            return new Bibliotheque(dto.GetId(), dto.GetLocalisation());
        }
        public static BibliothequeDTO ToDTO(Bibliotheque bibliotheque)
        {
            BibliothequeDTO bibliothequeDTO = new BibliothequeDTO();
            bibliothequeDTO.SetId(bibliotheque.GetId());
            bibliothequeDTO.SetLocalisation(bibliotheque.GetLocalisation());

            return bibliothequeDTO;
        }
    }




}
