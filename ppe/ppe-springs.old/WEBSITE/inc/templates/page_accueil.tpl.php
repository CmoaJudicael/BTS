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
    <div class="container-main d-flex">
        <div class="main-aside pb-3">
            <img src="pub/img/DreamCatcherSilver.png">
            <img class="circle" src="pub/img/circle.png">
          

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
    <div class="conteiner-main">
        <?php // Vérifie si on est connecté

        if (isset($_SESSION['isLog'])) {
            if ($_SESSION['isLog']) {
                $service = new Service();
                $user = $service->getUser($_SESSION['logID'], $_SESSION['password']);
        ?>
                <div class="d-flex flex-column p-5 m-2">
                    <div class="d-flex justify-content-between">
                        <h3> Bonjour, <?php echo $user->getPrenom(); ?></h3>
                        <h3> Nous sommes le <?php echo date("Y-m-d H:i:s"); ?></h3>
                    </div>

                    <h3 class="align-self-center">Nous vous proposons le dernier livre qui à été partager</h3>
                    <?php
                    $lastBookInsert = $service->getLastBook();
                    echo

                    '<article class="livre d-flex flex-column border border-2 rounded border-info p-3 m-2">
                
                <div class="d-flex justify-content-around ">
                <h3>' . $lastBookInsert->getTitle() . '</h3><p>ISBN : <span id="isbn-book">' . $lastBookInsert->getIsbn() . '</span></p>
                </div>
                <div class="d-flex justify-content-around ">
                <p>' . $lastBookInsert->getEditeur() . '</p><p>' . $lastBookInsert->getCollection() . '</p><p>' . $lastBookInsert->getDate() . '</p>
                </div>
                <div class="d-flex justify-content-end">
    <form action="index.php?page=voirLivre&isbn=' . $lastBookInsert->getIsbn() . '" method="POST" class="mx-2" >
        <button type="submit" class="btn btn-primary">VOIR</button>
    </form>
    </div>
            </article>';
                    ?>

                </div>

            <?php
            }
        } else {
            ?>
            <div class="flex_main_center">
                <div class="main_center">

                    <h2> Le concept </h2>
                    <div class="img_main1">
                        <img src="pub/img/concept.png">
                    </div>
                    <div class="div_concept">
                        <p> La médiathèque dispose d'un service de prêt et de réservation de livres, et accueille également la population de Pouzy-Mésangy faire don de livres pour faire grandir notre médiathèque.
                            Si vous êtes un résident de Pouzy-Mésangy N'attendez plus et rejoignez notre médiathèque.
                            Rapprochez-vous de la marie et faites partie de notre médiathèque Lorem ipsum dolor sit amet consectetur adipisicing elit. At expedita ab voluptatem illo minus quis totam minima velit eius voluptatum, aspernatur et eligendi nostrum fuga eveniet provident aliquid hic ducimus!</p>
                    </div>

                </div>

                <h3>Horaires et emplacements</h3>

                <p>Nous sommes ouvert de 9h à 18h tous les mardi , jeudi et un vendredi toutes les 2 semaines <br>
                    au 2 rue Jean Moulin 65969
                </p>

                <img class="img_main" src="pub/img/mapa.png">
            </div>
    </div>
<?php

        }
?>
</div>
</div>

