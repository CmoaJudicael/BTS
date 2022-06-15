/* @author paulb */
package bibliotheque;

import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JPanel;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;

public class JRole extends JFrame {

    public JRole() {
        //Nom de la fenetre
        super("Role");
    }

    public void afficheJRole() throws SQLException {

        this.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        this.setSize(1000, 600);
        this.setLocationRelativeTo(null);
        this.setResizable(false);

        JPanel fenetreRole = (JPanel) this.getContentPane();
        fenetreRole.setLayout(new GridLayout(1, 2));
        Dimension dimension = new Dimension(100, 30);

        //ELEMENT PANEL GAUCHE
        JPanel panelTableRole = new JPanel();
        panelTableRole.add(afficheRole());

        //ELEMENT PANEL DROIT
        
        //INSERER
        JLabel inputInsertRole = new JLabel("Nom du role");
        JTextField textFieldNomRole = new JTextField("");
        JButton buttonInsertRole = new JButton("Ajouter");

        buttonInsertRole.addActionListener((ActionEvent e) -> {
            CBdd bdd = new CBdd("parametresBDD.properties");

            //récupération du textfield/input
            String nomRole = textFieldNomRole.getText();

            bdd.connecter();

            bdd.executerRequeteUpdate("INSERT INTO `role` (`_role_role`) VALUES ('" + nomRole + "')");

            try {
                majTab(panelTableRole);
            } catch (SQLException ex) {
                Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
            }
            bdd.deconnecter();
        });

        //MODIFIER
        JLabel inputModifyRoleID = new JLabel("ID du role");
        JTextField textFieldModifyRoleID = new JTextField("");
        JLabel inputModifyRoleNom = new JLabel("Nom du role");
        JTextField textFieldModifyRoleNom = new JTextField("");
        JButton buttonModifyRole = new JButton("Modifier");

        buttonModifyRole.addActionListener((ActionEvent e) -> {
            //creation d'un nouvel objet bdd
            CBdd bdd = new CBdd("parametresBDD.properties");

            //récupération du textfield/input
            String nomRole = textFieldModifyRoleNom.getText();
            int idRole = Integer.parseInt(textFieldModifyRoleID.getText());

            //connexion à la bdd
            bdd.connecter();

            //insertion de la requete
            bdd.executerRequeteUpdate("UPDATE role SET _role_role = '" + nomRole + "' WHERE _id_role =" + idRole);

            try {
                majTab(panelTableRole);
            } catch (SQLException ex) {
                Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
            }

            //deconnexion de la bdd
            bdd.deconnecter();
        });

        //SUPPRIMER
        JLabel inputDeleteRole = new JLabel("ID du role");
        inputDeleteRole.setPreferredSize(dimension);

        JTextField textFieldIDRole = new JTextField("");
        textFieldIDRole.setPreferredSize(dimension);

        JButton buttonDeleteRole = new JButton("Supprimer");

        buttonDeleteRole.addActionListener((ActionEvent e) -> {
            CBdd bdd = new CBdd("parametresBDD.properties");

            int idRole = Integer.parseInt(textFieldIDRole.getText());

            bdd.connecter();

            bdd.executerRequeteUpdate("DELETE FROM role WHERE `role`.`_id_role` = " + idRole);
            try {
                majTab(panelTableRole);
            } catch (SQLException ex) {
                Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
            }
            
            bdd.deconnecter();
        });

        
        //RECHERCHER
        JLabel inputSearchRole = new JLabel("Rechercher un nom");
        inputSearchRole.setPreferredSize(dimension);

        JTextField textFieldSearchRole = new JTextField();
        textFieldSearchRole.setPreferredSize(dimension);

        JButton buttonSearchRole = new JButton("Rechercher");

        buttonSearchRole.addActionListener((ActionEvent e) -> {
            String searchName = textFieldSearchRole.getText();

            panelTableRole.remove(0);

            try {
                panelTableRole.add(afficheRoleSearch(searchName), 0);
            } catch (SQLException ex) {
                Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
            }

            panelTableRole.repaint();
            panelTableRole.revalidate();

        });
        
        //ACTUALISER
        JButton buttonActualizeRole = new JButton("Actualiser");

        buttonActualizeRole.addActionListener((ActionEvent e) -> {
            panelTableRole.remove(0);
            try {
                panelTableRole.add(afficheRole(), 0);
            } catch (SQLException ex) {
                Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
            }
            panelTableRole.repaint();
            panelTableRole.revalidate();
        });
        
        
        //Pannel Droit
        JPanel panelInsertRole = new JPanel();
        panelInsertRole.setLayout(new GridLayout(3, 1));
        panelInsertRole.add(inputInsertRole);
        panelInsertRole.add(textFieldNomRole);
        panelInsertRole.add(buttonInsertRole);

        JPanel panelModifyRole = new JPanel();
        panelModifyRole.setLayout(new GridLayout(5, 1));
        panelModifyRole.add(inputModifyRoleID);
        panelModifyRole.add(textFieldModifyRoleID);
        panelModifyRole.add(inputModifyRoleNom);
        panelModifyRole.add(textFieldModifyRoleNom);
        panelModifyRole.add(buttonModifyRole);

        JPanel panelDeleteRole = new JPanel();
        panelDeleteRole.setLayout(new GridLayout(3, 1));
        panelDeleteRole.add(inputDeleteRole);
        panelDeleteRole.add(textFieldIDRole);
        panelDeleteRole.add(buttonDeleteRole);

        JPanel panelSearchRole = new JPanel();
        panelSearchRole.setLayout(new GridLayout(4, 1));
        panelSearchRole.add(inputSearchRole);
        panelSearchRole.add(textFieldSearchRole);
        panelSearchRole.add(buttonSearchRole);
        panelSearchRole.add(buttonActualizeRole);
        
        
        JPanel panelCrudRole = new JPanel();
        panelCrudRole.setLayout(new GridLayout(5, 1));
        panelCrudRole.add(panelInsertRole);
        panelCrudRole.add(panelModifyRole);
        panelCrudRole.add(panelDeleteRole);
        panelCrudRole.add(panelSearchRole);
    

        //Ajout des panel dans la fenetre
        fenetreRole.add(panelTableRole);
        fenetreRole.add(panelCrudRole);
    }

