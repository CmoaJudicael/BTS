<div class="wrap">
    <h1>Configuration du plugin</h1>
<form action="options.php" method="POST">
        <?php
    
            settings_fields( 'Settings' );
            do_settings_sections( 'option_page' );
            submit_button();
        ?>
    </form>    

</div>