/* @author paulb */
package mybibliothequeonline;

import java.sql.ResultSet;

public class CAdministre {

    private int idAdministre;
    private String nomAdministre;
    private String prenomAdministre;
    private String adresseAdministre;
    private String mailAdministre;
    private String telephoneAdministre;
    private String logIdAdministre;
    private String logPasswordAdministre;
    private String codePostalAdministre;
    private int idVille;
    private int idRole;

    public CAdministre(ResultSet resAdministre) throws Exception {
        this.idAdministre = resAdministre.getInt(idAdministre);
        this.nomAdministre = resAdministre.getString(nomAdministre);
        this.prenomAdministre = resAdministre.getString(prenomAdministre);
        this.adresseAdministre = resAdministre.getString(adresseAdministre);
        this.mailAdministre = resAdministre.getString(mailAdministre);
        this.telephoneAdministre = resAdministre.getString(telephoneAdministre);
        this.logIdAdministre = resAdministre.getString(logIdAdministre);
        this.logPasswordAdministre = resAdministre.getString(logPasswordAdministre);
        this.codePostalAdministre = resAdministre.getString(codePostalAdministre);
        this.idVille = resAdministre.getInt(idVille);
        this.idRole = resAdministre.getInt(idRole);
    }

    public void setIdAdministre(int idAdministre) {
        this.idAdministre = idAdministre;
    }

    public void setNomAdministre(String nomAdministre) {
        this.nomAdministre = nomAdministre;
    }

    public void setPrenomAdministre(String prenomAdministre) {
        this.prenomAdministre = prenomAdministre;
    }

    public void setAdresseAdministre(String adresseAdministre) {
        this.adresseAdministre = adresseAdministre;
    }

    public void setMailAdministre(String mailAdministre) {
        this.mailAdministre = mailAdministre;
    }

    public void setTelephoneAdministre(String telephoneAdministre) {
        this.telephoneAdministre = telephoneAdministre;
    }

    public void setLogIdAdministre(String logIdAdministre) {
        this.logIdAdministre = logIdAdministre;
    }

    public void setLogPasswordAdministre(String logPasswordAdministre) {
        this.logPasswordAdministre = logPasswordAdministre;
    }

    public void setCodePostalAdministre(String codePostalAdministre) {
        this.codePostalAdministre = codePostalAdministre;
    }

    public void setIdVille(int idVille) {
        this.idVille = idVille;
    }

    public void setIdRole(int idRole) {
        this.idRole = idRole;
    }

    public int getIdAdministre() {
        return idAdministre;
    }

    public String getNomAdministre() {
        return nomAdministre;
    }

    public String getPrenomAdministre() {
        return prenomAdministre;
    }

    public String getAdresseAdministre() {
        return adresseAdministre;
    }

    public String getMailAdministre() {
        return mailAdministre;
    }

    public String getTelephoneAdministre() {
        return telephoneAdministre;
    }

    public String getLogIdAdministre() {
        return logIdAdministre;
    }

    public String getLogPasswordAdministre() {
        return logPasswordAdministre;
    }

    public String getCodePostalAdministre() {
        return codePostalAdministre;
    }

    public int getIdVille() {
        return idVille;
    }

    public int getIdRole() {
        return idRole;
    }

}
