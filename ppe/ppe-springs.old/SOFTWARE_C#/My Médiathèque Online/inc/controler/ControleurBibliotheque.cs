using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.service;

namespace My_Médiathèque_Online
{
    class ControleurBibliotheque
    {

        private BibliothequeService biblioService = new();


        public List<BibliothequeDTO> GetAllbibliotheques()
        {
            return biblioService.FindAll();
        }


    }
}
