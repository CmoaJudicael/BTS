<!-- 
*
* Judicael 16/04/2022 création de la page 
* Paul 08/05/2022 Ajout du form reservation livre
 -->

<div class="main">
    <div class="search  align-items-center">


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
            <?php

            if (isset($_GET['isbn'])) {
                $isbn = filter_var($_GET['isbn'], FILTER_SANITIZE_NUMBER_INT);
                $service = new Service();
                $book = $service->getBookByIsbn($isbn);
                if ($book == null) {
                    header('Location: index.php');
                }
                echo

                '<article class="livre d-flex flex-column justify-content-around border border-2 rounded border-info p-3 m-2">

            <h3>' . $book->getTitle() . '</h3>
                <div class="d-flex justify-content-start ">
                <p>ISBN : <span id="isbn-book">' . $book->getIsbn() . '</span></p>
                </div>
                <p class="m-5">' . $book->getResume() . '
                <div class="d-flex justify-content-around ">
                <p>' . $book->getEditeur() . '</p><p>' . $book->getCollection() . '</p><p>' . $book->getDate() . '</p>
                </div   >
                <div class="d-flex justify-content-end">
    
    <form action="index.php?page=reserverLivre&isbn=' . $book->getIsbn() . '" method="POST" class="mx-2">
        <button type="submit" class="btn btn-success">RESERVER</button>
    </form>

    </div>
            </article>';
            }
            ?>


        </div>
    </div>
</div>
</div>