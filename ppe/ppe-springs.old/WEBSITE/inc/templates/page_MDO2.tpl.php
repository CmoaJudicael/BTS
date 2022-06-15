<!-- 
    Paul 09/05/2022 page MDO2
-->

<body>
    <?php

    ?>

    <div class="main">
        <div class="container-main">
            <div class="main-aside">
                <img src="pub/img/DreamCatcherSilver.png">
                <img class="circle" src="pub/img/circle.png">
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

            <br>
            <div class="conteiner-main m-3 p-2">
                <br><br><br><br><br><br>
                <form action="index.php?page=MDO3" method="POST" class="d-flex flex-column" id="loginForm">
                    <h2 class="fw-bold h2 mb-2">Code de vérification</h2>
                    <div class="mb-3">
                        <label for="id">Code</label>
                        <input type="text" placeholder="Votre code" class="form-control">
                    </div>
                    <div class="col-12">
                        <button class="btn button" type="submit">Vérifier code</button>
                    </div>
                    <div class="col-12">
                        <a href="index.php?page=accueil" class="btn button" type="submit">Retour</a>
                    </div>
                </form>
            </div>
        </div>
</body>