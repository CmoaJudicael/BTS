<div class="mocha" id="preloader">

<!-- cadre de l'animation -->
    <div id="BackContainer">        
        <div id="animation">
          <!-- Visualiseur -->
            <?php
                if(get_option('type_animation')=='animation GIF')
                {  ?>
                    <div class="visualiseur_animation">
                        <div class="visual">
                            <?php
                                if(get_option( 'gif_lien_animation' )=='')
                                {
                                    echo 'Configurez votre animation GIF';
                                }
                                else
                                {?>  
                                    <img src="<?php echo get_option( 'gif_lien_animation' );?>" alt="Choississez votre animation GIF" width="100%" height="100%"></img>
                                    <?php
                                }
                            ?>
                        </div>
                    </div><?php
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {      ?>
                    <div class="visualiseur_animation">
                        <div class="visual">
                            <?php
                                if(get_option( 'lotti_lien_animation' )=='')
                                {
                                    echo 'Configurez votre animation Lottifile';
                                }
                                else
                                {?>
                                    
                                    <script src="https://unpkg.com/@lottiefiles/lottie-player@latest/dist/lottie-player.js"></script>

                                    <lottie-player id="svgContainer" src="<?php echo get_option( 'lotti_lien_animation' ); ?>"  background="transparent"  speed="1"  style="width: 100%; height: 100%;"  loop autoplay></lottie-player>    
     
                                    <?php
                                }
                            ?>
                        </div>
                    </div><?php
                }
                elseif(get_option('type_animation')=='animation CSS')
                {      ?>
                    <div class="visualiseur_animation">
                        <div class="visual">
                            <?php
                                if(get_option( 'css_code_animation' )=='' )
                                {
                                    echo 'Configurez votre animation';
                                }
                                else
                                {
                                    $anim_css = get_option('css_code_animation');
                                    switch ($anim_css) 
                                    {
                                        case 'css_animation_1':
                                            include 'view/css/css_animation_1.php';
                                            break;
                                        case 'css_animation_2':
                                            include 'view/css/css_animation_2.php';
                                            break;
                                        case 'css_animation_3':
                                            include 'view/css/css_animation_3.php';
                                            break;
                                        case 'css_animation_4':
                                            include 'view/css/css_animation_4.php';
                                            break;
                                        default:
                                            # code...
                                            break;
                                    }              
                                    

                                }
                            ?>
                        </div>
                    </div><?php
                }
            ?>   
        </div>
    </div>
<!-- style à appliquer -->
    <style>  
      /**style de l'animation */ 
        #animation
        {
            
            position: fixed;
            top: <?php
                if(get_option('type_animation')=='animation GIF')
                { 
                    if (get_option('gif_position_top')=='') 
                    {
                        echo '50%';
                    } 
                    else 
                    {
                        echo get_option('gif_position_top').'%';
                    }
                    
                    
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {     
                    if (get_option('gif_position_top')=='') 
                    {
                        echo '50%';
                    } 
                    else 
                    {
                        echo get_option('lotti_position_top').'%';
                    }
                    
                }
                elseif(get_option('type_animation')=='animation CSS')
                {        
                    if (get_option('gif_position_top')=='') 
                    {
                        echo '50%';
                    } 
                    else 
                    {  
                        echo get_option('css_position_top').'%';
                    }
                }    
                ?>;
            left:<?php
                if(get_option('type_animation')=='animation GIF')
                { 
                    if (get_option('gif_position_left')=='') 
                    {
                        echo '75%';
                    } 
                    else 
                    {
                        echo get_option('gif_position_left').'%';
                    }
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {  
                    if (get_option('lotti_position_left')=='') 
                    {
                        echo '75%';
                    } 
                    else 
                    {
                        echo get_option('lotti_position_left').'%';
                    }   
                }
                elseif(get_option('type_animation')=='animation CSS')
                {      
                    if (get_option('css_position_left')=='') 
                    {
                        echo '75%';
                    } 
                    else 
                    {
                        echo get_option('css_position_left').'%';
                    }  
                }    
                ?>;
            <?php
                if(get_option('type_animation')=='animation GIF')
                {  
                    if (get_option('gif_width')=='') 
                    {
                        ?>
                        width: <?php echo '400px'; ?>;
                        height: <?php echo '400px'; ?>;
                    <?php
                    }
                    else 
                    {
                        ?>
                        width: <?php echo get_option('gif_width').'px'; ?>;
                        height: <?php echo get_option('gif_height').'px'; ?>;
                        <?php
                    }
                    
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {   
                    if (get_option('gif_width')=='') 
                    {
                        ?>
                        width: <?php echo '400px'; ?>;
                        height: <?php echo '400px'; ?>;
                    <?php
                    }
                    else 
                    {
                        ?>
                        width: <?php echo get_option('lotti_width').'px'; ?>;
                        height: <?php echo get_option('lotti_height').'px'; ?>;                   
                        <?php
                    }  
                     
                }
                elseif(get_option('type_animation')=='animation CSS')
                {                        
                    if (get_option('gif_width')=='') 
                    {
                        ?>
                        width: <?php echo '400px'; ?>;
                        height: <?php echo '400px'; ?>;
                    <?php
                    }
                    else 
                    {
                        ?>
                        width: <?php echo get_option('css_width').'px'; ?>;
                        height: <?php echo get_option('css_height').'px'; ?>;                    
                        <?php
                    }   
                       
                }    
            ?>
        }
        .mocha>#BackContainer
        {
            width: 1900px;
            height: 1200px; 
            position: fixed; 
            left: -20px; 
            background-color:<?php
                echo '#';
                if(get_option('type_animation')=='animation GIF')
                { 
                    echo get_option('gif_background_color');
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {     
                    echo get_option('lotti_background_color');
                }
                elseif(get_option('type_animation')=='animation CSS')
                {      
                    echo get_option('css_background_color');
                }    
                ?>;
            z-index:99999;

        }

    </style>
<!-- script à appliquer -->
    <script>
      /**Declaration variable
       *  */       
        var s = document.getElementById('BackContainer').style; 
        var backContainer = document.getElementById('BackContainer');
        var player = document.getElementById('svgContainer');
      /** */      
      console.log('<?php echo get_option('')?>');
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

      /** script fade out
       */
        window.addEventListener("DOMContentLoaded", function(event) 
        {          
            date = new Date;
			charg_aft = date.getTime();
            
            var loadTime = charg_aft-charg_bef;
            
            if (loadTime< <?php  
                if(get_option('type_animation')=='animation GIF')
                { 
                    if (get_option('gif_duree_animation')=='') 
                    {
                        echo 0;
                    } 
                    else 
                    {
                        $duree= get_option('gif_duree_animation');
                        echo $duree*1000;
                    }
                    
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {  
                    if (get_option('lotti_duree_animation')=='') 
                    {
                        echo 0;
                    } 
                    else 
                    {
                        $duree= get_option('lotti_duree_animation');
                        echo $duree*1000;
                    }
                }
                elseif(get_option('type_animation')=='animation CSS')
                {  
                    if (get_option('css_duree_animation')=='') 
                    {
                        echo 0;
                    } 
                    else 
                    {
                        $duree= get_option('css_duree_animation');
                        echo $duree*1000;
                    }
                }  ?>
            )
           {
               var timePreloader =  parseInt(<?php  
                if(get_option('type_animation')=='animation GIF')
                { 
                    if (get_option('gif_duree_animation')=='') 
                    {
                        echo 2000;
                    } 
                    else 
                    {
                        $duree= get_option('gif_duree_animation');
                        echo $duree*1000;
                    }
                    
                }
                elseif(get_option('type_animation')=='animation LottiFile')
                {  
                    if (get_option('lotti_duree_animation')=='') 
                    {
                        echo 2000;
                    } 
                    else 
                    {
                        $duree= get_option('lotti_duree_animation');
                        echo $duree*1000;
                    }
                }
                elseif(get_option('type_animation')=='animation CSS')
                {    
                    if (get_option('css_duree_animation')=='') 
                    {
                        echo 2000;
                    } 
                    else 
                    {
                        $duree= get_option('css_duree_animation');
                        echo $duree*1000;
                    }
                }  

              ?>) - loadTime;
               setTimeout("fadeOut()", timePreloader);  
           } 
           else 
           {
               fadeOut();
           }
        });
        function fadeOut()
        {
            var backContainer = document.getElementById('BackContainer');
            var player = document.getElementById('svgContainer');
            var fadeOut=10000;
            var opacityFade=1;
            var playerScale = 1;

            document.documentElement.scrollTop = 0;
            var s = document.getElementById('BackContainer').style;
            s.opacity = 1;
            (function fade(){(s.opacity-=.1)<0?s.display="none":setTimeout(fade,60)})();
            while (s.opacity<0)
            {
                var body = document.body;
                var remChild = document.getElementById('preloader');
                var garbage = body.removeChild(remChild);
            }
        }
      

    </script>
</div>