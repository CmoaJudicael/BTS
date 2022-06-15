<!-- 
*
* Judicael 16/04/2022 création de la page 
* Paul 06/05/2022 logique emprunt recup de l'isbn et de log Session
 -->

<div class="main">
        <div class="search  align-items-center">


        </div>

        <div class="container-main">
                <div class="main-aside">
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

                        if (isset($_GET['isbn'])) {
                                $isbn = filter_var($_GET['isbn'], FILTER_SANITIZE_NUMBER_INT);
                                $service = new Service();
                                $queries = new Queries();

                                $book = $service->getBookByIsbn($isbn);
                                $user = $service->getUser($_SESSION['logID'], $_SESSION['password']);

                                $isbn = $book->getIsbn();
                                $id = $user->getId();
                                $date = date("Y-m-d H:i:s");

                                $recupInsertLoan = $queries->getInsertLoanBook($id, $isbn, $date);
                                $recupUpdateLoan = $queries->getUpdateLoanStatusBook($isbn);

                                $requete = $service->insertEmprunt($id,$isbn,$date);

                                echo "ISBN du livre = " . $isbn;
                                echo "<br>";
                                echo "Numéro d'administre = " . $id;
                                echo "<br>";
                                echo "Date de l'emprunt = " . $date;
                                echo "<br>";
                                echo "Requete à executer (Insertion) = " . $recupInsertLoan;
                                echo "<br>";
                                echo "Requete à executer (Update) = " . $recupUpdateLoan;
                                echo "<br>";
                                echo "<br>";
                                echo "<br>";
                                echo "Votre livre à bien été réservé";

                        }
                        ?>
                </div>
        </div>
</div>
</div>