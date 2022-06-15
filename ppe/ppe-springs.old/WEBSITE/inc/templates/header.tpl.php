<!-- 
**
** Judicaël 12/04/2022 encapsulation du lien login dans une div et décalage de l'image
** 13/04/2022 création menuBurger
**
  -->
<header class="header d-flex justify-content-around align-items-center fixed-top w-100">
    <a href="index.php?page=accueil"><img class="header-img-1" src="pub/img/LogoMediatheque.png"></a>
    <p class="header-p">My Médiathèque Online <br>Réseau de Partage Groupé</p>
    <div >
        <div class="d-flex justify-content-end" ><img onclick="moveMenuBurger()" class="header-img-2" src="pub/img/identifiant.png"></div>
        
        <div id="menuBurger" class="">
          <div id="upmenu"></div>
          <div id="menuButton" class="d-flex flex-column align-items-center">
            
          <?php  
     if(isset($_SESSION['isLog']))
     {
    ?>

       <button class="btn-menu-burger" onclick="window.location.href='index.php?page=accueil'">
       <p>Accueil</p>
        </button>
        <button class="btn-menu-burger" onclick="window.location.href='index.php?page=livrePartager'">
       <p>Mes Livres</p>
        </button>
        <button class="btn-menu-burger" onclick="window.location.href='index.php?page=livreEmprunter'">
       <p>Mes Emprunts</p>
        </button>
        <button class="btn-menu-burger" onclick="window.location.href='index.php?page=livreDispo'">
       <p>Consulter les Livres</p>
        </button>
        <button class="btn-menu-burger" onclick="window.location.href='index.php?page=monProfil'">
       <p>Mon Compte</p>
        </button>
        <form method="POST" class="ms-4">
          <button type="submit" name="isDeco" value="yep" class="btn-menu-burger" >
          <p>Se Déconnecter</p>
        </button>
        </form>
    <?php
     }
     else
     {
       ?>
       <div class="btn-menu-burger" onclick="popupMove()">
        <p>Se Connecter</p>
       </div>
       <?php
       
     }
      ?>
      </div>

      </div>
    </div>
    <?php 
    ?>
    <script src="pub/js/menuBurger.js"></script>
    <?php
    if(!isset($_SESSION['isLog']))
     {
    ?>
    
    <script src="pub/js/popupLogin.js"></script>
    <?php
     }
     ?>
</header>
<!-- popup login -->
<div id="popupLogin" class="d-flex flex-column justify-content-center align-items-center">

    <!-- formulaire de connexion -->
    <form method="POST" class="d-flex flex-column" id="loginForm">
        <h2 class="fw-bold">LOGIN</h2>
        <div class="mb-3">
            <label for="logid">IDENTIFIANT</label>
            <input type="text" placeholder="Votre identifiant" class="form-control" id="logid" name="logID" required>
        </div>
        <div class="mb-3">
            <label for="logpass">MOT DE PASSE (8 characters minimum):</label>
            <input type="password" placeholder="Votre mot de passe" class="form-control" id="logpass" name="password" minlength="8" required>
        </div>
        <br>
        <?php
        if ($erreurConnection && !empty($_POST)) {
            echo   "<p>Désolé, votre identification ou votre mot de passe est erroné</p>";
        }
        ?>
        <br>
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
</div>