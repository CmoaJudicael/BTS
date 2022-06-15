
    <?php
    
    ?>
    <div id="main" class="d-flex justify-content-center">
        <img id="imd-login-1" src="https://cdn.pixabay.com/photo/2015/07/31/11/45/library-869061_960_720.jpg" alt="Escalier de livre" style="width: 60%;">
        <form action="/WEBSITE/inc/datas/Verification.php" method="POST" class="d-flex flex-column" id="loginForm">
            <h2 class="fw-bold">LOGIN</h2>
            <div class="mb-3">
                <label for="id">IDENTIFIANT</label>
                <input type="text" placeholder="Votre identifiant" class="form-control">
            </div>
            <div class="mb-3">
                <label for="pass">MOT DE PASSE (8 characters minimum):</label>
                <input type="password" placeholder="Votre mot de passe" class="form-control" id="pass" name="password" minlength="8" required>
            </div>

            <div class="col-12">
                <button class="btn button" type="submit">CONNECTION</button>
            </div>

            <div class="col-12">
                <a class="btn button" href="index.php?page=MDO">MOT DE PASSE OUBLIE</a>
            </div>
            <div class="col-12">
                <a class="btn button" href="index.php?page=newAccount">CREATION DE COMPTE</a>
            </div>
        </form>
        <img src="pub/img/library.png" alt="bibliothèque" style="width: 10%;">
    </div>
