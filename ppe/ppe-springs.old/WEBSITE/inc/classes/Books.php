<?php
/**
 * 
 * Judicael 15/04/2022 création du fichier, des attributs et des getter
 * 
 * 
 */
class Books
{
    private $title;
    private $isbn;
    private $date;
    private $editeur;
    private $collection;
    private $resume;
    private $dateEmprunt;
    
    function __construct($book, $dateEmprunt)
    {
        
        $this->title = $book['_nom_livre'];
        $this->isbn = $book['_isbn_livre'];
        $this->date = $book['_date_edition_livre'];
        $this->editeur = $book['_nom_editeur_livre'];
        $this->collection = $book['_nom_collection_livre'];
        $this->resume = $book['_resume_livre'];
        $this->dateEmprunt = $dateEmprunt;
        
    }
    public function getDateEmprunt()
    {
        return $this->dateEmprunt;
    }
    public function getTitle()
    {
        return $this->title;
    }
    public function getIsbn()
    {
        return $this->isbn;
    }
    public function getDate()
    {
        return $this->date;
    }
    public function getEditeur()
    {
        return $this->editeur;
    }
    public function getCollection()
    {
        return $this->collection;
    }
    public function getResume()
    {
        return $this->resume;
    }
}

?>