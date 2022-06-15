

<div class="main">
    <div class="search d-flex justify-content-center align-items-center">
        <?php // Vérifie si on est connecté
        if(isset($_SESSION['isLog']))
        {
            if($_SESSION['isLog'])
            {
                
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
        }?>
    </div>

    <div class="container-main">
        <div class="main-aside">
            <img src="pub/img/DreamCatcherSilver.png">
            <img class="circle" src="pub/img/circle.png">
            <ul class="lista">
                <li>
                    <a class="btn btn-primary m-3" href="index.php?page=voirProfil" role="button">Mon Compte</a>
                </li>
                <li>
                    <a class="btn btn-primary m-3" href="index.php?page=policyPrivacy" role="button">Information</a>
                </li>
                <li>
                    <a class="btn btn-primary m-3" href="./test.php" role="button">Test</a>
                </li>
            </ul>

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
        


        </div>
    </div>
</div>
</div>
