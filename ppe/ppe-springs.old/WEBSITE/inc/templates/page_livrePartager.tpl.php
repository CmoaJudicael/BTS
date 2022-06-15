<!--
* judy 19/04/2022 
* judy ajout fonction add book 09/05/2022
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
        <div class="conteiner-main ">

        <?php
    $service = new Service();
    $list = $service->getAllPartage();
    foreach($list as $book)
    {
        echo

            '<article class="livre d-flex flex-column border border-2 rounded border-info p-3 m-2">

                
                <div class="d-flex justify-content-around ">
                <h3>'.$book->getTitle().'</h3><p>ISBN : <span id="isbn-book">'.$book->getIsbn().'</span></p>
                </div>
                <div class="d-flex justify-content-around ">
                <p>'.$book->getEditeur().'</p><p>'.$book->getCollection().'</p><p>'.$book->getDate().'</p>
                </div>
                <div class="d-flex justify-content-end">
    <form action="index.php?page=voirLivre&isbn='.$book->getIsbn().'" method="POST" class="mx-2" >
        <button type="submit" class="btn btn-primary">VOIR</button>
    </form>

    </div>
            </article>';
    
    }
    ?>    
    
    <div class="col-12 d-flex justify-content-end">
        <a class="btn button" href="index.php?page=ajouterLivre">AJOUTER UN LIVRE</a>
    </div>



        </div>
    </div>
</div>
</div>
