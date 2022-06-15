/* @author paulb */
package mybibliothequeonline;

import java.sql.*;
import java.util.ArrayList;

public class MyBibliothequeOnline {

    public static void main(String[] args) throws Exception {
        //Création d'une liste des roles
        ArrayList<CRole> listeRole = new ArrayList<CRole>();

        //Créatio de l'objet bdd avec comme argument le fichier parametreBDD
        CBdd bdd = new CBdd("parametresBDD.properties");

        //test de la connexion
        if (bdd.connecter() == true) {
            System.out.println("Ok");
        }
        
        ResultSet resRole = bdd.executerRequeteQuery("SELECT * FROM role");
        try {
            while (resRole.next()) {
                listeRole.add(new CRole(resRole));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        
        //CRUD - Create Read Update Delete
        
        //bdd.executerRequeteQuery("SELECT * FROM role");
        //bdd.executerRequeteUpdate("INSERT INTO `role` (`_role_role`) VALUES ('SUPERADMIN')");
        //bdd.executerRequeteUpdate("UPDATE role SET _role_role = 'UltraAdmin' WHERE _role_role = 'SuperAdmin'");
        //bdd.executerRequeteUpdate("DELETE FROM role WHERE _id_role = '14'");
        
        
        
        
    }
}