    public JScrollPane afficheRole() throws SQLException {
        //table header role
        String columns[] = {"ID", "Nom"};

        //Element Pannel Droit
        DefaultTableModel modelRole = new DefaultTableModel(tableauRole(), columns);
        JTable tableRole = new JTable(modelRole);
        tableRole.setShowGrid(true);
        tableRole.setShowVerticalLines(true);
        JScrollPane scrollRole = new JScrollPane(tableRole);

        return scrollRole;
    }

    public String[][] tableauRole() throws SQLException {

        //connection bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        bdd.connecter();

        //requete
        String query = "SELECT * FROM role";

        //method resultset 
        ResultSet res = bdd.executerRequeteQuery(query);
        ResultSet resLenght = bdd.executerRequeteQuery(query);

        //taille de la requete
        int sizeTab = 0;
        while (resLenght.next()) {
            sizeTab++;
        }

        //initialisation da la matrice
        String data[][] = new String[sizeTab][2];

        //ajout des données dans la matrice
        int i = 0;
        while (res.next()) {
            int id = res.getInt("_id_role");
            String nom = res.getString("_role_role");
            data[i][0] = id + "";
            data[i][1] = nom;
            i++;
        }
        return data;
    }

    //Rafraichi le tableau / Fonction a appeler lors d'une action de bouton
    private void majTab(JPanel panelTableRole) throws SQLException {

        panelTableRole.remove(0);
        try {

            panelTableRole.add(afficheRole(), 0);

        } catch (SQLException ex) {
            Logger.getLogger(JRole.class.getName()).log(Level.SEVERE, null, ex);
        }

        panelTableRole.repaint();
        panelTableRole.revalidate();
    }

    public JScrollPane afficheRoleSearch(String nom) throws SQLException {
        //table header role
        String columns[] = {"ID", "Nom"};

        //Element Pannel Droit
        DefaultTableModel modelRole = new DefaultTableModel(tableauRoleSearch(nom), columns);
        JTable tableRole = new JTable(modelRole);
        tableRole.setShowGrid(true);
        tableRole.setShowVerticalLines(true);
        JScrollPane scrollRole = new JScrollPane(tableRole);

        return scrollRole;
    }

    public String[][] tableauRoleSearch(String nomRole) throws SQLException {

        //connection bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        bdd.connecter();
        System.out.println("+" + nomRole + "+");

        //requete
        String query = "SELECT * FROM role WHERE _role_role = '" + nomRole + "';";

        //method resultset 
        ResultSet res = bdd.executerRequeteQuery(query);
        ResultSet resLenght = bdd.executerRequeteQuery(query);

        //taille de la requete
        int sizeTab = 0;
        while (resLenght.next()) {
            sizeTab++;
        }

        //initialisation da la matrice
        String data[][] = new String[sizeTab][2];

        //ajout des données dans la matrice
        int i = 0;
        while (res.next()) {
            int id = res.getInt("_id_role");
            String nom = res.getString("_role_role");
            data[i][0] = id + "";
            data[i][1] = nom;
            i++;
        }
        return data;
    }

}
