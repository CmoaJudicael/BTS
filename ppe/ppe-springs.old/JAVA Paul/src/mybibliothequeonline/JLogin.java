/* @author paulb */
package mybibliothequeonline;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class JLogin extends javax.swing.JFrame {

    public JLogin() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        headerLogin = new javax.swing.JPanel();
        textHeaderLogin = new javax.swing.JLabel();
        submitConnexionLogin = new javax.swing.JButton();
        inputIdentifiantLogin = new javax.swing.JTextField();
        inputPasswordLogin = new javax.swing.JTextField();
        titleLogin = new javax.swing.JLabel();
        identifiantTexteLogin = new javax.swing.JLabel();
        passwordTexteLogin = new javax.swing.JLabel();
        resultatTexteLogin = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(690, 500));
        setResizable(false);
        setSize(new java.awt.Dimension(690, 500));

        headerLogin.setBackground(new java.awt.Color(0, 139, 139));

        textHeaderLogin.setFont(new java.awt.Font("Segoe UI", 0, 36)); // NOI18N
        textHeaderLogin.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        textHeaderLogin.setText("My Bibliotheque Online");

        javax.swing.GroupLayout headerLoginLayout = new javax.swing.GroupLayout(headerLogin);
        headerLogin.setLayout(headerLoginLayout);
        headerLoginLayout.setHorizontalGroup(
            headerLoginLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(headerLoginLayout.createSequentialGroup()
                .addGap(68, 68, 68)
                .addComponent(textHeaderLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 549, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(78, Short.MAX_VALUE))
        );
        headerLoginLayout.setVerticalGroup(
            headerLoginLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(headerLoginLayout.createSequentialGroup()
                .addGap(29, 29, 29)
                .addComponent(textHeaderLogin)
                .addContainerGap(34, Short.MAX_VALUE))
        );

        submitConnexionLogin.setText("Se connecter");
        submitConnexionLogin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                submitConnexionLoginActionPerformed(evt);
            }
        });

        titleLogin.setFont(new java.awt.Font("Segoe UI", 0, 24)); // NOI18N
        titleLogin.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        titleLogin.setText("Connection :");

        identifiantTexteLogin.setText("Identifiant");

        passwordTexteLogin.setText("Mot de passe");

        resultatTexteLogin.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        resultatTexteLogin.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(headerLogin, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(245, 245, 245)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(titleLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 198, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(inputPasswordLogin)
                                .addComponent(inputIdentifiantLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 201, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(44, 44, 44)
                                .addComponent(submitConnexionLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 118, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(312, 312, 312)
                        .addComponent(identifiantTexteLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(300, 300, 300)
                        .addComponent(passwordTexteLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 81, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(resultatTexteLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 292, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(200, 200, 200))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(headerLogin, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35)
                .addComponent(titleLogin)
                .addGap(28, 28, 28)
                .addComponent(identifiantTexteLogin)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(inputIdentifiantLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(15, 15, 15)
                .addComponent(passwordTexteLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(inputPasswordLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(submitConnexionLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(resultatTexteLogin, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(15, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void submitConnexionLoginActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_submitConnexionLoginActionPerformed

        //Création d'une liste des roles
        ArrayList<CAdministre> listeAdministre = new ArrayList<CAdministre>();

        //connection bdd
        CBdd bdd = new CBdd("parametresBDD.properties");
        bdd.connecter();

        String identifiant = inputIdentifiantLogin.getText();
        String password = inputPasswordLogin.getText();

        ResultSet resAdministre = bdd.executerRequeteQuery("SELECT _log_id_Administre, _log_password_Administre FROM Administre WHERE _log_id_Administre = '" + identifiant + "' AND _log_password_Administre = '" + password + "';");

        

        
        //deconnexion de la bdd
        bdd.deconnecter();
    }//GEN-LAST:event_submitConnexionLoginActionPerformed

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
            java.util.logging.Logger.getLogger(JLogin.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JLogin.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JLogin.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JLogin.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new JLogin().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel headerLogin;
    private javax.swing.JLabel identifiantTexteLogin;
    private javax.swing.JTextField inputIdentifiantLogin;
    private javax.swing.JTextField inputPasswordLogin;
    private javax.swing.JLabel passwordTexteLogin;
    private javax.swing.JLabel resultatTexteLogin;
    private javax.swing.JButton submitConnexionLogin;
    private javax.swing.JLabel textHeaderLogin;
    private javax.swing.JLabel titleLogin;
    // End of variables declaration//GEN-END:variables
}
