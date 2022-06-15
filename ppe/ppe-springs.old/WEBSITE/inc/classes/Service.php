<?php
/*
**Judicael 15/04/2022 création de la classe de service et des methodes
* judy 19/04/2022 ajout meth getAllEmprunt, getAllPartage, ville
* Paul 06/05/2022 getThisIdAdministre pour l'emprunt / Pas encore fini
* Paul 07/05/2022 functionInsertEmprunt / Fonctionneee !
* Paul 08/05/2022 fonction rendreLivre 
*/

class service
{
    private $pdo;
    private $database;
    private $sqlQuerie;

    function __construct()
    {
        $this->database = new ConnexionDB();
        $this->sqlQuerie = new Queries();
    }
    private function requete($sql)
    {
        $this->pdo = $this->database->getPDO();
        if (!($stmt = $this->pdo->prepare($sql))) //preparation de la requête
        {
            echo "Échec de la préparation : (" . $this->pdo->errorCode() . ") " . $this->pdo->error;
        }
        if (!$stmt->execute()) //envoie de la requête
        {
            echo "Échec lors de l'exécution : (" . $stmt->errorCode() . ") ";
        }
        return $stmt;
    }
    public function getAllBook()//methode pour appeler tous les livres
    {
        $resutatReq = $this->requete($this->sqlQuerie->getAllBooks())->fetchAll(PDO::FETCH_ASSOC);
        $bookList = array();
        foreach($resutatReq as $books)
        {
            $dateEmprunt = null;
            $book = new Books($books,$dateEmprunt);
            array_push($bookList, $book);
        }
        return $bookList;
    }
    public function getBookByIsbn($isbn)//methode pour appeler un livre par isbn
    {
        $resutatReq = $this->requete($this->sqlQuerie->findByIsbn($isbn))->fetchAll(PDO::FETCH_ASSOC);
        
        if(isset($resutatReq[0]))
        {
            $dateEmprunt = null;
            $book = new Books($resutatReq[0],$dateEmprunt);
            return $book;
        }
        else
        {
            return null;
        }
        
    }
    
    public function getUserLog($id, $pw)//recup log user
    {
        $resutatReq = $this->requete($this->sqlQuerie->getUserLog($id, $pw))->fetchAll(PDO::FETCH_ASSOC);
        if($resutatReq != null)
        {
            return $resutatReq[0];
        }
        
    }
    public function getUser($id, $pw)//recupere info user
    {
        $resutatReq = $this->requete($this->sqlQuerie->getUser($id, $pw))->fetchAll(PDO::FETCH_ASSOC);
        $ville = $this->getVille();
        $user = new User($resutatReq[0], $ville[0]);
        if($user->getLogId() == $id && $user->getLogPw() == $pw)
        {
            return $user;
        }

    }
    public function getAllEmprunt()//methode pour appeler tous les livres empruntés
    {
        $resutatReq = $this->requete($this->sqlQuerie->getAllEmprunt())->fetchAll(PDO::FETCH_ASSOC);
        $bookList = array();
        foreach($resutatReq as $books)
        {
            $dateEmprunt = $this->getDateEmpruntByIsbn($books['_isbn_livre']);
            $book = new Books($books,$dateEmprunt);
            array_push($bookList, $book);
        }
        return $bookList;
    }
    public function getAllPartage()//methode pour appeler tous les livres partagés
    {

        $resutatReq = $this->requete($this->sqlQuerie->getAllPartage())->fetchAll(PDO::FETCH_ASSOC);
        $bookList = array();
        foreach($resutatReq as $books)
        {
            $dateEmprunt = null;
            $book = new Books($books,$dateEmprunt);
            array_push($bookList, $book);
        }
        return $bookList;
    }
    public function getPartage($book)//methode pour appeler tous les livres partagés
    {

        $resutatReq = $this->requete($this->sqlQuerie->getPartage($book))->fetchAll(PDO::FETCH_ASSOC);
        
        if (!isset($resutatReq[0])) 
        {
            return null;
        }
        else
        {
            $dateEmprunt = null;
            return $book = new Books($resutatReq[0],$dateEmprunt);
        }
    }
    public function getVille()//récupère la ville de l'utilisateur connecté
    {
        $resutatReq = $this->requete($this->sqlQuerie->getVille())->fetchAll(PDO::FETCH_ASSOC);
        if(empty($resutatReq))
        {
            $resutatReq = ['1','pouzy'];
        }
        $ville = $resutatReq;
        return $ville;
    }
    public function getLastBook()// récupère le dernier livre partager
    {
        $resutatReq = $this->requete($this->sqlQuerie->getLastBook())->fetchAll(PDO::FETCH_ASSOC);
        $dateEmprunt = null;
        $book = new Books($resutatReq[0],$dateEmprunt);
        return $book;
        
    }

