using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.dao;

namespace My_Médiathèque_Online.service
{
    class RetardService
    {
        private RetardDAO dao;
        private AdministreService admService;
        private LivresService livresService;

        public RetardService()
        {
            this.dao = new RetardDAO();
            this.admService = new AdministreService();
            this.livresService = new LivresService();
        }
        public List<RetardDTO> FindAll()
        {
            List<Retard> stream = dao.FindAll();
            List<RetardDTO> retardDTOs = new List<RetardDTO>();
            foreach (Retard retard in stream)
            {
                retardDTOs.Add(ToDTO(retard));
            }
            return retardDTOs;
        }
        public RetardDTO FindById(long id)
        {
            Retard retard = dao.FindById(id);
            if (retard != null)
            {
                return ToDTO(retard);
            }
            else
            {
                return null;
            }
        }

        private Retard ToEntity(RetardDTO dto)
        {
            AdministreDTO administreDTO = this.admService.FindByName(dto.GetNomAdm());
            LivresDTO livresDTO = this.livresService.GetBookById(dto.GetIsbn());
            return new Retard(administreDTO.Get_id_Administre() , dto.GetIsbn() , dto.GetIdRetard());
        }
        private RetardDTO ToDTO(Retard retard)
        {
            AdministreDTO administreDTO = this.admService.FindById(retard.GetIdAdm());
            LivresDTO livresDTO = this.livresService.GetBookById(retard.GetIsbn());
            RetardDTO retardDTO = new RetardDTO();
            retardDTO.SetNomAdm(administreDTO.Get_nom_Administre());
            retardDTO.SetIdRetard(retard.GetIdRetard());
            retardDTO.SetIsbn(livresDTO.GetIsbn());
            retardDTO.SetIdAdm(retard.GetIdAdm());

            return retardDTO;
        }
    }
}
