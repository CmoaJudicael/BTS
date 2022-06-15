<?php 
/**
 * @package Ressource Map Boucher Bérichon
 */

//Ajoute les menus à la navigation du back end
 function addNavMenuBack()
 {
     add_menu_page
     (
         'plugin_setting', 
         'setting',
         'manage_options',
         'setting_page',
         'menu_page',
     );
 }
 function menu_page()
 {
     include 'setting.php';
 }
//Mise en place des éléments des options
    function mocha_plugin_settings() 
    { // whitelist options
        include 'option.php';
    }

//hook d'action pour mettre en place le menu et les options
    if ( is_admin() )
    { // admin actions
        add_action( 'admin_menu', 'addNavMenuBack' );
        add_action( 'admin_init', 'mocha_plugin_settings' );

      //initialisation type animation
    }
    if (! get_option('type_animation')=='')
    {
        // affiche le preloader
            add_action( 'wp_body_open', 'lunch_mocha_preloader', 1 );
     
            function lunch_mocha_preloader() 
            {
                include 'view.php';
            }
            function hook_javascript() {
                ?>
                    <SCRIPT LANGUAGE="JavaScript">
		                var date = new Date;
		                var charg_bef = date.getTime();	
	                </SCRIPT>
                <?php
            }
            add_action('wp_head', 'hook_javascript');

    }
?>