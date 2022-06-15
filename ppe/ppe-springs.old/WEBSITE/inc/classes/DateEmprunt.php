<?php
class DateEmprunt
{
    private $date;
    private $today;

    function __construct($date)
    {
        $this->date = DateTime::createFromFormat('Y-m-j',$date);
        $this->today = DateTime::createFromFormat('Y-m-d', date('Y-m-d'));
    }

    public function echoDate()
    {
        echo $this->date->format('Y-m-d');
    }
    public function getDate()
    {
        return $this->date;
    }
    public function VerificationDate()
    {
        
        if(floor($this->date->diff($this->today)->days/7) >= 2)
        {
            return "<strong>Attention!!! Vous avez dépassé la date limite pour le raporter</strong>";
        }
        else
        {
            return null;
        }
    }
    public function aRetourner()
    {
        if(floor($this->date->diff($this->today)->days/7) >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public function dateEmpruntToString()
    {
        return $this->date->format('Y-m-d');
    }

}


?>