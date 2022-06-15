/* @author paulb */
package bibliotheque;

import javax.swing.UIManager;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;

public class Main {
    public static void main(String[] args) throws Exception {   
        //Application du style Nimbus 
        UIManager.setLookAndFeel(new NimbusLookAndFeel());
        
        //recupération de l'objet bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        
        //creation d'une nouvelle session
        JLogin newSession = new JLogin(bdd);
        
        //affichage de la session
        newSession.setVisible(true);
    }
}
