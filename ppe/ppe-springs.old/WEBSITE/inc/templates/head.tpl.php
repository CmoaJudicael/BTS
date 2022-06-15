<!--
**
** Judicaël 12/04/2022 modification du head pour ne charger uniquement la page css de la page en cours
** 
-->

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>My Médiathèque Online</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    
    
    <?php
    if (!isset($_GET['page']))
    {
        $currentPage = 'accueil';
    }
    else
    {
        $currentPage = $_GET['page'];
    }
    if (file_exists('pub/css/'.$currentPage.'.css') )
    {
        echo '<link rel="stylesheet" href="pub/css/'.$currentPage.'.css">';
    }   
    ?>
    <link rel="stylesheet" href="pub/css/style.css">
    <link rel="icon" href="pub/img/mmo.ico">
</head>