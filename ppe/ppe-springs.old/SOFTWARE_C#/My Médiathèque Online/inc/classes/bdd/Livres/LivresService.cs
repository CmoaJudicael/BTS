using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.dao;// comme ça tu peut acceder a dao
/**
 *Alexandra Calonico 20/04/2022
 *Alexandra Calonico 21/04/2022
 */
namespace My_Médiathèque_Online.service
{
    class LivresService
    {
       private LivresDAO livresDAO; //creation d'atrribut DAO 
        
     //constructeur

        public LivresService()
        {
            livresDAO = new LivresDAO(); //instanciat, comme ça c'est possible de comuniquer entre LivresDAO avec LivresService 
        }

        public List<LivresDTO> FindAll() //creation de method FindAll 
        {
            List<Livres> listLivres = livresDAO.FindAll(); // le method recupere le list de livres que son dans le livres DAO.

            List<LivresDTO> listLivresDTO = new List<LivresDTO>();

            foreach (Livres livres in listLivres)//Pour chaque elemento Livre dans la liste livres
            {
                listLivresDTO.Add(ToDto(livres));// ToDto il va transformer livres en livresDTO et apres le Add il  va a ajouter le livre  a la listLivresDTO
            }
            return listLivresDTO; // il ma retourn la liste de livresDTO


        }


        private Livres ToEntity(LivresDTO livresDTO) //method ToEntity transforme Livres DTO a Livres
        {
            return new Livres(livresDTO.GetIsbn(), livresDTO.GetId(), livresDTO.GetEmprunte(), livresDTO.GetNomLivre(), livresDTO.GetEditeurLivre(), livresDTO.GetDateEdition(), livresDTO.GetNomCollection(), livresDTO.GetResumeLivre());
        }

        private LivresDTO ToDto(Livres livres) //method ToDto transforme Livres DTo a Livres 
        {
            System.Diagnostics.Debug.WriteLine(livres.ToString());
            LivresDTO livresDTO = new LivresDTO(); //on creer un objet DTO et nous avons assinge des valeurs de que nous avon dans livres dans livreDTO
            livresDTO.SetIsbn(livres.GetIsbn());
            livresDTO.SetId(livres.GetId());
            livresDTO.SetEmprunte(livres.GetEmprunte());
            livresDTO.SetNomLivre(livres.GetNomLivre());
            livresDTO.SetDateEdition(livres.GetDateEdition());
            livresDTO.SetEditeurLivre(livres.GetEditeurLivre());
            livresDTO.SetNomCollection(livres.GetNomCollection());
            livresDTO.SetResumeLivre(livres.GetResumeLivre());
            return livresDTO; // returne le objet LivresDTO
            
        }


        public LivresDTO GetBookById(long id) //creation de method GetBookById
        {
            Livres livres = livresDAO.GetBookById(id); // le method recupere le list de livres que son dans le livres DAO.

            System.Diagnostics.Debug.WriteLine(livres.ToString());
            return ToDto(livres);//le metod ToDto fait le changment de livres a livresDTO. Me retourn le livreDTO

        }





    }
}
