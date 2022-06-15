<?php
/**
 * 
 * Paul 
 * 
 */
class ConnexionDB
{
    //attributs
    private $pdo;

    //constructeur
    function __construct()
    {
        $db = "springs_bdd_ppe";
        $dbhost = "mysql-springs.alwaysdata.net";
        $dbport = 3306;
        $dbcharset = "utf8";
        $dbuser = "springs_";
        $dbpasswd = "gcNpIKsZsm1LtoU12Sye";

        //essai de connexion vers la BDD
        try {
            $connexionDB = new PDO('mysql:host=' . $dbhost . ';port=' . $dbport . ';dbname=' . $db .';charset=' . $dbcharset . '', $dbuser, $dbpasswd);

          //sinon affichage d'erreur
        } catch (PDOException $erreur) {
            echo "Erreur car " . $erreur->getMessage();
        }
        $this->pdo = $connexionDB;
    }

    //accesseur pdo
    public function getPDO()
    {
        return $this->pdo;
    }
}
