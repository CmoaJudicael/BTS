/* @author paulb */
package bibliotheque;

import java.util.Date;
import java.sql.ResultSet;

public class CLivre {

    private long isbnLivre;
    private String nomLivre;
    private Date dateLivre;
    private String editeurLivre;
    private String collectionLivre;
    private String resumeLivre;
    private int idBibliothequeLivre;
    private int estEmprunteLivre;

    public CLivre(long isbnLivre, String nomLivre, Date dateLivre,String editeurLivre, String collectionLivre, String resumeLivre, int idBibliothequeLivre, int estEmprunteLivre) {
        this.isbnLivre = isbnLivre;
        this.nomLivre = nomLivre;
        this.dateLivre = dateLivre;
        this.editeurLivre = editeurLivre;
        this.collectionLivre = collectionLivre;
        this.resumeLivre = resumeLivre;
        this.idBibliothequeLivre = idBibliothequeLivre;
        this.estEmprunteLivre = estEmprunteLivre;
    }

    public Date getDateLivre() {
        return dateLivre;
    }

    public void setDateLivre(Date dateLivre) {
        this.dateLivre = dateLivre;
    }

    public long getIsbnLivre() {
        return isbnLivre;
    }

    public void setIsbnLivre(long isbnLivre) {
        this.isbnLivre = isbnLivre;
    }

    public String getNomLivre() {
        return nomLivre;
    }

    public void setNomLivre(String nomLivre) {
        this.nomLivre = nomLivre;
    }

    public String getEditeurLivre() {
        return editeurLivre;
    }

    public void setEditeurLivre(String editeurLivre) {
        this.editeurLivre = editeurLivre;
    }

    public String getCollectionLivre() {
        return collectionLivre;
    }

    public void setCollectionLivre(String collectionLivre) {
        this.collectionLivre = collectionLivre;
    }

    public String getResumeLivre() {
        return resumeLivre;
    }

    public void setResumeLivre(String resumeLivre) {
        this.resumeLivre = resumeLivre;
    }

    public int getIdBibliothequeLivre() {
        return idBibliothequeLivre;
    }

    public void setIdBibliothequeLivre(int idBibliothequeLivre) {
        this.idBibliothequeLivre = idBibliothequeLivre;
    }

    public int getEstEmprunteLivre() {
        return estEmprunteLivre;
    }

    public void setEstEmprunteLivre(int estEmprunteLivre) {
        this.estEmprunteLivre = estEmprunteLivre;
    }

    @Override
    public String toString() {
        return "CLivre{" + "isbnLivre=" + isbnLivre + ", nomLivre=" + nomLivre + ", dateLivre=" + dateLivre + ", editeurLivre=" + editeurLivre + ", collectionLivre=" + collectionLivre + ", resumeLivre=" + resumeLivre + ", idBibliothequeLivre=" + idBibliothequeLivre + ", estEmprunteLivre=" + estEmprunteLivre + '}';
    }


    public static void main(String[] args) {
        CLivre livre = new CLivre(98976878,"test",new Date(2022-07-07),"edit","collec","gg",1,1);
        System.out.println(livre.toString());
    }
   

}
