using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.dao;

namespace My_Médiathèque_Online.service
{
    class VilleService
    {

        private VilleDAO dao;

        public VilleService()
        {
            this.dao = new VilleDAO();
        }
        public List<VilleDTO> FindAll()
        {
            List<Ville> stream = dao.FindAll();
            List<VilleDTO> villeDTOs = new List<VilleDTO>();
            foreach (Ville ville in stream)
            {
                villeDTOs.Add(ToDTO(ville));
            }
            return villeDTOs;
        }
        public VilleDTO FindById(long id)
        {
            Ville ville = dao.FindById(id);
            if (ville != null)
            {
                return ToDTO(ville);
            }
            else
            {
                return null;
            }


        }


        private Ville ToEntity(VilleDTO dto)
        {
            return new Ville(dto.Get_id(), dto.Get_Name(), dto.Get_CP());
        }
        private static VilleDTO ToDTO(Ville ville)
        {
            VilleDTO villeDTO = new VilleDTO();
            villeDTO.Set_id(ville.Get_id());
            villeDTO.Set_Name(ville.Get_Name());
            villeDTO.Set_cp(ville.Get_CP());

            return villeDTO;
        }


    }
}
