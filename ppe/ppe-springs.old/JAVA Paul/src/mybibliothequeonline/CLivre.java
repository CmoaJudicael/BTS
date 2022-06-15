/* @author paulb */
package mybibliothequeonline;

import java.util.Date;
import java.sql.ResultSet;

public class CLivre {

    private int isbnLivre;
    private String nomLivre;
    private Date dateEditionLivre;
    private String nomEditeurLivre;
    private String nomCollectionLivre;
    private int idBibliotheque;
    private String resumeLivre;
    private int estEmprunte;

    public CLivre(int isbnLivre, String nomLivre, Date dateEditionLivre, String nomEditeurLivre, String nomCollectionLivre, int idBibliotheque, String resumeLivre, int estEmprunte) {
        this.isbnLivre = isbnLivre;
        this.nomLivre = nomLivre;
        this.dateEditionLivre = dateEditionLivre;
        this.nomEditeurLivre = nomEditeurLivre;
        this.nomCollectionLivre = nomCollectionLivre;
        this.idBibliotheque = idBibliotheque;
        this.resumeLivre = resumeLivre;
        this.estEmprunte = estEmprunte;
    }

    public CLivre(ResultSet resLivre) throws Exception {
        this.isbnLivre = resLivre.getInt("_isbn_livre");
        this.nomLivre = resLivre.getString("_nom_livre");
        this.dateEditionLivre = resLivre.getDate("_date_editon_livre");
        this.nomEditeurLivre = resLivre.getString("_nom_editeur_livre");
        this.nomCollectionLivre = resLivre.getString("_nom_collection_livre");
        this.idBibliotheque = resLivre.getInt("_id_Bibliotheque");
        this.resumeLivre = resLivre.getString("_resume_livre");
        this.estEmprunte = resLivre.getInt("_est_emprunte");
    }

    public int getIsbnLivre() {
        return isbnLivre;
    }

    public void setIsbnLivre(int isbnLivre) {
        this.isbnLivre = isbnLivre;
    }

    public String getNomLivre() {
        return nomLivre;
    }

    public void setNomLivre(String nomLivre) {
        this.nomLivre = nomLivre;
    }

    public Date getDateEditionLivre() {
        return dateEditionLivre;
    }

    public void setDateEditionLivre(Date dateEditionLivre) {
        this.dateEditionLivre = dateEditionLivre;
    }

    public String getNomEditeurLivre() {
        return nomEditeurLivre;
    }

    public void setNomEditeurLivre(String nomEditeurLivre) {
        this.nomEditeurLivre = nomEditeurLivre;
    }

    public String getNomCollectionLivre() {
        return nomCollectionLivre;
    }

    public void setNomCollectionLivre(String nomCollectionLivre) {
        this.nomCollectionLivre = nomCollectionLivre;
    }

    public int getIdBibliotheque() {
        return idBibliotheque;
    }

    public void setIdBibliotheque(int idBibliotheque) {
        this.idBibliotheque = idBibliotheque;
    }

    public String getResumeLivre() {
        return resumeLivre;
    }

    public void setResumeLivre(String resumeLivre) {
        this.resumeLivre = resumeLivre;
    }

    public int getEstEmprunte() {
        return estEmprunte;
    }

    public void setEstEmprunte(int estEmprunte) {
        this.estEmprunte = estEmprunte;
    }

    @Override
    public String toString() {
        return "CLivre{" + "isbnLivre=" + isbnLivre + ", nomLivre=" + nomLivre + ", dateEditionLivre=" + dateEditionLivre + ", nomEditeurLivre=" + nomEditeurLivre + ", nomCollectionLivre=" + nomCollectionLivre + ", idBibliotheque=" + idBibliotheque + ", resumeLivre=" + resumeLivre + ", estEmprunte=" + estEmprunte + '}';
    }

}
