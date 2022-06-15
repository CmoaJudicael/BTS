using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.service;
using My_Médiathèque_Online.secure;


namespace My_Médiathèque_Online.controler
{
    class ControleurVille
    {
        private VilleService villeService;
        private SecureScrypt secure;

        public ControleurVille()
        {
            this.villeService = new();
            this.secure = new();
        }

        public List<VilleDTO> GetAllVille()
        {
            return villeService.FindAll();
        }
        public VilleDTO GetVilleById(long id)
        {
            return villeService.FindById(id);
        }

    }
}
