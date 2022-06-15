<?php
/**
 * Judicael 25/04/2022 création de la classe et des méthodes
 * 
 * Volontairement non commenter pour la sécurité et complexifié pour pas grand chose
 */
class SecureScript
{
     
    private $key = '$&_*-#';
    private $alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    private $alphabetMin = 'abcdefghijklmnopqrstuvwxyz';

    function __construct()
    {
        
    }
    private function cryptageLettre($c)
    {
        if($this->rangLettre($c)[0] == -1)
        {
            return $c;
        }
        for($i = 0; $i < strlen($this->alphabet) ; $i++)
        {
            
            if($c == $this->alphabet[$i])
            {
                return $this->alphabet[$this->encrypt($i)];
            }
            else if($c == $this->alphabetMin[$i])
            {
                return $this->alphabetMin[$this->encrypt($i)];
            }
        }
        return ' ';
    }
    private function deCryptageLettre($c)
    {
        if ($this->rangLettre($c)[0] == -1)
        {
            return $c;
        }
        for ($i = 0; $i < strlen($this->alphabet); $i++)
        {
            if ($c == $this->alphabet[$i])
            {
                return $this->alphabet[$this->deCrypt($i)];
            }
            else if($c == $this->alphabetMin[$i])
            {
                return $this->alphabetMin[$this->deCrypt($i)];
            }
        }
        return ' ';
    }

    private function deCrypt($i)
    {
        $a = 19 * ($i - 8);
        $b = 26;
        $c = 0;
        if($a < 0)
        {
            while ($a < 0)
            {
                $c += 1;
                $a += $b;
            }
        }
        else
        {
            while ($a >= $b)
            {
                $c += 1;
                $a -= $b;
            }
        }
        return $a;
    }
    private function encrypt($i)
    {
        $a = 11 * $i + 8;
        $b = 26;
        $c = 0;
        while($a >= $b)
        {
            $c += 1;
            $a -= $b;
        }
        return $a;
    }

    private function rangLettre($lettre)
    {
        $rang = array(-1,0);
        for($i=0; $i < strlen($this->alphabet); $i++)
        {
            if($lettre == $this->alphabet[$i])
            {
                $rang[0] = 0;
                $rang[1] = 1;
                while($this->alphabet[$rang[0]]!= $lettre)
                {
                    $rang[0]+=1;
                }
                break;
            }
            else if($lettre == $this->alphabetMin[$i])
            {
                $rang[0] = 0;
                $rang[1] = 2;
                while($this->alphabetMin[$rang[0]]!= $lettre)
                {
                    $rang[0]+=1;
                }
                break;
            }
        }

        return $rang;
    }

    private function code($motACoder)
    {
        $motCoder = '';
        for($i = 0; $i < strlen($motACoder) ; $i++)
        {
            $rang = $this->rangLettre($motACoder[$i]);
            if($rang[0] == -1)
            {
                $motCoder = $motCoder.$motACoder[$i];
                continue;
            }
            $rang[0] += 13;
            if($rang[0] > 25)
            {
                $rang[0] -= 26;
            }
            switch ($rang[1]) 
            {
                case 1:
                    $motCoder = $motCoder.$this->alphabet[$rang[0]];
                    break;
                case 2:
                    $motCoder = $motCoder.$this->alphabetMin[$rang[0]];
                    break;
            }
        }

        return $motCoder;
    }
    private function Decode(string $motCoder)
    {
        $motDecoder = "";
        for($i = 0; $i < strlen($motCoder); $i++)
        {
            $rang = $this->rangLettre($motCoder[$i]);
            if ($rang[0] == -1)
            {
                $motDecoder = $motDecoder.$motCoder[$i];
                continue;
            }
            $rang[0] -= 13;
            if ($rang[0] < 0)
            {
                $rang[0] += 26;
            }
            switch ($rang[1]) {
                case 1:
                    $motDecoder = $motDecoder.$this->alphabet[$rang[0]];
                    break;
                case 2:
                    $motDecoder = $motDecoder.$this->alphabetMin[$rang[0]];
                    break;
            }
        }
        return $motDecoder;
    }

    public function Chiffrage($message)
    {
        $msgChiffer = "";
        $msg = $this->code($message);
        $rang = 0;
        $rangCryptage = strlen($msg) - 1;
        $harang = strlen($this->key)-1;
        $zigzag = true;
        for($i = 0; $i < (strlen($msg)*2); $i++)
        {
            if ($i%2 == 0)
            {
                if($zigzag)
                {
                    $msgChiffer = $msgChiffer.$this->CryptageLettre($this->key[$harang]);
                    $harang--;
                    if($harang < 0)
                    {
                        $harang = strlen($this->key) - 2;
                    }
                    $zigzag = false;
                }
                else
                {
                    $s = $this->CryptageLettre($msg[$rangCryptage]);
                    $msgChiffer = $msgChiffer.$this->CryptageLettre($s);
                    $rangCryptage--;
                    if ($rangCryptage < 0)
                    {
                        $rangCryptage = strlen($msg) - 1;
                    }
                    $zigzag = true;
                }
            }
            else
            {
                $msgChiffer = $msgChiffer.$this->CryptageLettre($msg[$rang]);
                $rang++;
                if($rang == strlen($msg))
                {
                    break;
                }
            }

        }

        return $msgChiffer;
    }
    
    public function DeChiffrage($message)
    {
        $msgDechiffrer = "";
        for ($i = 0; $i < strlen($message); $i++)
        {
            if($i%2 != 0)
            {
                $msgDechiffrer = $msgDechiffrer.$this->deCryptageLettre($message[$i]);
            }
        }

        $msgDechiffrer = $this->Decode($msgDechiffrer);
        return $msgDechiffrer;
    }
}
