
    <?php

    ?>


        <div id="main" class="d-flex justify-content-center">
            <img id="imd-login-1" src="https://cdn.pixabay.com/photo/2015/07/31/11/45/library-869061_960_720.jpg" alt="Escalier de livre" style="width: 60%;">
            <form action="/WEBSITE/inc/datas/Verification.php" method="POST" class="d-flex flex-column" id="loginForm">
                <h2 class="fw-bold">CREER UN COMPTE</h2>
                <div class="mb-3">
                    <label for="id">MOT DE PASSE</label>
                    <input type="text" placeholder="Votre identifiant" class="form-control">
                </div>

                <div class="mb-3">
                    <label for="id">CONFIRMER MOT DE PASSE </label>
                    <input type="text" placeholder="Votre identifiant" class="form-control">
                </div>

                <div class="col-12">
                    <a class="btn button" href="index.php?page=newAccount">CREATION DE COMPTE</a>
                </div>
            </form>
            <img src="pub/img/library.png" alt="bibliothèque" style="width: 10%;">
        </div>
