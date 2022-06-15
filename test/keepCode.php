<script>
    
    /**Odoo */
    <img id="imageMap" src="https://i.pinimg.com/550x/5d/b2/63/5db263b183c85dbec594dfb5d66a8260.jpg" alt="i did it" loading="lazy" data-original-title="" title="" aria-describedby="tooltip517763" class="sticky-element"/>
             
    
    
    /**Script drag and drop */
        
        var obj = document.getElementById('animation');
        var objPosTop = document.getElementById('objTop');
        var objPosLeft= document.getElementById('objLeft');
        obj.onmousedown = function(event) 
        {

            let shiftX = event.clientX - obj.getBoundingClientRect().left;
            let shiftY = event.clientY - obj.getBoundingClientRect().top;
            let objWidth = obj.style.width;
            let objHeight = obj.style.height;

            obj.style.position = 'fixed';

            moveAt(event.pageX, event.pageY);

          // Déplace l'animation aux cordonnées (pageX, pageY)
          // Prenant en compte les changements initiaux
            function moveAt(pageX, pageY) 
            {
                obj.style.left = pageX - shiftX + 'px';
                obj.style.top = pageY - shiftY + 'px';
                obj.style.width=objWidth;
                obj.style.height=objHeight;
                objPosLeft.value = obj.style.left;
                objPosTop.value=obj.style.top;
                
            }

            function onMouseMove(event) 
            {
                moveAt(event.pageX, event.pageY);
            }

          // déplace le obj à l’évènement mousemove
            document.addEventListener('mousemove', onMouseMove);

          // dépose le obj, enlève les gestionnaires d’évènements dont on a pas besoin
            obj.onmouseup = function() 
            {
                document.removeEventListener('mousemove', onMouseMove);
                obj.onmouseup = null;
            };

        };
        obj.ondragstart = function() 
        {
            return false;
        };

    //
           /** animation
       */
      <?php
                if(get_option('type_animation')=='animation GIF')
                {  
                    if (get_option('gif_width')=='') 
                    {
                        $width=400;
                        $height=400;
                    } 
                    else 
                    {
                        $width=get_option('gif_width');
                        $height=get_option('gif_height');
                    }
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {      
                    if (get_option('gif_width')=='') 
                    {
                        $width=400;
                        $height=400;
                    } 
                    else 
                    {
                        $width=get_option('lotti_width');
                        $height=get_option('lotti_height'); 
                    }                              
                }
                elseif(get_option('type_animation')=='animation CSS')
                {                       
                    if (get_option('gif_width')=='') 
                    {
                        $width=400;
                        $height=400;
                    } 
                    else 
                    {
                        $width=get_option('css_width');
                        $height=get_option('css_height');
                    }                      
                }    
            ?>
        document.getElementById('animation').style.marginLeft="-<?php echo $width/2;?>px";
        document.getElementById('animation').style.marginTop="-<?php echo $height/2;?>px";



</script>


