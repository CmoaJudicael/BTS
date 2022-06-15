/**
 * 
 * Judicaël 13/04/2022 création fichier et fonction
 *  Judicael 20/04/2022 modif script
 */

function moveMenuBurger()
{
    var menuBurger = document.getElementById('menuBurger');
    var menuUp = document.getElementById('upmenu');
    var button = document.getElementById("menuButton");

    if(menuBurger.style.height == "60vh")
    {
        menuBurger.style.height = "0vh";
        menuBurger.style.opacity = "0";
        menuUp.style.height = "0vh";
        button.style.transform = "translate(30vh,0vh)";
    }
    else
    {
        menuBurger.style.height = "60vh";
        menuBurger.style.opacity = "1";
        menuUp.style.height = "15vh";
        button.style.transform = "translate(0vh,0vh)";
    }

}
