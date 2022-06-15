/* @author paulb */
package mybibliothequeonline;

import java.sql.ResultSet;

public class CRole {
    private int idRole;
    private String roleRole;

    public CRole(int idRole, String roleRole) {
        this.idRole = idRole;
        this.roleRole = roleRole;
    }
    
    public CRole(ResultSet resRole)throws Exception{
        this.idRole = resRole.getInt("_id_role");
        this.roleRole = resRole.getString("_role_role");
    }

    public int getIdRole() {
        return idRole;
    }

    public void setIdRole(int idRole) {
        this.idRole = idRole;
    }

    public String getRoleRole() {
        return roleRole;
    }

    public void setRoleRole(String roleRole) {
        this.roleRole = roleRole;
    }

    @Override
    public String toString() {
        return "CRole{" + "idRole=" + idRole + ", roleRole=" + roleRole + '}';
    }
    
    
}
