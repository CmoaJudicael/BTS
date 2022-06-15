/* @author paulb */
package bibliotheque;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.UIManager;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableColumnModel;

public class JLivre extends JFrame {

    public JLivre() throws Exception {
        super("Livre");
    }

    public void afficheJLivre() throws Exception {
        this.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        this.setSize(1000, 500);
        this.setLocationRelativeTo(null);
        this.setResizable(false);

        JPanel fenetreLivre = (JPanel) this.getContentPane();
        fenetreLivre.setLayout(new GridLayout(2, 1));

        JPanel panelTableLivre = new JPanel();
        panelTableLivre.add(afficheLivre());

        JButton buttonInsertLivre = new JButton("Ajouter");
        buttonInsertLivre.setFont(new Font("Arial", Font.BOLD, 30));

        buttonInsertLivre.addActionListener((ActionEvent e) -> {

            JAjouterLivre nouvelleFenetre;
            try {
                nouvelleFenetre = new JAjouterLivre();
                nouvelleFenetre.afficheJAjouterLivre();
                nouvelleFenetre.setVisible(true);
            } catch (Exception ex) {
                Logger.getLogger(JLivre.class.getName()).log(Level.SEVERE, null, ex);
            }

        });

        JButton buttonModifierLivre = new JButton("Modifier");
        buttonModifierLivre.setFont(new Font("Arial", Font.BOLD, 30));

        JButton buttonSupprimerLivre = new JButton("Supprimer");
        buttonSupprimerLivre.setFont(new Font("Arial", Font.BOLD, 30));

        JPanel panelCrudLivre = new JPanel();
        panelCrudLivre.setBackground(Color.decode("#008a8a"));
        panelCrudLivre.add(buttonInsertLivre);
        panelCrudLivre.add(buttonModifierLivre);
        panelCrudLivre.add(buttonSupprimerLivre);

        fenetreLivre.add(panelTableLivre);
        fenetreLivre.add(panelCrudLivre);
    }

    public JScrollPane afficheLivre() throws SQLException {
        //table header 
        String columns[] = {"ISBN", "Nom", "Date", "Editeur", "Collection", "Bibliotheque", "Résumé", "Libre ?"};
        //String columns[] = {"ISBN", "Nom", "Date", "Libre ?"};
        //Element Pannel Droit
        DefaultTableModel modelLivre = new DefaultTableModel(tableLivre(), columns);
        JTable tableLivre = new JTable(modelLivre);
        tableLivre.setRowHeight(25);
        TableColumnModel columnModel = tableLivre.getColumnModel();
        columnModel.getColumn(0).setPreferredWidth(35);
        columnModel.getColumn(1).setPreferredWidth(75);
        columnModel.getColumn(2).setPreferredWidth(25);
        columnModel.getColumn(3).setPreferredWidth(5);

        tableLivre.setShowGrid(true);
        tableLivre.setShowVerticalLines(true);
        JScrollPane scrollLivre = new JScrollPane(tableLivre);
        scrollLivre.setPreferredSize(new Dimension(890,200));

        return scrollLivre;
    }

    public String[][] tableLivre() throws SQLException {

        //connection bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        bdd.connecter();

        //requete
        String query = "SELECT * FROM livre";

        //method resultset 
        ResultSet res = bdd.executerRequeteQuery(query);
        ResultSet resLenght = bdd.executerRequeteQuery(query);

        //taille de la requete
        int sizeTab = 0;
        while (resLenght.next()) {
            sizeTab++;
        }

        //initialisation da la matrice
        String data[][] = new String[sizeTab][8];

        //ajout des données dans la matrice
        int i = 0;
        while (res.next()) {
            long isbn = res.getLong("_isbn_livre");
            String nom = res.getString("_nom_livre");
            Date date = res.getDate("_date_edition_livre");
            String editeur = res.getString("_nom_editeur_livre");
            String collection = res.getString("_nom_collection_livre");
            int idBiliotheque = res.getInt("_id_bibliotheque");
            String resume = res.getString("_resume_livre");
            int estEmprunte = res.getInt("_est_emprunte");

            data[i][0] = isbn + "";
            data[i][1] = nom + "";
            data[i][2] = date + "";
            data[i][3] = editeur + "";
            data[i][4] = collection + "";
            data[i][5] = idBiliotheque + "";
            data[i][6] = resume + "";
            data[i][7] = estEmprunte + "";
            i++;
        }
        return data;
    }

    public static void main(String[] args) throws Exception {
        //Application du style Nimbus 
        UIManager.setLookAndFeel(new NimbusLookAndFeel());

        JLivre testR = new JLivre();
        testR.afficheJLivre();
        testR.setVisible(true);
    }

}
