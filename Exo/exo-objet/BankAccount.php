<?php

class BankAccount
{
    private $balance=0;
    private $iban;
    private $overdraft=-1000;
    private $type;
    private $owner;
    private $bankname;

    public function __construct(string $owner,string $bankname,int $iban,string $type)
    {
        $this->owner =$owner;
        $this->bankname=$bankname;
        $this->iban=$iban;
        $this->type=$type;
    }

    public function _get($propriety)
    {
        if ($propriety!='balance') 
        {
            return $this->$propriety;
        }
    }
    public function _getBalance()
    {
        echo 'Votre solde est de '.$this->balance.'<br>';
    }
    public function _set($propriety,$value)
    {
        if ($propriety!='owner' || $propriety!='balance') 
        {
            $this->$propriety=$value;
        }
    }

    public function _credit(int $value)
    {
        if ($value>0)
        {
            $this->balance+=$value;
        }
    }
    public function _debit(int $value)
    {
        if ($value>0) 
        {
            if (($this->balance-$value) > $this->overdraft) 
            {
                $this->balance-=$value;
            }
        }
    }

}


?>