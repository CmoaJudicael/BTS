<!--
* judy 9/05/2022 
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
            <div>
                <?php
                $service = new service();
                    if (isset($_POST['nomAuteur']) && isset($_POST['prenomAuteur'])) 
                    {
                        if($_POST['nomAuteur'] != null && $_POST['prenomAuteur'] != null)
                        {
                            $auteurNom = strtoupper(htmlspecialchars($_POST['nomAuteur']));
                            $auteurPrenom = strtoupper(htmlspecialchars($_POST['prenomAuteur']));
                            $auteur = $service->getAuteur($auteurNom);
                            if ($auteur == null) 
                            {
                                $service->insertAutheur($auteurNom, $auteurPrenom);
                            }
                            $_POST['nomAuteur'] = null;
                            $_POST['prenomAuteur'] = null;
                        }

                    }
                    if(isset($_POST['title']) && isset($_POST['isbn']) && isset($_POST['editeur']) && isset($_POST['date']) && isset($_POST['collection'])  &&  isset($_POST['resume']))
                    {
                        if($_POST['title'] != null && $_POST['isbn'] != null && $_POST['editeur'] != null && $_POST['date'] != null && $_POST['collection'] != null  &&  $_POST['resume'] != null)
                        {
                            $book = array(
                                '_nom_livre' => $title = htmlspecialchars($_POST['title']),
                            '_isbn_livre' => $isbn = htmlspecialchars($_POST['isbn']),
                            '_nom_editeur_livre' => $editeur = htmlspecialchars($_POST['editeur']),
                            '_date_edition_livre' => $date = htmlspecialchars($_POST['date']),
                            '_nom_collection_livre' => $collection = htmlspecialchars($_POST['collection']),
                            '_resume_livre' => $resume = htmlspecialchars($_POST['resume']),
                            );

                            $shareBook = new Books($book, date("Y-m-d"));
                            $auteur = null;
                            $autheurs = $service->getAllAuteur();
                            foreach($autheurs as $author)
                            {
                                if ($author->getId() == $_POST['auteur']) 
                                {
                                    $auteur = $author;
                                }
                            }
                            if($service->getBookByIsbn($shareBook->getIsbn()) == null)
                            {
                                $service->insertBook($shareBook, $auteur);
                            }
                            if($service->getPartage($shareBook) == null)
                            {
                                $service->insertPartage($shareBook);
                            }
                                                
                            $_POST['title'] = null;
                            $_POST['isbn'] = null;
                            $_POST['editeur'] = null;
                            $_POST['date'] = null;
                            $_POST['collection'] = null;
                            $_POST['resume'] = null;
                            $_POST['auteur'] = null;
                        
                        }


                    }
                    
                ?>
                <div class="mx-5 p-5">
                <form action="" method="POST" class="mx-5 px-5">
                            <div class="mb-2">
                                <label for="title">title</label>
                                <input type="text" id="title" name="title" placeholder="Titre du livre" class="form-control" required>
                            </div>

                            <div class="mb-2">
                                <label for="isbn">isbn</label>
                                <input type="number" id="isbn" name="isbn" placeholder="isbn" class="form-control" required>
                            </div>
                            <div class="d-flex justify-content-between align-items-center">
                                
                                <select name="auteur" id="auteur-select">
                                    <?php 
                                    $service = new service();
                                    $autheurs = $service->getAllAuteur();
                                    foreach($autheurs as $author)
                                    {
                                        echo '<option value="'.$author->getId().'">'.$author->getNom().' '.$author->getPrenom().'</option>';
                                    }
                                    ?>
                                </select>
                                <div>
                                <input type="button" class="btn button mx-2" value="Ajouter un auteur" onclick="popupMoveAuteur()">
                                </div>
                                <script src="pub/js/popupAuteur.js"></script>
                            </div>
                            <div class="mb-2">
                                <label for="editeur">Editeur</label>
                                <input type="text" id="editeur" name="editeur" placeholder="Editeur" class="form-control" required>
                            </div>
                            <div class="mb-2">
                                <label for="date">Date d'édition</label>
                                <input type="date" id="date" name="date" placeholder="Date d'édition" class="form-control" required>
                            </div>
                            <div class="mb-2">
                                <label for="collection">Collection</label>
                                <input type="text" id="collection" name="collection" placeholder="Collection" class="form-control" required>
                            </div>
                            <div class="mb-2">
                                <label for="resume">resume</label>
                                <textarea id="resume" name="resume" placeholder="Le resumé du livre" class="form-control"  rows="5" cols="33" required></textarea>
                            </div>
                            <div >
                                <div class="col-12 d-flex flex-column align-items-end">
                                    <input class="btn button" type="submit" value="PARTAGER UN LIVRE">
                                </div>
                                
                                <div class="col-12 d-flex flex-column align-items-end">
                                    <a class="btn button" href="index.php?page=livrePartager">RETOUR</a>
                                </div>
                            </div>
                    </form>
                </div>
            </div>
        <?php
    
        ?>    
    



        </div>
    </div>
</div>
</div>
<!-- popup auteur -->
<div id="popupAuteur" class="d-flex flex-column justify-content-center align-items-center p-3">

    <!-- formulaire de connexion -->
    <form method="POST" class="d-flex flex-column" id="auteurForm">
        <h2 class="fw-bold">AJOUTER UN AUTEUR</h2>
        <div class="m-3">
            <label for="nom-auteur">NOM</label>
            <input type="text" placeholder="Nom de l'auteur" class="form-control" id="nom-auteur" name="nomAuteur" required>
        </div>
        <div class="m-3">
            <label for="prenom-auteur">PRENOM</label>
            <input type="text" placeholder="Prénom de l'auteur" class="form-control" id="prenom-auteur" name="prenomAuteur" required>
        </div>
        <br>
        <br>
        <div class="d-flex flex-column align-items-end m-3">
        <div>
            <button class="btn button" type="submit">VALIDER</button>
        </div>

        <div>
            <input type="button" class="btn button" value="FERMER" onclick="popupMoveAuteur()">
        </div>
        </div>
    </form>
</div>
