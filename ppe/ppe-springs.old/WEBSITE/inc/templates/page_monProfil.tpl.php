<!--
* judy 19/04/2022 
* judy modif 10/05/2022 
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
            <h1>MES INFORMATIONS</h1>
            <?php
            $secure = new SecureScript();
            $service = new Service();
            $user = $service->getUser($_SESSION['logID'], $_SESSION['password']);
            echo '
    <div class="d-flex flex-column">
        <div class="d-flex">
        <h3 class="m-2">' . $user->getNom() . '</h3><h3 class="m-2">' . $user->getPrenom() . '</h3>

        </div>
        <p class="m-2">' . $user->getAdresse() . '</p>
        <div class="d-flex">
        <p class="m-2">' . $user->getCP() . '</p><p class="m-2">' . $user->getVille() . '</p>
        </div>
        <p class="m-2">' . $user->getPhone() . '</p>
    </div>';


            ?>
            <a class="btn btn-primary m-3" href="index.php?page=modifierProfil" role="button">Modifier mon compte</a>

        </div>
    </div>
</div>
</div>