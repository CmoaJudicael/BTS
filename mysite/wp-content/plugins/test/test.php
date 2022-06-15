<?php
/**
 * Plugin Name: teste de creation de plugin
 * Description: Ceci est un test de creation pour le loisir 
 * Author: CmoaJudicael
 */
function addCPT(){
    register_post_type('film', [
        'labels' => [
            'name' => ('films'),
            'singular_name' => ('film'),
        ],
        'menu_name' => 'films', 
        'public' => true, 
        ]);
}

add_action('init', 'addCPT');
?>