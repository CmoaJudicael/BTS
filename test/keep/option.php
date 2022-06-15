<?php

if ( ! class_exists( '_Opt' ) ) 
{
	class _Opt
    {
		/**
	 	* Constructeur pur cette class.
	 	*/
		public function __construct() 
        {
            //Creation des parametres
            
            creation_parametre();
            creation_section();            
            creation_settings_field();

		}
	}
//
//déclaration des parametres des options
    function creation_parametre()
    {
    //
    //settings
      //
      //page_nombre
        register_setting(
            'Settings', // Settings group.
            'page_nombre',        // Setting name
            array(
                'type'              => 'number',
                'description'       => '',
                'sanitize_callback' => 'sanitize_text_field',
                false,
                1
            )
        );
      //
      for ($i=0; $i < get_option('page_nombre'); $i++) 
      { 
          $group = 'Settings';
          $name = 'page_index'.$i;

        //page_index
          register_setting(
              $group, // Settings group.
              $name,        // Setting name
              array(
                  'type'              => 'number',
                  'description'       => '',
                  'sanitize_callback' => 'sanitize_text_field'
              )
          );
        //
      }
    //
    
    }
    

//
//Creation des sections de parametres
    function creation_section()
    {
    //
    //section 
        add_settings_section( 
            '_option',                   // Section ID
            'Configuration',  // Title
            '',            // Callback or empty string
            'option_page'            // Page to display the section in.
        );
    //
    }


//
//creation des settings_field
    function creation_settings_field()
    {
    //page_nombre
      //page_nombre
        add_settings_field( 
            'page_nombre',                // Field ID
            'Combien de page :',                       // Title
            __( 'page_nombre_field_markup', 'example' ),     // Callback to display the field
            'option_page',                // Page
            '_option',                      // Section
        );
        function page_nombre_field_markup( $args )
        {
            $setting = get_option( 'page_nombre' );
            $value   = $setting ?: '';
            ?>
                <input type="number" name="page_nombre" value="<?php echo esc_attr( $value );?>">   
            <?php
        }  
      //
    //page_index
      //page_index
      
        for ($i=0; $i < get_option(''); $i++) 
        { 
            $name = 'page_index'.$i;
            $field_id = 'page_index'.$i;
            $callField = $field_id.'_field_markup';
            add_settings_field( 
                $field_id,                // Field ID
                'Page désirer :',                       // Title
                __( $callField, $name ),     // Callback to display the field
                'option_page',                // Page
                '_option',                      // Section
            );
            function page_index_field_markup( $name )
            {
                $setting = get_option( $name );
                $value   = $setting ?: '';
                ?>
                    <input type="number" name="page_index" value="<?php echo esc_attr( $value );?>">   
                <?php
            }  
        }
      //
    //   
    }
//
// Instantiate the plugin class.
	$Preloader_Mocha_opt = new Preloader_Mocha_Opt();

}
?>