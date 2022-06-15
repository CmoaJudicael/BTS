<?php
/**
 * 
 * Judicael 15/04/2022 création du fichier, des attributs et des getter
 * 
 * 
 */
class User
{
    private $id;
    private $nom;
    private $prenom;
    private $adresse;
    private $mail;
    private $phone;
    private $logID;
    private $logPw;
    private $code;
    private $CP;
    private $ville;
    private $role;
    private $secure;

    function __construct($user, $ville)
    {
        $this->secure = new SecureScript();
        $this->id =  $user['_id_Administre'];
        $this->nom = $user['_nom_Administre'];
        $this->prenom = $user['_prenom_Administre'];
        $this->adresse = $user['_adresse_Administre'];
        $this->mail = $user['_mail_Administre'];
        $this->phone = $user['_telephone_Administre'];
        $this->logID = $user['_log_id_Administre'];
        $this->logPw = $user['_log_password_Administre'];
        $this->code = $user['_code_Administre'];
        $this->role = $user['_id_role'];
        $this->ville = $ville['_nom_ville'];
        $this->CP = $ville['_CP_ville'];
        
    }
    

    public function getId()
    {
        return $this->id;
    }
    public function getNom()
    {
        return $this->secure->DeChiffrage($this->nom);
    }
    public function getPrenom()
    {
        return $this->secure->DeChiffrage($this->prenom);
    }
    public function getAdresse()
    {
        return $this->secure->DeChiffrage($this->adresse);
    }
    public function getMail()
    {
        return  strtolower($this->secure->DeChiffrage($this->mail));
    }
    public function getPhone()
    {
        return $this->secure->DeChiffrage($this->phone);
    }
    public function getLogId()
    {
        return $this->logID;
    }
    public function getLogPw()
    {
        return $this->logPw;
    }
    public function getCode()
    {
        return $this->secure->DeChiffrage($this->code);
    }
    public function getVille()
    {
        return $this->ville;
    }
    public function getCP()
    {
        return $this->CP;
    }
    public function setNom($nom)
    {
        $this->nom = $nom;
    }
    public function setPrenom($prenom)
    {
        $this->prenom = $prenom;
    }
    public function setAdresse($adresse)
    {
        $this->adresse = $adresse;
    }
    public function setCP($cp)
    {
        $this->CP =  $cp;
    }
    public function setMail($mail)
    {
        $this->mail =  $mail;
    }
    public function setPhone($phone)
    {
        $this->phone = $phone;
    }
}


?>