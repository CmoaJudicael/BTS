<!--
* judy 19/04/2022 création de la page
* judy 10/05/2022 mise en place de la fonctionnalité
-->

<div class="main">
    <div class="search d-flex justify-content-center align-items-center">
        <?php // Vérifie si on est connecté
        if (isset($_SESSION['isLog'])) {
            if ($_SESSION['isLog']) {

        ?>
                <div class="d-flex justify-content-evenly align-items-center mb-3">
                    <div class="input-group mb-3 position-relative">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="inputGroup-sizing-default">Rechercher un livre</span>
                        </div>
                        <input type="text" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default">
                        <button type="button" class="btn btn-primary ml-3">Search</button>
                    </div>
                </div>
        <?php
            }
        } ?>
    </div>

    <div class="container-main">
        <div class="main-aside">
            <img src="pub/img/DreamCatcherSilver.png">
            <img class="circle" src="pub/img/circle.png">

            </ul>
            <br>
            <div class="redes">
                <img class="img-livres" src="pub/img/livres.png">

                <br>

                <p class="p-aside">Réseaux Sociaux</p>
                <br>
                <a href="https://www.facebook.com/profile.php?id=100079710199316"> <img class="reseaux-sociaux" src="pub/img/logofacebook.png"></a>
                <a href="https://twitter.com/AlexandraCalon4"><img class="reseaux-sociaux" src="pub/img/twitter.png"></a>
                <a href="https://www.instagram.com/mediathequepouzymesangy/"><img class="reseaux-sociaux" src="pub/img/Instagram.png"></a>
            </div>
        </div>
        <div class="conteiner-main m-3 p-2">
            <h1>Modification</h1>
            <?php
            $service = new Service();
            $user = $service->getUser($_SESSION['logID'], $_SESSION['password']);

            if (isset($_POST['nom']) && isset($_POST['prenom']) && isset($_POST['adresse']) && isset($_POST['cp']) && isset($_POST['ville']) && isset($_POST['phone']) && isset($_POST['mail'])) 
            {
                if ($_POST['nom'] != null && $_POST['prenom'] != null && $_POST['adresse'] != null && $_POST['cp'] != null && $_POST['ville'] != null && $_POST['phone'] != null && $_POST['mail'] != null) 
                {
                    $user->setNom($_POST['nom']);
                    $user->setPrenom($_POST['nom']);
                    $user->setAdresse($_POST['nom']);
                    $user->setCP($_POST['cp']);
                    $user->setPhone($_POST['phone']);
                    $user->setMail($_POST['mail']);

                    //$service->updateUser($user);

                    
                    $_POST['nom'] = null;
                    $_POST['nom'] = null;
                    $_POST['nom'] = null;
                    $_POST['cp'] = null;
                    $_POST['phone'] = null;
                    $_POST['mail'] = null;
                }
            }
            


             ?>

            <form action="" method="POST" class="d-flex flex-column" id="loginForm">
                <div class="mb-3">
                    <label for="nom">Nom</label>
                    <input type="text" placeholder="Votre nom" name="nom" class="form-control" value="<?php echo $user->getNom(); ?>">
                </div>
                <div class="mb-3">
                    <label for="prenom">Prenom</label>
                    <input type="text" placeholder="Votre prenom" name="prenom" class="form-control" value="<?php echo $user->getPrenom(); ?>">
                </div>
                <div class="mb-3">
                    <label for="adresse">Adresse</label>
                    <input type="text" placeholder="Votre adresse" name="adresse" class="form-control" value="<?php echo $user->getAdresse(); ?>">
                </div>

                <div class="mb-3">
                    <label for="cp">Code Postal</label>
                    <input type="number" placeholder="Votre code postal" name="cp" class="form-control" value="<?php echo $user->getCP(); ?>">
                </div>

                <div class="mb-3">
                    <label for="ville">Ville</label>
                    <input type="text" placeholder="Votre ville" name="ville" class="form-control" value="<?php echo $user->getVille(); ?>">
                </div>

                <div class="mb-3">
                    <label for="phone">Téléphone</label>
                    <input type="text" name="telephone" placeholder="Votre numéro de téléphone" name="phone" class="form-control" value="<?php echo $user->getPhone();?>">
                </div>
                <div class="mb-3">
                    <label for="mail">mail</label>
                    <input type="mail" name="mail" placeholder="Votre numéro de mail" name="mail" class="form-control" value="<?php echo $user->getMail(); ?>">
                </div>
                <div>
                    
                    <a class="btn btn-primary m-3" href="index.php?page=monProfil" role="button">RETOUR</a>
                    <input class="btn btn-primary m-3" type="submit" value="MODIFIER">
                </div>
            </form>
        </div>
    </div>
</div>
</div>