<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    var_dump($_GET);
    $test = htmlspecialchars($_GET['age']);
    $test2 = filter_var($_GET['age'], FILTER_SANITIZE_STRING);
    $test3 = filter_var($_GET['email'], FILTER_SANITIZE_EMAIL);

    if ((!empty ($_GET['name'])) && (!empty ($_GET['age'])))
    {
        echo $_GET['name'].' comment ça va?, tu as '.$test2.' ans';
    }
    ?>
    <a href="monautreformulaire.php">autre formulaire</a>

    <form action="traitement.php" method="get" class="form-example">
        <div class="form-example">
            <label for="name">Renseignez votre nom : </label>
            <input type="text" name="name" id="name" required>
        </div>
        <div class="form-exemple">
            <label for="age">Renseignez votre age : </label>
            <input type="number" min="0" name="age" id="age">
        </div>
        <div class="form-example">
            <label for="email">Enter your email: </label>
            <input type="email" name="email" id="email" required>
        </div>
        <div class="form-example">
            <input type="submit" value="Enregister">
        </div>
    </form>
    <!--
        Pour qu'un formulaire fonctionne, je veux :
            1) que mon utilisateur puisse remplir des données
            2) que mon utilisateur puisse envoyer ses données
            3) que moi en tant qu'éditeur de site internet je puisse récupérer ses données
        Un formulaire peut être constitué de différentes types de données, exemple :
            du text, une liste de choix, des cases à cocher, puce radio, chiffres, etc...
        
        Dans un 1 temps pour faire fonctionner un formulaire simple, voici les éléments essentiels dont j'ai besoin :
            1) je crée un élément html <form>
            2) je crée au minimum 2 inputs, le premier qui correspond à une donnée que je veux récupérer et le deuxième
            3) je définis la méthode utilié pour envoyer les données via l'attribut method de mon élément form et je précise vers quelle adresse je veux envoyer ces données via l'attribut action de mon élément form.


            si je veux transmettre des données, mes inputs doivent contenir un attribut name qui va associer un nom (une clé) à la valeur (c'est à dire la donnée entrée par l'utilisateur)

            pur récupérer ma donnée, je peux utiliser les super-globales PHP

            exemplx
            Avec la methode get, les données transmises par l'utilisateur transite en clair vers le serveur via l'url selon le modèle suivant

            les paramètres de l'URL sont reçus par le serveur web, qui, avec php installé dessus, via permetttre de peupler 
            
            clair via l'URL donc !! on ne fait pas transiter de données sensibles, ex: données à caractères personnelles et données de connexion


            ATTENTION A LA SECURISATION DE VOTRE SITE
            1) Les dispositif de sécurisatipon en FRONT ne sont jamais JAMAIS JAMAIS suffisant

            2) il faut toujours TOUJOURS contrôler et netoyer les données qui nous sont transmises par l'utilisateur (pour mémo NEVER TRUST THE USER INPUT) et donc scuriser votre site en BACK.
            Une sécurisation seulement en front = site NON sécurisé

            Pour cela , php met à disposition une série de filtres de nettoyage
            nous avons aussi la fonction  htmlspecialchars

            donc dès lors que je reçois et ensuite j'utilise une données de l'utilisateurs, je reçois 
     -->

</body>
</html>