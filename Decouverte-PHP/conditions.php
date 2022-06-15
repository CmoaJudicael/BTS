<a href="index.php">index</a>
<a href="concept.php">concept</a>

<?php
/*
Une condition a pour objectif de :
    1) vérifier la validité d'une opération/instruction
    2) afin de réaliser des actions/opérations en fonction 

    Pour réaliser une condition, on va utiliser ce qu'on appelle une  structure de controle => ici on va donc utiliser l'instruction IF
    Pourvérifier la validité d'une opération/instructions, je vais utiliser les opérateur de comparaison

    < signifie inférieur à
    exemple :
    1 < 3 = vrai

    > signifie supérieur à
    exemple :
    10 < 1 = vrai
    9 > 10 = faux

    <= signifie inférieur ou égal à
    exemple :
    1 < 3 = vrai
    
    >= signifie supérieur ou égal à
    exemple :
    5 >= 3 = vrai
    9 >= 10 = faux

    == signifie que les valeurs sont égales
    exemple :
    1 == 1 vrai
    
    === signifie que les valeurs et leur types sont égaux
    exemple :
    1 === 1 = vrai
    1 === "1" = faux
*/

$conditions = false;

if($conditions)
{
    echo "Bonjour";
    var_dump($conditions);
}
else
{
    echo "Bonsoir";
}
var_dump($conditions);
echo'<br>';
if (5<3)
{
    echo"je vais bien merci";
}
else
{
    echo"J'aime le chocolat";
}

echo'<br>';

if (40 === '40')
{
    echo"J'aime le week-end";
}
else
{
    echo"je n'aime pas les lundis";
}

echo'<br>';

$orange = "orange";
$cerise = "cerise";
$bannane= 'bannane';
$pomme = "pomme";
$maturite = 3;
$maceration = 12;

if($maturite==3)
{
    echo'C\'est le moment de récolter les '. $pomme;
}
elseif ($maturite>12)
{
    echo"Les ".$pomme."s sont pourries";
}
elseif($maturite>8)
{
    echo"On peut fait un clafouti de ".$pomme;
}
elseif($maceration >12)
{
    echo"c'est le moment de boire une petite liqueur";
}
else
{
    echo"je ne sais pas quoi faire";
}

/*
une autre manière de faire est d'utiliser les opérateurs logiques
*/

if ($maturite==3 || $maturite > 12 || $maturite>8 || $maceration>12)
{
    echo"on va preparer une salade de fruits";
}
else
{
    echo"je vais faire la fête seule ce soir";
}
if($maturite==3 && $maceration>12)
{
    echo"j'aime bien les liqueurs";
}
else
{
    echo"Les fruits sont rotis";
}

//Quelques fonctions utiles à connaitre et à utiliser

// empty : vérifie si la valeur contenue dans ma variable est vide ou indéfinie

$age = 15;

if(empty($age))
{
    echo"Attention, vous n'avez pas renseigné votre âge";
}
else
{
    echo"vous avez ".$age." ans";
}

// On va souvent préférer isset. Isset qui est une fonction de php qui va venir vérifier si la variable est définie

if (isset($age))
{
    echo"Votre variables est initialisée";
}
else
{
    echo"La variable n'est pas définie";
}

//qu'est-ce que l'opérateur et l'écriture ternaire? Dans la réalité, on se retrouve souvent à définir




//par exemple quelle heure est-il?

echo"<br>";
$heure=12;

//s'il est moins de 20h, je suis en forme, sinon je suis fatiguée
if($heure<20)
{
    echo'je suis en forme';
}
else
{
    echo'je suis fatigué';
}
echo"<br>";

$etat=$heure<20 ? : 'je suis forme' ;'je suis fatigué';
/*Les boucles permettent d'exécuter une même serie d'instruction plusieurs fois. Par exemple, si j'ai envie d'écrire 20 <li> en utilisant html, je suis obligé de faire du copieé/collé (ou emmet ca va plus vite). Avec PHP, je vais pouvoir générer mes li via une boucle*/

for($i=0;$i<=20;$i++)
{
    echo"<li>Je suis un li</li>";
}

//Nous avons le FOR, le WHILE, et on a le FOREACH   
for($i=0;$i<100;$i++)
{
    echo$i;
}
/*
Dans une boucle de type FOR j'ai donc 3 instructions essentielles:
1) l'initialisation
2) la condition
3) l'incrémentation
 */

 /*
 La boucle WHILE permet de boucler tant que la condition définie dans le while est vrai. Tant que la condition est vrai on boucle, dès quelle est fausse on s'arrête 
 */
$economie=0;
while($economie<100)
{
    $economie+=10;
    echo"je continue de travailler";
    echo"<br>";
}
echo"C'est bon je peux arrêter de travailler";

/*
La boucle do-while : La principale différence de la boucle do-while par rapport à la boucle while est que la première itération de la boucle est toujours exécuté(l'expression est testée à la fin de la première itération), ce qui n'est pas le cas lorsque vous utilisez
*/

//declaration et init
$i=0;
do
{
    echo"8 x ".$i." = ".(8*$i)."<br>";
    //incrementation compteur
    $i++;
}
while($i<=10);

//FOREACH va me permettre de parcourir chacun des éléments d'un tableau et de faire des instructions.

$fruits =
[
    'rouge'=>'cerise',
    'jaune'=>'banane',
    'vert'=>'pomme',
    'violet'=>'citrons'
];

foreach($fruits as $fruit)
{
    echo$fruit;
}

foreach($fruits as $index => $fruit)
{
    echo"le fruit ".$fruit." est ".$index;
    
    echo"<br>";
}


echo"<br>";
/*Pour définir une fonction PHP, j'utilise le mot-clé function suivi du nom que je donne à ma fonction et ensuite je declare ma fonction.
function [NOM_DE_MA_FONCTION]() DECLA de la fonction
*/
function DisplayHello()
{
    echo"Hello";
}
function CalculSurface($longueur,$largeur)
{
    return $longueur*$largeur;
}
function CalculPerimetre($longueur,$largeur)
{
    return 2*($longueur+$largeur);
}
function FaisDuCafe(string $water,)
{
    
}

DisplayHello();
$calcul=CalculSurface(2,5);
var_dump($calcul);
$calculperimetre=CalculPerimetre(5,10);
var_dump($calculperimetre);


?>