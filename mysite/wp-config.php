<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'mysite_wp' );

/** MySQL database username */
define( 'DB_USER', 'monsiteAdmin' );

/** MySQL database password */
define( 'DB_PASSWORD', 'bonjour' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'nsSsb6/ M/$&aF=x dIemYbmPGSHa+!@ztdlP^UR7N$[rUdLF/2wnvLrUUEor]4A' );
define( 'SECURE_AUTH_KEY',  'LYsI243aFOP!!AC|L?#Kv&;lBzx(HAP9X#apH2z0qya}7[l?0h3n!Pz^l.YH(|pq' );
define( 'LOGGED_IN_KEY',    'Lgy9g&os>VME|v=R+cRtP>ZL)})0u47Gpk|lky[@uQOMST%IFA T5u!G 8gl!~~[' );
define( 'NONCE_KEY',        'w@.U}H;jxX!6Za=x!vR%EzXj)O9d4cq%g?&  ]4M%lz!|TR?1sLoJ#tCu~|evm_0' );
define( 'AUTH_SALT',        ']j1LyOd+^=CLN>2W;b{:GW)&5+a8@g%iifc[[4<Ly9ZpTMUKs[-=k<g=OQAg[p[*' );
define( 'SECURE_AUTH_SALT', 'XPY|j3r+EBe%N4m9CSMgxD,Yke_/x=]]P]TuZa!v:){KjEw Ax/</3wR=iO6Ll,_' );
define( 'LOGGED_IN_SALT',   'b}e`8L.6ycjK;uodx?0qqFj0i$<8t&IL>v8u9KRe3ev)}Q.rHAUv7Q,8]K)6G+3v' );
define( 'NONCE_SALT',       'y#2m;&^fiQPa;`):^YZoqtWiQqG!d9<mL?W<`:v*`5UjUX+0jtlT7_;7MgB.W_dE' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
