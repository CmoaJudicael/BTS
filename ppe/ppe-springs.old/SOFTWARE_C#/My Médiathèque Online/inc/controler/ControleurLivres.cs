using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.service;

namespace My_Médiathèque_Online
{
    class ControleurLivres
    {
        private LivresService livresService = new();


        public List<LivresDTO> GetAllBook()
        {
            return livresService.FindAll();
        }
    }
}
