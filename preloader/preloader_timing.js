window.addEventListener("DOMContentLoaded", function(event) 
{
   console.log('inside event listener');
   fadeOut();
   
});

function fadeOut()
{
   console.log('inside fade out');
    var backContainer = document.getElementById('BackContainer');
    var player = document.getElementById('svgContainer');
    var fadeOut=10000;
    var opacityFade=1;
    var playerScale = 1;

   document.documentElement.scrollTop = 0;
   var s = document.getElementById('BackContainer').style;
   s.opacity = 1;
   (function fade(){(s.opacity-=.1)<0?s.display="none":setTimeout(fade,60)})();
}