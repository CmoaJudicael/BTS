<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!--
    Ici nous utilisons notre formulaire la methode post. Comme on a pu le voir cela fonctionne de la même anière que la méthode get à 2 grosse différences
-->
    <?php
        var_dump($_POST);
        $test2= $_POST['email'];
        if ((!empty ($_POST['sexe'])) && (!empty ($_POST['email'])))
        {
            echo '<strong>Mon sexe est '.$_GET['name'].' et mon mail est '.$test2;
        }
    ?>
    <form action="traitement.php" method="post" class="form-example">
        <div class="form-example">
            <label for="sexe">Renseignez votre sexe : </label>
            <label for="Male">Male</label>
            <input type="radio" name="Male" id="Male" value='male'>
            <label for="Female">Female</label>
            <input type="radio" name="Female" id="Female" value='Female'>
            <label for="chose">je ne sais pas vraiment</label>
            <input type="radio" name="chose" value='Je sais pas'>
        </div>
        <div class="form-exemple">
            <label for="lieu">vous habitez : </label>
            <label for="ville">En ville </label>
            <input type="checkbox" min="0" name="ville" id="ville" value='ville'>
            <label for="campagne">A la campagne </label>
            <input type="checkbox" min="0" name="campagne" id="campagne" value='campagne'>
            <label for="parent">Chez mes parents </label>
            <input type="checkbox" min="0" name="parent" id="parent" value='parent'>
            <label for="colocation">En colocation </label>
            <input type="checkbox" min="0" name="colocation" id="colocation" value='colocation'>

        </div>        
        <div class="form-example">
            <label for="email">Enter your email: </label>
            <input type="email" name="email" id="email" required>
        </div>
        <div class="form-example">
            <label for="chien">quel est votre chien préféré : </label>
            <select name="chiens" id="chien">
                <option for="chiens" value="Affenpinscher">Affenpinscher</option>
                <option for="chiens" value="Airedale Terrier">Airedale Terrier</option>
                <option for="chiens" value="Akita Américain">Akita Américain</option>
                <option for="chiens" value="Beagle">Beagle</option>
                <option for="chiens" value="Berger Allemand">Berger Allemand</option>
                <option for="chiens" value="Labrador Retriever">Labrador Retriever</option>
                <option for="chiens" value="Lévrier Espagnol">Lévrier Espagnol</option>
            </select>
        </div>
        <div class="form-example">
            <input type="submit" value="Enregister">
        </div>
    </form>
</body>
</html>