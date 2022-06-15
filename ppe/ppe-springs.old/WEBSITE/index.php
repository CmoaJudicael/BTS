<!--
*
* Judicaël 13/04/2022 modiffication session_start + ajout code de Vérification log de connection
*
-->
<?php
    session_start();
    include "./inc/classes/SecureScript.php";
    include "./inc/classes/Deconnection.php";
    include "./inc/classes/DateEmprunt.php";
    include "./inc/classes/Autheur.php";
    include "./inc/classes/User.php";
    include "./inc/classes/Books.php";
    include "./inc/classes/Queries.php";
    include "./inc/classes/ConnexionDB.php";
    include "./inc/classes/Service.php";
    include __DIR__.'/inc/classes/VerificationLogin.php';
    

?>

<!DOCTYPE html>
<html lang="fr">
<?php
include __DIR__ .'/inc/templates/head.tpl.php';
?>
<body>
    <?php
    
    include __DIR__ .'/inc/templates/header.tpl.php';
    

    if (!isset($_GET['page']))
    {
        $currentPage = 'accueil';
    }
    else
    {
        $currentPage = $_GET['page'];
    }
    if (file_exists(__DIR__.'/inc/templates/page_'.$currentPage.'.tpl.php') )
    {
        include __DIR__.'/inc/templates/page_'.$currentPage.'.tpl.php';
    }
    else
    {
        include __DIR__.'/inc/templates/page_404.tpl.php';
    }

        include __DIR__ . '/inc/templates/footer.tpl.php';
    ?>
    
</body>

</html>