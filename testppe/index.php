<!DOCTYPE html>
<html lang="en">
<?php
include __DIR__.'/inc/templates/head.php';
?>
<body>
    <?php
        if (!isset($_GET['page']))
        {
            $currentPage = 'accueil';
        }
        else
        {
            $currentPage = $_GET['page'];
        }
        if (file_exists(__DIR__.'/inc/templates/page_'.$currentPage.'.php') ) 
        {
            include __DIR__.'/inc/templates/page_'.$currentPage.'.php';
        }
        else
        {
            include __DIR__.'/inc/templates/page_404.php';
        }
        
    ?>

    



</body>
</html>