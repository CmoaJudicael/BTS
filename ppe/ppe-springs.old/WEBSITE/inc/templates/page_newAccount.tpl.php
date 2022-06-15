<?php
/* Alexandra Calonico 23/04/2022
*
*
*/

?>
<div style="height: 150px;">

</div>

<div class="main">
    <div class=" background_image">
        <div class="div_container_form ">



            <div class="divforms">
                <?php
                if (!isset($_POST['nom']) && !isset($_POST['prenom']) && !isset($_POST['mail'])) {
                    //Si les données ne sont pas présente il affiche le formulaire pour le donnée
                ?>
                    <h2> Creer un Compte</h2>
                    <div class="forms">
                        <form  method="POST" class="d-flex flex-column" id="loginForm">
                            <div class="mb-2">
                                <label for="nom">NOM</label>
                                <input type="text" id="nom" name="nom" placeholder="Tape votre nom" class="form-control" required>
                            </div>

                            <div class="mb-2">
                                <label for="prenom">PRENOM</label>
                                <input type="text" id="prenom" name="prenom" placeholder="Tape votre prenom" class="form-control" required>
                            </div>
                            <div class="mb-2">
                                <label for="id">MAIL</label>
                                <input type="mail" id="mail" name="mail" placeholder="Tape votre mail" class="form-control" required>
                            </div>
                            <div>
                            <div class="col-12">
                                <a class="btn button" href="index.php">RETOUR</a>
                            </div>
                            <div class="col-12">
                                <input class="btn button" type="submit" value="CONFIRMER" href ="index.php?page=verificationCode">
                            </div>
                            </div>
                        </form>
                    <?php
                } else if (!isset($_POST['code'])) 
                {// verifier si la variable code de post n'est pas présente 
                    
                    $secure = new SecureScript();
                    //clean entry
                    $nom = $secure->Chiffrage(htmlspecialchars($_POST['nom']));
                    var_dump($nom);
                    $prenom = $secure->Chiffrage(htmlspecialchars($_POST['prenom']));
                    $mail = $secure->Chiffrage(htmlspecialchars($_POST['mail']));
                    //instancie le classe service, 
                    $service = new Service();
                    $user = $service->getDonneeUser($nom,$prenom,$mail);
                    //if (condition) {
                        // primer condicion si user es diferente a null , si no esta se verifica
                        // segunda condicion si user name = postname and prenom and name
                        # code...//confirmation code
                        //html codigo por inserte su codigo 
                        // si no se muestra no se encontro 
                        ?>
                        

                        <?php
                    //}
                    //je fait venir les données,
                    //check,  si tu vas bien 
                    //unset($_POST)
                }
                else if (isset($_POST['code'])) 
                {
                    //condition 
                }
                    ?>
                    </div>
            </div>
        </div>
    </div>
</div>