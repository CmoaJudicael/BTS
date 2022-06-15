package mybibliothequeonline;

import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.nio.charset.*;
import java.security.*;
import javax.swing.*;

public class JTestConnexion extends JFrame {

    public JTestConnexion(CBdd bdd) throws Exception {
        super("Connexion");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(400, 300);
        this.setLocationRelativeTo(null);

        JPanel fenetreConnexion = (JPanel) this.getContentPane();
        fenetreConnexion.setLayout(new GridLayout(4, 0));

        JPanel panelTitre = new JPanel();
        panelTitre.setLayout(new FlowLayout());
        panelTitre.add(new JLabel("Bienvenue!"));

        Dimension dimension = new Dimension(100, 30);
        JPanel panelNomDeCompte = new JPanel();
        panelNomDeCompte.setLayout(new FlowLayout());
        JLabel labelNomDeCompte = new JLabel("Nom de Compte: ");
        labelNomDeCompte.setPreferredSize(dimension);
        JTextField textFieldNomDeCompte = new JTextField("");
        textFieldNomDeCompte.setPreferredSize(dimension);
        panelNomDeCompte.add(labelNomDeCompte);
        panelNomDeCompte.add(textFieldNomDeCompte);

        JPanel panelMotDePasse = new JPanel();
        panelMotDePasse.setLayout(new FlowLayout());
        JLabel labelMotDePasse = new JLabel("Mot De Passe :");
        labelMotDePasse.setPreferredSize(dimension);
        JPasswordField textFieldMotDePasse = new JPasswordField();
        textFieldMotDePasse.setEchoChar('*');
        textFieldMotDePasse.setPreferredSize(dimension);
        panelMotDePasse.add(labelMotDePasse);
        panelMotDePasse.add(textFieldMotDePasse);

        JPanel panelBoutonConnexion = new JPanel();
        panelBoutonConnexion.setLayout(new FlowLayout());
        JButton buttonConnexion = new JButton("Connexion");
        buttonConnexion.addActionListener((ActionEvent e) -> {
            try {
                connexion(bdd, textFieldNomDeCompte.getText(), new String(textFieldMotDePasse.getPassword()));
            } catch (Exception ex) {
                Logger.getLogger(JTestConnexion.class.getName()).log(Level.SEVERE, null, ex);
            }
        });
        panelBoutonConnexion.add(buttonConnexion);

        fenetreConnexion.add(panelTitre);
        fenetreConnexion.add(panelNomDeCompte);
        fenetreConnexion.add(panelMotDePasse);
        fenetreConnexion.add(panelBoutonConnexion);

    }

    public void connexion(CBdd bdd, String identifiant, String motDePasse) throws Exception {

        String motDePasseBdd = "";
        String requete = "SELECT _log_password_Administre FROM Administre where _log_id_Administre = \"" + identifiant + "\";";

        if (bdd.connecter() == true) {
            System.out.println("Connexion OK");
            ResultSet rs = bdd.executerRequeteQuery(requete);

            try {
                System.out.println("test3");
                while (rs.next()) {
                    motDePasseBdd = rs.getString("_log_password_Administre");
                    System.out.println("test");
                }
            } catch (SQLException ex) {
                System.out.println("catch");
                ex.printStackTrace();
            }
            bdd.deconnecter();
        } else {
            System.out.println("Connexion KO");
        }

        if (sha256(motDePasse).equals(motDePasseBdd) && !motDePasse.equals("")) {
            System.out.println("Connexion valide!");
            JVoirAdministre newSession = new JVoirAdministre();
            //newSession.setVisible(true);
            this.dispose();
            
        } else {
            System.out.println(sha256(motDePasse));
            System.out.println("mot de passe bdd " + motDePasseBdd);
            System.out.println(motDePasse);
            System.out.println("Echec de la Connexion");
        }
    }

    public String sha256(String motDePasse) throws Exception {
        String str = motDePasse;

        MessageDigest msg = MessageDigest.getInstance("SHA-256");
        byte[] hash = msg.digest(str.getBytes(StandardCharsets.UTF_8));
        // convertir bytes en hexadécimal
        StringBuilder s = new StringBuilder();
        for (byte b : hash) {
            s.append(Integer.toString((b & 0xff) + 0x100, 16).substring(1));
        }
        return (s.toString());
    }
}
