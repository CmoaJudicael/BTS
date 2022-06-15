using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.service;

namespace My_Médiathèque_Online.controler
{
    class ControleurRetard
    {
        private RetardService retardService;

        public ControleurRetard()
        {
            this.retardService = new();
        }

        public List<RetardDTO> GetAllRetards()
        {
            List<RetardDTO> retardDTOs = retardService.FindAll();

            return retardDTOs;
        }
        public RetardDTO GetRetardById(long id)
        {
            return retardService.FindById(id);
        }

    }
}
