/* @author paulb */
package mybibliothequeonline;

import java.sql.*;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;

public class JVoirAdministre {

    public static void main(String[] args) {
        try {
            //connection bdd
            CBdd bdd = new CBdd("parametresBDD.properties");
            bdd.connecter();

            //requete
            String query = "SELECT * FROM Administre";

            //method resultset 
            ResultSet res = bdd.executerRequeteQuery(query);
            ResultSet resLenght = bdd.executerRequeteQuery(query);

            //table header
            String columns[] = {"ID", "Nom", "Prenom", "Adresse", "Mail", "Téléphone", "LogId", "LogPassword", "Code Administre", "ID Ville", "ID Role"};

            //taille de la requete
            int sizeTab = 0;
            while (resLenght.next()) {
                sizeTab++;
            }

            //initialisation da la matrice
            String data[][] = new String[sizeTab][11];

            //ajout des données dans la matrice
            int i = 0;
            while (res.next()) {
                int id = res.getInt("_id_Administre");
                String nom = res.getString("_nom_Administre");
                String prenom = res.getString("_prenom_Administre");
                String adresse = res.getString("_adresse_Administre");
                String mail = res.getString("_mail_Administre");
                String telephone = res.getString("_telephone_Administre");
                String logIdentifiant = res.getString("_log_id_Administre");
                String logPassword = res.getString("_log_password_Administre");
                String code = res.getString("_code_Administre");
                int ville = res.getInt("_id_ville");
                int role = res.getInt("_id_role");

                data[i][0] = id + "";
                data[i][1] = nom + "";
                data[i][2] = prenom + "";
                data[i][3] = adresse + "";
                data[i][4] = mail + "";
                data[i][5] = telephone + "";
                data[i][6] = logIdentifiant + "";
                data[i][7] = logPassword + "";
                data[i][8] = code + "";
                data[i][9] = ville + "";
                data[i][10] = role + "";

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
            f.setSize(900, 450);
            f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            f.setVisible(true);
            
            //deconnection de la bdd
            bdd.deconnecter();

        } catch (SQLException e) {
            e.printStackTrace();
        }

    }

}
