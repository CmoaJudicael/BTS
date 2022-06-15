<?php

/**
 * 
 * Judicael 15/04/2022
 * Judicael 19/04/2022 ajout d'une redirection
 * 
 */
$erreurConnection = false;// initialise la variable
if(isset($_POST['logID']) && isset($_POST['password']))//check si POST possede des donnée
{
    $id = htmlspecialchars($_POST['logID']);//sanatize field
    $pw = hash('sha256',$_POST['password'], false);// hash pw
    $service = new Service();   //instancie un objet service
    $resLog = $service->getUserLog($id, $pw);//récupère les info de la bdd
    
    if($id == $resLog['_log_id_Administre'] && $pw == $resLog['_log_password_Administre'])//check les log
        {
            $_SESSION['isLog']= true;//initialise islog à true
            $user = $service->getUser($id, $pw);//récupère les données de l'utilisateurs
            $_SESSION['ID'] = $user->getId();
            $_SESSION['logID'] = $user->getLogId();
            $_SESSION['password'] = $user->getLogPw();
            $list = $service->getAllEmprunt();
            foreach($list as $book)
            {
                if($book->getDateEmprunt()->aRetourner())
                {
                    
                }
            }
            header('Location: index.php');
        }
        else
        {
            $erreurConnection = true;//affichez message d'erreur
            
        }

}

?>