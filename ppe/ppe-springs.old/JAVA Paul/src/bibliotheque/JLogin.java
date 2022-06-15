/* @author paulb */
package bibliotheque;

import java.awt.Color;
import javax.swing.JFrame;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.nio.charset.*;
import java.security.*;
import javax.swing.*;

public class JLogin extends JFrame {

    //constructeur surchargé 
    public JLogin(CBdd bdd) throws Exception {

        //Nom de la fenetre
        super("Connexion");

        //Fermeture de la fenetre lors de la sortie
        //J'utilise pas EXIT_ON_CLOSE car ca ferme toutes les fenetres existantes
        this.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        //Taille de la fenetre (largeur / hauteur)
        this.setSize(400, 300);

        //Apparition de la fenetre (le parametre null va centrer notre fenetre)
        //Ici la fonction essaye de se placer à la meme place que sa fenetre principal "mere" 
        //Mais comme il en existe pas il va se placer par default au centre.
        this.setLocationRelativeTo(null);

        this.setResizable(false);

        //Récupére le Content Pane de la JFrame pour y ajouter nos éléments
        JPanel fenetreConnexion = (JPanel) this.getContentPane();
        fenetreConnexion.setLayout(new GridLayout(4, 0));

        //Dimension de 100 largeur et 30 hauteur
        Dimension dimension = new Dimension(100, 30);

        //Section titre de la page
        JPanel panelTitre = new JPanel();
        panelTitre.setLayout(new FlowLayout());

        //Label titre de la page
        panelTitre.add(new JLabel("Bienvenue sur MMO", SwingConstants.CENTER));
        panelTitre.setFont(new Font("Serif", Font.BOLD, 30));
        panelTitre.setForeground(Color.black);
        panelTitre.setBackground(Color.decode("#008a8a"));
        panelTitre.setOpaque(true);

        //Section input identifiant
        JPanel panelIdentifiant = new JPanel();
        panelIdentifiant.setLayout(new FlowLayout());

        //Label identifiant
        JLabel labelIdentifiant = new JLabel("Identifiant : ");
        labelIdentifiant.setPreferredSize(dimension);

        //Textfield identifiant
        JTextField textFieldNomDeCompte = new JTextField("");
        textFieldNomDeCompte.setPreferredSize(dimension);

        //Ajout des éléments dans le pannel Identifiant
        panelIdentifiant.add(labelIdentifiant);
        panelIdentifiant.add(textFieldNomDeCompte);

        //Section Mot de passe
        JPanel panelMotDePasse = new JPanel();
        panelMotDePasse.setLayout(new FlowLayout());

        //Label mot de passe
        JLabel labelMotDePasse = new JLabel("Mot De Passe :");
        labelMotDePasse.setPreferredSize(dimension);

        //PasswordField de mot de passe
        JPasswordField textFieldMotDePasse = new JPasswordField();
        //remplace les caracteres écrit par des étoiles
        textFieldMotDePasse.setEchoChar('*');
        textFieldMotDePasse.setPreferredSize(dimension);

        //Ajout des éléments dans le pannel Mot de passe
        panelMotDePasse.add(labelMotDePasse);
        panelMotDePasse.add(textFieldMotDePasse);

        //Section bouton
        JPanel panelBoutonConnexion = new JPanel();
        panelBoutonConnexion.setLayout(new FlowLayout());

        //Bouton connexion
        JButton buttonConnexion = new JButton("Connexion");

        //Action de l'event click sur le bouton connexion
        buttonConnexion.addActionListener((ActionEvent e) -> {
            try {
                //Method connexion avec la bdd , la recuperation de l'identifiant et du mot passe inserer
                connexion(bdd, textFieldNomDeCompte.getText(), new String(textFieldMotDePasse.getPassword()));
            } catch (Exception ex) {
                //en cas d'erreur : affichage d'un message
                Logger.getLogger(JLogin.class.getName()).log(Level.SEVERE, null, ex);
            }
        });
        //Ajout de l'élément bouton dans le pannel Bouton Connexion
        panelBoutonConnexion.add(buttonConnexion);

        //Ajout des pannels dans la fenetre
        fenetreConnexion.add(panelTitre);
        fenetreConnexion.add(panelIdentifiant);
        fenetreConnexion.add(panelMotDePasse);
        fenetreConnexion.add(panelBoutonConnexion);

    }

    public void connexion(CBdd bdd, String identifiant, String motDePasse) throws Exception {

        //Attributs
        String motDePasseBdd = "";
        String requete = "SELECT _log_password_Administre FROM Administre where _log_id_Administre = \"" + identifiant + "\";";

        //Récupération du mot de passe avec l'identifiant entrée par l'utilisateur
        if (bdd.connecter() == true) {
            System.out.println("Connexion OK");
            //execution de la requete avec la fonction executeRequeteQuery dans l'objet rs
            ResultSet rs = bdd.executerRequeteQuery(requete);

            try {
                System.out.println("Tentative de récupération du mot de passe");
                //??? / foreach du resultat de la requete
                while (rs.next()) {
                    motDePasseBdd = rs.getString("_log_password_Administre");
                    System.out.println("Recupération du mot de passe");
                }
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
            //Deconnexion de la bdd
            bdd.deconnecter();
        } else {
            System.out.println("Connexion KO");
        }

        //Comparaison entre la base de données et l'entrée utilisateur
        if (sha256(motDePasse).equals(motDePasseBdd) && !motDePasse.equals("")) {
            System.out.println("Connexion valide!");

            JMenu redirectionMenu = new JMenu();
            redirectionMenu.afficheJMenu();
            redirectionMenu.setVisible(true);

            //Fermeture de la fenetre
            this.dispose();

        } else {
            System.out.println(sha256(motDePasse));
            System.out.println("mot de passe bdd " + motDePasseBdd);
            System.out.println(motDePasse);
            System.out.println("Echec de la Connexion");
        }
    }

    //Method de decryptage
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
