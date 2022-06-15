/* @author paulb */
package bibliotheque;

import javax.swing.JFrame;
import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

public class JMenu extends JFrame {

    public JMenu() {
        //Nom de la fenetre
        super("Menu");
    }

    public void afficheJMenu() throws Exception {
        this.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        this.setSize(600, 300);
        this.setLocationRelativeTo(null);
        this.setResizable(false);

        JPanel fenetreMenu = (JPanel) this.getContentPane();
        //3 lignes sur 1 colonnes avec 10 de largeur et 42 de hauteur
        fenetreMenu.setLayout(new GridLayout(3, 1, 10, 42));

        //Section titre de la page
        JLabel titreMenu = new JLabel("Menu de My Bibliotheque Online", SwingConstants.CENTER);
        titreMenu.setFont(new Font("Serif", Font.BOLD, 30));
        titreMenu.setForeground(Color.black);
        titreMenu.setBackground(Color.decode("#008a8a"));

        titreMenu.setOpaque(true);

        //Bouton Section Role
        JPanel buttonMenu = new JPanel();
        JButton buttonRole = new JButton("Section Role");
        JButton buttonLivre = new JButton("Section Livre");

        //Action de l'event click sur le bouton role
        buttonRole.addActionListener((ActionEvent e) -> {
            try {
                JRole redirectionRole = new JRole();
                redirectionRole.afficheJRole();
                redirectionRole.setVisible(true);
            } catch (Exception ex) {
                Logger.getLogger(JMenu.class.getName()).log(Level.SEVERE, null, ex);
            }
        });

        //Action de l'event click sur le bouton livre
        buttonLivre.addActionListener((ActionEvent e) -> {
            try {
                JLivre redirectionLivre = new JLivre();
                redirectionLivre.afficheJLivre();
                redirectionLivre.setVisible(true);
            } catch (Exception ex) {
                Logger.getLogger(JMenu.class.getName()).log(Level.SEVERE, null, ex);
            }
        });

        buttonMenu.add(buttonRole);
        buttonMenu.add(buttonLivre);

        //Section pied de page
        JLabel footerMenu = new JLabel("Créer par Team Springs", SwingConstants.CENTER);
        footerMenu.setFont(new Font("Serif", Font.ITALIC, 15));
        footerMenu.setForeground(Color.black);
        footerMenu.setBackground(Color.decode("#008a8a"));
        footerMenu.setOpaque(true);

        //Ajout des éléments 
        fenetreMenu.add(titreMenu);
        fenetreMenu.add(buttonMenu);
        fenetreMenu.add(footerMenu);

    }

}
