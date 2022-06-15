/* @author paulb */
package mybibliothequeonline;

import java.sql.ResultSet;
import java.time.format.ResolverStyle;
import java.util.ArrayList;

public class JAjoutRole extends javax.swing.JFrame {

    public JAjoutRole() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        headerAddRole = new javax.swing.JPanel();
        titleHeaderAddRole = new javax.swing.JLabel();
        insertRole = new javax.swing.JButton();
        inputNomRole = new javax.swing.JTextField();
        labelNomRole = new javax.swing.JLabel();
        afficheResultatInsertRole = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tableRole = new javax.swing.JTable();
        afficheResultatInsertRole2 = new javax.swing.JLabel();
        deleteRole = new javax.swing.JButton();
        inputIDRole = new javax.swing.JTextField();
        labelIDRole = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(800, 600));
        setResizable(false);
        setSize(new java.awt.Dimension(800, 400));

        headerAddRole.setBackground(new java.awt.Color(0, 139, 139));

        titleHeaderAddRole.setBackground(new java.awt.Color(255, 255, 255));
        titleHeaderAddRole.setFont(new java.awt.Font("Segoe UI", 0, 24)); // NOI18N
        titleHeaderAddRole.setForeground(new java.awt.Color(255, 255, 255));
        titleHeaderAddRole.setText("Ajouter un role");

        javax.swing.GroupLayout headerAddRoleLayout = new javax.swing.GroupLayout(headerAddRole);
        headerAddRole.setLayout(headerAddRoleLayout);
        headerAddRoleLayout.setHorizontalGroup(
            headerAddRoleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, headerAddRoleLayout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(titleHeaderAddRole, javax.swing.GroupLayout.PREFERRED_SIZE, 173, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(292, 292, 292))
        );
        headerAddRoleLayout.setVerticalGroup(
            headerAddRoleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(headerAddRoleLayout.createSequentialGroup()
                .addGap(41, 41, 41)
                .addComponent(titleHeaderAddRole)
                .addContainerGap(43, Short.MAX_VALUE))
        );

        insertRole.setText("Ajouter");
        insertRole.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                insertRoleActionPerformed(evt);
            }
        });

        inputNomRole.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                inputNomRoleActionPerformed(evt);
            }
        });

        labelNomRole.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        labelNomRole.setText("Ajouter un role (Nom Role)");

        afficheResultatInsertRole.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        tableRole.setPreferredSize(new java.awt.Dimension(600, 400));
        jScrollPane1.setViewportView(tableRole);

        afficheResultatInsertRole2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        deleteRole.setText("Supprimer");
        deleteRole.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                deleteRoleActionPerformed(evt);
            }
        });

        inputIDRole.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                inputIDRoleActionPerformed(evt);
            }
        });

        labelIDRole.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        labelIDRole.setText("Supprimer un role (ID)");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(headerAddRole, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(82, 82, 82)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 276, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 104, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(inputNomRole, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 270, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                            .addComponent(insertRole)
                            .addGap(106, 106, 106))
                        .addComponent(labelNomRole))
                    .addComponent(afficheResultatInsertRole, javax.swing.GroupLayout.PREFERRED_SIZE, 273, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(inputIDRole, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 270, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                            .addComponent(deleteRole)
                            .addGap(106, 106, 106))
                        .addComponent(labelIDRole, javax.swing.GroupLayout.PREFERRED_SIZE, 218, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(afficheResultatInsertRole2, javax.swing.GroupLayout.PREFERRED_SIZE, 273, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(36, 36, 36))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(headerAddRole, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(44, 44, 44)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 313, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(52, 52, 52)
                        .addComponent(labelNomRole)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(inputNomRole, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(insertRole)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(afficheResultatInsertRole, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(labelIDRole)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(inputIDRole, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(deleteRole)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(afficheResultatInsertRole2, javax.swing.GroupLayout.PREFERRED_SIZE, 24, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(90, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void insertRoleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_insertRoleActionPerformed
        //creation d'un nouvel objet bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        
        //initialisation à vide du status
        String statusResultats = "";
        
        //récupération du textfield/input
        String nomRole = inputNomRole.getText();

        //connexion à la bdd
        bdd.connecter();

        //insertion de la requete
        bdd.executerRequeteUpdate("INSERT INTO `role` (`_role_role`) VALUES ('" + nomRole + "')");
        statusResultats = "Votre role à bien été ajouté !";

        //affichage du resultat
        afficheResultatInsertRole.setText(statusResultats);

        //deconnexion de la bdd
        bdd.deconnecter();

    }//GEN-LAST:event_insertRoleActionPerformed

    private void inputNomRoleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_inputNomRoleActionPerformed

    }//GEN-LAST:event_inputNomRoleActionPerformed

    private void deleteRoleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_deleteRoleActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_deleteRoleActionPerformed

    private void inputIDRoleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_inputIDRoleActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_inputIDRoleActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(JAjoutRole.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JAjoutRole.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JAjoutRole.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JAjoutRole.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new JAjoutRole().setVisible(true);
                        
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel afficheResultatInsertRole;
    private javax.swing.JLabel afficheResultatInsertRole2;
    private javax.swing.JButton deleteRole;
    private javax.swing.JPanel headerAddRole;
    private javax.swing.JTextField inputIDRole;
    private javax.swing.JTextField inputNomRole;
    private javax.swing.JButton insertRole;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel labelIDRole;
    private javax.swing.JLabel labelNomRole;
    private javax.swing.JTable tableRole;
    private javax.swing.JLabel titleHeaderAddRole;
    // End of variables declaration//GEN-END:variables
}
