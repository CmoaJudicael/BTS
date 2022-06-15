/* @author paulb */
package bibliotheque;

import javax.swing.UIManager;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;

public class MainTest {

    public static void main(String[] args) throws Exception {
        //Application du style Nimbus 
        UIManager.setLookAndFeel(new NimbusLookAndFeel());       
        
        JLivre testR = new JLivre();
        testR.afficheJLivre();
        testR.setVisible(true);
    }

}
