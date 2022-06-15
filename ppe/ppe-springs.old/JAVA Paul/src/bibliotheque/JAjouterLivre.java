/* @author paulb */
package bibliotheque;

import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.util.Date;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.UIManager;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;

public class JAjouterLivre extends JFrame {

    public JAjouterLivre() throws Exception {
        super("Ajouter un livre");
    }

    public void afficheJAjouterLivre() throws Exception {
        this.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        this.setSize(500, 500);
        this.setLocationRelativeTo(null);
        this.setResizable(false);

        Dimension dimensionTextField = new Dimension(200, 30);

        JPanel fenetreAjoutLivre = (JPanel) this.getContentPane();
        fenetreAjoutLivre.setLayout(new GridLayout(8, 1));

        JLabel inputInsertIsbnLivre = new JLabel("ISBN du livre");
        JTextField textFieldIsbnLivre = new JTextField("");
        textFieldIsbnLivre.setPreferredSize(dimensionTextField);

        JLabel inputInsertNomLivre = new JLabel("Nom du livre");
        JTextField textFieldNomLivre = new JTextField("");
        textFieldNomLivre.setPreferredSize(dimensionTextField);

        JLabel inputInsertDateLivre = new JLabel("Date du livre : Format yyyy-mm-dd");
        JTextField textFieldDateLivre = new JTextField();
        textFieldDateLivre.setPreferredSize(dimensionTextField);

        JLabel inputInsertEditeurLivre = new JLabel("Editeur du livre");
        JTextField textFieldEditeurLivre = new JTextField("");
        textFieldEditeurLivre.setPreferredSize(dimensionTextField);

        JLabel inputInsertCollectionLivre = new JLabel("Collection du livre");
        JTextField textFieldCollectionLivre = new JTextField("");
        textFieldCollectionLivre.setPreferredSize(dimensionTextField);

        JLabel inputInsertResumeLivre = new JLabel("Resume du livre");
        JTextArea textFieldResumeLivre = new JTextArea("");
        textFieldResumeLivre.setLineWrap(true);
        textFieldResumeLivre.setPreferredSize(new Dimension(200, 300));

        JButton buttonInsertLivre = new JButton("Ajouter");

        buttonInsertLivre.addActionListener((ActionEvent e) -> {
            //creation d'un nouvel objet bdd
            CBdd bdd = new CBdd("parametresBDD.properties");

            //récupération du textfield/input
            long isbn = Long.parseLong(textFieldIsbnLivre.getText());
            String nom = textFieldNomLivre.getText();
            String date = textFieldDateLivre.getText();
            String editeur = textFieldEditeurLivre.getText();
            String collection = textFieldCollectionLivre.getText();
            String resume = textFieldResumeLivre.getText();
            int idBibliotheque = 1;
            int estEmprunte = 0;
            //connexion à la bdd
            bdd.connecter();

            //insertion de la requete
           
            bdd.executerRequeteUpdate("INSERT INTO `livre` (`_isbn_livre`, `_nom_livre`, `_date_edition_livre`, `_nom_editeur_livre`, `_nom_collection_livre`, `_id_bibliotheque`, `_resume_livre`, `_est_emprunte`) VALUES ('" + isbn + "', '" + nom + "', '" + date + "', '" + editeur + "', '" + collection + "', '" + idBibliotheque + "', '" + resume + "', '" + estEmprunte + "')");

            bdd.deconnecter();
        });

        JPanel panelISBN = new JPanel();
        panelISBN.setLayout(new GridLayout(1, 2));
        JPanel panelISBN1 = new JPanel();
        panelISBN1.add(inputInsertIsbnLivre);
        JPanel panelISBN2 = new JPanel();
        panelISBN2.add(textFieldIsbnLivre);
        panelISBN.add(panelISBN1);
        panelISBN.add(panelISBN2);

        JPanel panelNom = new JPanel();
        panelNom.setLayout(new GridLayout(1, 2));
        JPanel panelNom1 = new JPanel();
        panelNom1.add(inputInsertNomLivre);
        JPanel panelNom2 = new JPanel();
        panelNom2.add(textFieldNomLivre);
        panelNom.add(panelNom1);
        panelNom.add(panelNom2);
        

        JPanel panelDate = new JPanel();
        panelDate.setLayout(new GridLayout(1,2));
        JPanel panelDate1 = new JPanel();
        panelDate1.add(inputInsertDateLivre);
        JPanel panelDate2 = new JPanel();
        panelDate2.add(textFieldDateLivre);
        panelDate.add(panelDate1);
        panelDate.add(panelDate2);

        JPanel panelEditeur = new JPanel();
        panelEditeur.setLayout(new GridLayout(1,2));
        JPanel panelEditeur1 = new JPanel();
        panelEditeur1.add(inputInsertEditeurLivre);
        JPanel panelEditeur2 = new JPanel();
        panelEditeur2.add(textFieldEditeurLivre);
        panelEditeur.add(panelEditeur1);
        panelEditeur.add(panelEditeur2);

        JPanel panelCollection = new JPanel();        
        panelCollection.setLayout(new GridLayout(1,2));
        JPanel panelCollection1 = new JPanel();
        panelCollection1.add(inputInsertCollectionLivre);
        JPanel panelCollection2 = new JPanel();
        panelCollection2.add(textFieldCollectionLivre);
        panelCollection.add(panelCollection1);
        panelCollection.add(panelCollection2);

        JPanel panelResume = new JPanel();
        panelResume.setLayout(new GridLayout(1,2));
        JPanel panelResume1 =  new JPanel();
        panelResume1.add(inputInsertResumeLivre);
        JPanel panelResume2 = new JPanel();
        panelResume2.add(textFieldResumeLivre);
        panelResume.add(panelResume1);
        panelResume.add(new JScrollPane(panelResume2));
        
        JPanel vide = new JPanel();
        
        
        
        
        JPanel panelButton = new JPanel();
        panelButton.setLayout(new FlowLayout());
        panelButton.add(buttonInsertLivre);

        fenetreAjoutLivre.add(panelISBN);
        fenetreAjoutLivre.add(panelNom);
        fenetreAjoutLivre.add(panelDate);
        fenetreAjoutLivre.add(panelEditeur);
        fenetreAjoutLivre.add(panelCollection);
        fenetreAjoutLivre.add(panelResume);
        fenetreAjoutLivre.add(vide);
        fenetreAjoutLivre.add(panelButton);

    }

    public static void main(String[] args) throws Exception {
        //Application du style Nimbus 
        UIManager.setLookAndFeel(new NimbusLookAndFeel());

        JAjouterLivre testR = new JAjouterLivre();
        testR.afficheJAjouterLivre();
        testR.setVisible(true);
    }

}
