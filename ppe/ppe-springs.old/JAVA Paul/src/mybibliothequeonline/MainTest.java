/* @author paulb */
package mybibliothequeonline;

public class MainTest {

    public static void main(String[] args) throws Exception {
        CBdd bdd = new CBdd("parametresBDD.properties");
        JTestConnexion newSession = new JTestConnexion(bdd);
        newSession.setVisible(true);
    }
}
