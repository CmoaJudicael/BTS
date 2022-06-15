/* @author paulb */
package bibliotheque;

//Imports
import java.sql.*;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

public class CBdd {

    //attributs
    private final String fichierProperties;
    private Connection conn = null;
    private Statement stmt = null;

    //constructeur surchargé
    public CBdd(String fichierProperties) {
        this.fichierProperties = fichierProperties;
    }

    //fonction connecter
    public boolean connecter() {
        String ip = "";
        int port = 0;
        String driver = "";
        String protocole = "";
        String nom_base = "";
        String user = "";
        String mdp = "";
        String DB_URL = "";

        //lecture du fichierProperties
        try (InputStream in = new FileInputStream(fichierProperties)) {
            Properties prop = new Properties();
            prop.load(in);
            ip = prop.getProperty("ip");
            port = Integer.parseInt(prop.getProperty("port"));
            driver = prop.getProperty("driver");
            protocole = prop.getProperty("protocole");
            nom_base = prop.getProperty("nom_base");
            user = prop.getProperty("user");
            mdp = prop.getProperty("mdp");
        } catch (IOException e) {
            e.printStackTrace();
        }

        // Chargement du driver
        try {
            Class.forName(driver);
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }

        //établissement de la connexion
        try {
            DB_URL = protocole + "//" + ip + ":" + port + "/" + nom_base;
            this.conn = DriverManager.getConnection(DB_URL, user, mdp);
            return true;
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }

    //fonction déconnexion
    boolean deconnecter() {
        try {
            this.conn.close();
            return true;
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }
    }

    int executerRequeteUpdate(String requete) {
        try {
            stmt = (Statement) conn.createStatement();
            return stmt.executeUpdate(requete);
        } catch (SQLException e) {
            e.printStackTrace();
            return -1;
        }
    }

    //exécuter des requêtes select
    ResultSet executerRequeteQuery(String requete) {
        try {
            stmt = (Statement) conn.createStatement();
            return stmt.executeQuery(requete);
        } catch (SQLException e) {
            e.printStackTrace();
            return null;
        }
    }

    //requête select
    static String selectRequest(String item, String table, String condition) {
        item = item;
        table = table;
        condition = condition;
        return "SELECT " + item + " FROM " + table + " WHERE " + condition;
    }
}