    //Insert l'emprunt dans la table emprunt et update le status emprunt dans la table livre
    public function insertEmprunt($id,$isbn,$date){
        //Insertion emprunt
        $resutatReq = $this->requete($this->sqlQuerie->getInsertLoanBook($id,$isbn,$date))->fetchAll(PDO::FETCH_ASSOC);
        //Update Status
        $resutatReq = $this->requete($this->sqlQuerie->getUpdateLoanStatusBook($isbn))->fetchAll(PDO::FETCH_ASSOC);
    }

    //Supprime l'emprunt et update le status du livre
    public function rendreEmprunt($isbn){
        //Insertion emprunt
        $resutatReq = $this->requete($this->sqlQuerie->getDeleteLoanBook($isbn))->fetchAll(PDO::FETCH_ASSOC);
        //Update Status
        $resutatReq = $this->requete($this->sqlQuerie->getUpdateLoanStatusBookOpen($isbn))->fetchAll(PDO::FETCH_ASSOC);
    }

    public function getDonneeUser($nom, $prenom, $mail)//recupere info user
    {
        $resutatReq = $this->requete($this->sqlQuerie->getDonneeUser($nom, $prenom, $mail))->fetchAll(PDO::FETCH_ASSOC);
        var_dump($resutatReq);
        //$ville = $this->getVille();//a modifier
        //$user = new User($resutatReq[0], $ville);
        //return $user;
    }
    public function getDateEmpruntByIsbn($isbn)//methode pour récupérer la date d'emprunt
    {
        $resutatReq = $this->requete($this->sqlQuerie->getEmpruntDateByIsbn($isbn))->fetchAll(PDO::FETCH_ASSOC);
        return new DateEmprunt($resutatReq[0]['_date_emprunt']);
       
    }
    public function insertRetard($isbn) //créer un nouveau retard 
    {
        $resutatReq = $this->requete($this->sqlQuerie->getRetard($isbn))->fetchAll(PDO::FETCH_ASSOC);
        if(!isset($resutatReq[0]))
        {
            $resutatReq = $this->requete($this->sqlQuerie->setRetardEnCours());
            $idRetard = $this->requete("SELECT MAX(_id_Retard_en_cours) FROM `Retard_en_cours`;")->fetchAll(PDO::FETCH_ASSOC);
            $resutatReq = $this->requete($this->sqlQuerie->setEnRetard($isbn, $idRetard[0]['MAX(_id_Retard_en_cours)']));
        }

    }
    public function insertAutheur($nom, $prenom)//créer un nouvel auteur
    {
        $resutatReq = $this->requete($this->sqlQuerie->setAuteur(strtoupper($nom) , strtoupper($prenom)));
    }
    public function getAuteur($nom)
    {
        $resutatReq = $this->requete($this->sqlQuerie->getAuthorByName($nom))->fetchAll(PDO::FETCH_ASSOC);
        
        if (!isset($resutatReq[0]))
        {
            return null;
        }
        else
        {
            return $autheur = new Autheur($resutatReq[0]);
        }
    }
    public function getAllAuteur()
    {
        $resutatReq = $this->requete($this->sqlQuerie->getAllAuthor())->fetchAll(PDO::FETCH_ASSOC);
        $authorList = array();
        foreach ($resutatReq as $autheurs)
        {
            $autheur = new Autheur($autheurs);
            array_push($authorList,$autheur);
        }
        return $authorList;
    }
    public function insertBook($book, $auteur)
    {
        $resutatReq = $this->requete($this->sqlQuerie->insertBooks($book));
        $resutatReq2 = $this->requete($this->sqlQuerie->insertEcrit($book, $auteur));
    }
    public function insertPartage($book)
    {
        $resutatReq = $this->requete($this->sqlQuerie->insertPartage($book->getIsbn()));
    }
    
}
