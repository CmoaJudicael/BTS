

function popupMove()
{
    var popup = document.getElementById('popupLogin');
    var pos = "-100vh";
    if(popup.style.top == pos)
    {
        popup.style.top = "0vh";
    }
    else
    {
        popup.style.top = pos;
    }
}

window.onload = function(){popupMove();};