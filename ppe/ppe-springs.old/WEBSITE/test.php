<?php

require __DIR__ . "/inc/classes/ConnexionDB.php";

$databaseConnexion = new ConnexionDB();
$pdo = $databaseConnexion->getPDO();

$sql = "SELECT * FROM Administre";


$administreList = array();
$pdoStatement = $pdo->query($sql);
$administreList = $pdoStatement->fetchAll(PDO::FETCH_ASSOC);

?>
<h1>Administre</h1>

<?php foreach ($administreList as $administre) : ?>

    <tr>
        <td><?= $administre['_id_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_nom_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_prenom_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_adresse_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_mail_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_telephone_Administre']; ?></td>
    </tr>
    <tr>
        <td><?= $administre['_log_id_Administre']; ?></td>
    </tr>
    <br>
<?php endforeach; ?>