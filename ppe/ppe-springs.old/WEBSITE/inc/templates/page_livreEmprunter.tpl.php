<!--- 
08/05/2022 Paul ajout du bouton / formulaire pour rendre le livre
-->

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
        <div class="main-aside pb-3">
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

        <?php
    $service = new Service();
    $list = $service->getAllEmprunt();
    foreach($list as $book)
    {
        if($book->getDateEmprunt()->aRetourner())//appel la méthode pour vérifier si la date à dépasser
        {
            $bg = "livre-bg-red";
            $service->insertRetard($book->getIsbn());
        }
        else
        {
            $bg = "livre-bg-blue";
        }
        echo

            '<article class="livre '.$bg.' d-flex flex-column border border-2 rounded border-info p-5 m-4">

                
                <div class="d-flex justify-content-around ">
                <h3>'.$book->getTitle().'</h3><p>ISBN : <span id="isbn-book">'.$book->getIsbn().'</span></p>
                </div>
                <div class="d-flex justify-content-around ">
                <p>'.$book->getEditeur().'</p><p>'.$book->getCollection().'</p><p>'.$book->getDate().'</p>
                </div>
                <div class="d-flex justify-content-around">
                <p>Date d\'emprunt : '.$book->getDateEmprunt()->dateEmpruntToString().' '.$book->getDateEmprunt()->VerificationDate().'</p>
    <form action="index.php?page=voirLivre&isbn='.$book->getIsbn().'" method="POST" class="mx-2" >
        <button type="submit" class="btn btn-primary">VOIR</button>
    </form>
    <form action="index.php?page=rendreLivre&isbn='.$book->getIsbn().'" method="POST" class="mx-2" >
        <button type="submit" class="btn btn-primary">RENDRE</button>
    </form>

    </div>
            </article>';
    
    }
    ?>    



        </div>
    </div>
</div>
</div>
