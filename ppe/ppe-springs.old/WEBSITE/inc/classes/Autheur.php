<?php
/**
 * 
 * Judicael 09/05/2022 création du fichier, des attributs et des getter
 * 
 * 
 */
class Autheur
{
    private $id;
    private $nom;
    private $prenom;

    function __construct($author)
    {
        $this->id = $author['_id_autheur'];
        $this->nom = $author['_nom_autheur'];
        $this->prenom = $author['_prenom_autheur'];
    }
    public function getNom()
    {
        return $this->nom;
    }
    public function getPrenom()
    {
        return $this->prenom;
    }
    public function getId()
    {
        return $this->id;
    }

}