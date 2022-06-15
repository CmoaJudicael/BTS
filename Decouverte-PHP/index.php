<h1>Aujourd'hui on découvre PHP</h1>
<a href="conditions.php">condition</a>
<?php 
//Commentaire sur une seul ligne
/*
J'écreis un commentaire sur plusieurs ligne

Ici j'ai écris du html à l'interieur de mon bloc PHP, cela me génère une erreur
<h1>je continue d'écrire du html</h1> 
*/
// Je créé du code html via php grâce à ma fonction
echo '<h2>Voici du html généré par du PHP</h2>';
//j'affiche du texte
echo'coucou';
echo'<br>';

//le lien vers la documentation PHP, notre meilleure amie :
// https://www.php.net/manual/fr/

// Une variable c'est une boîte dans laquelle on va stocker une information, une donnée.

//je créé une variable de type string (chaîne de caractère), contenant la valeur Juliette.
//Exemple de donnée scalaires. C'est à dire de donnée unique.
/*
- string = une chaîne de caractère Exemple : "salut"
- integer = un nombre entier Exemple : 42
- boolean = un booléen Exemple : true ou false
- float = un nombre de l'ensemble Réel (nombre à virgule) Exemple : 9.9512
 */
$prenom = 'juliette';

echo $prenom;
echo'<br>';

$prenom="Mathilde";
echo $prenom;

echo'<br>';

//Ici je créé une variable de type integer.
$age=35;
echo $age;


echo'<br>';

//Ici je créé une variable de type float
$prix = 9.99;
echo $prix;

//Ici grace à la fonction var_dump j'inspecte ma variable : à la vois son type et sa valeur
var_dump($age);

//Autre moyen d'inspecter ma variable, la fonction print_r()
print_r($prix);

//ici j'ai initialisé une variable dont le type est un booléen et la valeur false
$blonde = false;
echo $blonde;

echo'<br>';

//Eemple de constante
//Exempls de constancte en php. la valeur d'une contante ne peut jamais être modifié pendant l'éxécution du script. Le nom d'une constante doit répondre à des normes de nommage, c'est à dire que son nom doit être écrit en MAJUSCULE. Par convention, les constantes sont définie en début de script (et non pas ici au milieu);
define('NOM_DE_MON_CHIEN', 'Lhassa');
echo NOM_DE_MON_CHIEN;

/* 
Les données composé permettent de stocker plusieurs données scalaires.
Les tableaux sont des données composées.

2 Types de tableaux

1. Les tableaux SIMPLES
*/

$fruits = ['cerises','bananes','kiwi','citrons'];

$personne = ['Mathilde', 35 , false, 'Avenue de Marville', 35400];

var_dump($fruits);
var_dump($personne);

//L'échappement \ va nous permettre de signifié à PHP que nous utilisons le caractère non pas comme une instruction PHP mais juste comme un caractère typographique.
$phrase = 'J\'écris';

//Echo ne fonctionne pas sur des données composée comme les tableaux. j'ai une erreur si je l'utilise.

//Je peux faire plein de trucs avec les tableaux, la documentation php me dit tout : https://www.php.net/manual/fr/function.array

//exemple j'ai envie de rajouter  une valeur dans mon tableaux poire

$fruits[] = "poires";


var_dump($fruits);

array_push($fruits,"pommes","figues","raisins");

var_dump($fruits);

var_dump($fruits[5]);

echo $fruits[5];

/* 
L'index d'un index non spécifié commence par défault à zéro. Cependant si je veux, je peut moi même définir les valeurs de l'index. Dès lors mon tableaux devient un tableau associatif.
*/

$personne = [
    'prenom' => 'Mathilde',
    'age' => 35,
    'blonde' => false,
    'rue' => "Avenue de Marville",
    'CodePostal' => 35400
];

var_dump($personne);

//Comment concatene-t-on en PHP?

$prenom='Solène';
$age=22;
echo'Bonjour je m\'appelle '.$prenom.' et j\'ai '.$age.' ans.';

//en php on peut effectuer toute les opérations arithmetiques 

echo'<br>';
// L'addition
echo 4+4;
echo'<br>';
//La soustraction
echo 12-8;
echo'<br>';
//La Multiplication
echo 4*4;
echo'<br>';
//La division
echo 15/3;
echo'<br>';
//Le modulo
echo 25%2;
echo'<br>';

//On peut faire la même chose avec les variables
echo $age + $personne['age'];
$nombre1=15;
$nombre2=10;
echo $nombre1+$nombre2;
/*
PHP nous offre des raccourcies pour modifier une variable.
Par exemple, on va vouloir incrementer une variable, c'est à dire augmenter sa valeur de 1
*/

$economies = 2000;
//Tous les jours, je rajoute un euro dans mes économies

echo'<br>';
var_dump($economies);

echo'<br>';
$economies++;
var_dump($economies);
echo'<br>';
//Je soustrait un euro à mes économies
$economies--;
var_dump($economies);

echo'<br>';
/*
Les opérateurs combinés
ok on a vu comment soustraire ou rajouter1, mais comment je faits si je veux rajouter ou soustraitre plus de 1, par exemple 3
*/
$loyer = 600;
$salaire = 1500;
//Ce mois ci je décide d'economiser mo salaire
$economies+=$salaire;
var_dump($economies);
echo'<br>';
//Maintenant je dois payer mon loyer via mes économies
$economies-=$loyer;
var_dump($economies);


?>
