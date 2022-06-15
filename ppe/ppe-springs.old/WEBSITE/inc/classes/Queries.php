<?php

/**
 * Judicaël 13/04/2022
 * judy 19/04/2022 ajout meth getAllEmprunt
 * Paul 04/05/2022 requete emprunt livre insert et into et tentative de select du idAdministre seuelement
 * Paul 08/05/2022 requete pour rendre le livre
 */
class Queries
{
    
    function __construct()
    {
    }

    function getUserLog($id, $pw)
    {
        return "SELECT _log_id_Administre, _log_password_Administre FROM Administre WHERE _log_id_Administre = '" . $id . "' AND _log_password_Administre = '" . $pw . "';";
    }
    function getUser($id, $pw)
    {
        return "SELECT * FROM Administre WHERE _log_id_Administre = '" . $id . "' AND _log_password_Administre = '" . $pw . "';";
    }
    function getAllBooks()
    {
        return "SELECT * FROM `livre` WHERE _isbn_livre IN (SELECT _isbn_livre FROM partage WHERE  _statut_livre = 'disponible') ;";
    }
    function insertBooks($book)
    {
        return "INSERT INTO `livre`(`_isbn_livre`, `_nom_livre`, `_date_edition_livre`, `_nom_editeur_livre`, `_nom_collection_livre`, `_id_bibliotheque`, `_resume_livre`, `_est_emprunte`) VALUES ('".$book->getIsbn()."','".$book->getTitle()."','".$book->getDate()."','".$book->getEditeur()."','".$book->getCollection()."',1,\"".$book->getResume()."\",0);";
    }
    function insertEcrit($book,$auteur)
    {
        return "INSERT INTO `ecrit`(`_isbn_livre`, `_id_autheur`) VALUES ('".$book->getIsbn()."','".$auteur->getId()."');";
    }
    function insertPartage($isbn)
    {
        return "INSERT INTO `partage`(`_isbn_livre`, `_id_Administre`, `_statut_livre`) VALUES ('.$isbn.','" . $_SESSION['ID'] . "','en Attente');";
    }
    function findByIsbn($isbn)
    {
        return "SELECT * FROM livre WHERE _isbn_livre = ".$isbn.";";
    }
    function getAllEmprunt()
    {
        return "SELECT * FROM `livre` WHERE _isbn_livre IN (SELECT _isbn_livre FROM emprunte WHERE emprunte._id_Administre = " . $_SESSION['ID'] . ") ;";
    }
    function getAllPartage()
    {
        return "SELECT * FROM `livre` WHERE _isbn_livre IN (SELECT _isbn_livre FROM partage WHERE _id_Administre = " . $_SESSION['ID'] . ") ;";
    }
    function getPartage($book)
    {
        return "SELECT * FROM `partage` WHERE _isbn_livre = '" . $book->getIsbn(). "' AND _id_Administre = " . $_SESSION['ID'] . " ;";
    }
    function getVille()
    {
        return "SELECT * FROM `ville` WHERE _id_ville IN (SELECT _id_ville FROM Administre WHERE _id_Administre = " . $_SESSION['ID'] . ") ;";
    }

    function getLastBook()
    {
        return "SELECT * FROM livre WHERE _isbn_livre = (SELECT _isbn_livre FROM partage WHERE _id_partage = (SELECT MAX(_id_partage) FROM partage));";
    }

    //PAUL - TEST
    function getInsertLoanBook($idAdministre, $isbn, $dateEmprunt)
    {   //il faut concatener VALUES ("'$idAdministe'.',')
        return "INSERT INTO emprunte (_id_administre,_isbn_livre,_date_emprunt) VALUES ('$idAdministre','$isbn','$dateEmprunt')";
    }

    function getDeleteLoanBook($isbn)
    {   //il faut concatener VALUES ("'$idAdministe'.',')
        return "DELETE FROM emprunte WHERE _isbn_livre= $isbn";
    }

    //PAUL - TEST
    function getUpdateLoanStatusBook($isbn)
    {
        return "UPDATE livre SET _est_emprunte = 1 WHERE _isbn_livre = '$isbn'";
    }

    function getUpdateLoanStatusBookOpen($isbn)
    {
        return "UPDATE livre SET _est_emprunte = 0 WHERE _isbn_livre = '$isbn'";
    }

    //PAUL - TEST
    function getIdAdministre($logID)
    {
        return "SELECT _id_administre FROM Administre WHERE _log_id_administre = '$logID'";
    }

    function getDonneeUser($nom, $prenom, $mail)
    {
        return "SELECT * FROM Administre WHERE _nom_Administre = '" . $nom . "' AND _prenom_Administre = '" . $prenom . "' AND _mail_Administre = '" . $mail . "';";
    }
    function getEmpruntDateByIsbn($isbn)
    {
        return "SELECT _date_emprunt FROM `emprunte` WHERE _isbn_livre = '" . $isbn . "';";
    }
    function setRetardEnCours()
    {
        return "INSERT INTO `Retard_en_cours`(`_regularise_Retard_en_cours`) VALUES (0);";
    }
    function setEnRetard($isbn, $idRetard)
    {
        return "INSERT INTO `en_retard`(`_id_Administre`, `_isbn_livre`, `_id_Retard_en_cours`) VALUES (" . $_SESSION['ID'] . ",'" . $isbn . "','" . $idRetard . "');";
    }
    function getRetard($isbn)
    {
        return "SELECT * FROM `en_retard` WHERE `_id_Administre` = '" . $_SESSION['ID'] . "' AND `_isbn_livre` = '" . $isbn . "';";
    }
    function setAuteur($nom , $prenom)
    {
        return "INSERT INTO `auteur`( `_nom_autheur`, `_prenom_autheur`) VALUES ('".$nom."','".$prenom."');";
    }
    function getAuthorByName($nom)
    {
        return "SELECT * FROM `auteur` WHERE _nom_autheur = '".$nom."' OR _prenom_autheur = '".$nom."';";
    }
    function getAllAuthor()
    {
        return "SELECT * FROM `auteur`;";
    }
}
