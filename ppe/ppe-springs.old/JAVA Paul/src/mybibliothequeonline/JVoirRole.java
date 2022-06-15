/* @author paulb */
package mybibliothequeonline;

import java.sql.*;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;


public class JVoirRole {

    public static void main(String[] args) {
        try {
            //connection bdd
            CBdd bdd = new CBdd("parametresBDD.properties");
            bdd.connecter();
            
            //requete
            String query = "SELECT * FROM role";
            
            //method resultset 
            ResultSet res = bdd.executerRequeteQuery(query);
            ResultSet resLenght = bdd.executerRequeteQuery(query);

            //table header
            String columns[] = {"ID", "Nom"};

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

            DefaultTableModel model = new DefaultTableModel(data, columns);
            JTable table = new JTable(model);
            table.setShowGrid(true);
            table.setShowVerticalLines(true);
            JScrollPane pane = new JScrollPane(table);
            JFrame f = new JFrame("Remplir JTable a partir d'une BDD");
            JPanel panel = new JPanel();
            panel.add(pane);
            f.add(panel);
            f.setSize(500, 250);
            f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            f.setVisible(true);

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
