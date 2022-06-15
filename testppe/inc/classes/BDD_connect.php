<?php
class BDD_connect
{
    function __construct()
    {
    }
    function _connect()
    {
        
    }
    function _test()
    {
        try
        {
            $conn= new PDO('mysql:host=mysql-springs.alwaysdata.net;dbname=springs_bdd_ppe', 'springs_User', 'N9f7maf1DXh2F3BnHrlw');
        }
        catch (Exception $e)
        {
            die('Erreur : ' . $e->getMessage());
        }
        $recipesStatement = $conn->prepare('SELECT * FROM Administre');
        $recipesStatement->execute();
        $users = $recipesStatement->fetchAll();
        // Test On affiche chaque user un à un
        foreach ($users as $user) 
        {
            echo '<p>'.$user['_nom_Administre'].'</p>';
            echo '<p>'.$user['_prenom_Administre'].'</p>';
            echo '<p>'.$user['_adresse_Administre'].'</p>';
            echo '<p>'.$user['_id_vile'].'</p>';
            echo '<p>'.$user['_mail_Administre'].'</p>';
            echo '<p>'.$user['_telephone_Administre'].'</p>';
            echo '<p>'.$user['_id_role'].'</p>';
        }
    }

}

?>