<?php

/**
 * 
 * Judicael 18/04/2022
 * 
 * 
 */
if(isset($_POST['isDeco']))
{
    if($_POST['isDeco'] == 'yep')
    {
        session_destroy();
        unset($_POST['isDeco']);
        header('Location: index.php');
    }
}
?>