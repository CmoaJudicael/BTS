using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Org.BouncyCastle.Crypto;

/*
 *
 ** Judicael 22/04/2022
 *
 */

namespace My_Médiathèque_Online.secure
{
    class SecureScrypt
    {

        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string alphabetMin = "abcdefghijklmnopqrstuvwxyz";
        private string key = "$&_*-#";



        public SecureScrypt()
        {
        }

        private char CryptageLettre(Char c)
        {
            if (RangLettre(c)[0] == -1)
            {
                return c;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (c == alphabet[i])
                {
                    return alphabet[Crypt(i)];
                }
                else if (c == alphabetMin[i])
                {
                    return alphabetMin[Crypt(i)];
                }
            }
            return ' ';
        }
        private char DeCryptageLettre(Char c)
        {
            if (RangLettre(c)[0] == -1)
            {
                return c;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (c == alphabet[i])
                {
                    return alphabet[DeCrypt(i)];
                }
                else if (c == alphabetMin[i])
                {
                    return alphabetMin[DeCrypt(i)];
                }
            }
            return ' ';
        }

        private int DeCrypt(int i)
        {
            int a = 19 * (i - 8), b = 26, c = 0;
            if (a < 0)
            {
                while (a < 0)
                {
                    c += 1;
                    a += b;
                }
            }
            else
            {
                while (a >= b)
                {
                    c += 1;
                    a -= b;
                }
            }
            return a;
        }
        private int Crypt(int i)
        {
            int a = 11 * i + 8, b = 26, c = 0;
            while (a >= b)
            {
                c += 1;
                a -= b;
            }
            return a;
        }

        private int[] RangLettre(char lettre)
        {
            int[] rang = { -1, 0 };
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (lettre == alphabet[i])
                {
                    rang[0] = 0;
                    rang[1] = 1;
                    while (alphabet[rang[0]] != lettre)
                    {
                        rang[0]++;
                    }
                    break;
                }
                else if(lettre == alphabetMin[i])
                {
                    rang[0] = 0;
                    rang[1] = 2;
                    while (alphabetMin[rang[0]] != lettre)
                    {
                        rang[0]++;
                    }
                    break;
                }
            }

            return rang;
        }

        private string Code(string motACoder)
        {
            string motCoder = "";
            foreach (char c in motACoder)
            {
                int[] rang = RangLettre(c);
                if (rang[0] == -1)
                {
                    motCoder += c;
                    continue;
                }
                rang[0] += 13;
                if (rang[0] > 25)
                {
                    rang[0] -= 26;
                }
                switch(rang[1])
                {
                    case 1:
                        motCoder += alphabet[rang[0]];
                        break;
                    case 2:
                        motCoder += alphabetMin[rang[0]];
                        break;
                }
            }

            return motCoder;
        }
        private string Decode(string motCoder)
        {
            string motDecoder = "";
            foreach (char c in motCoder)
            {
                int[] rang = RangLettre(c);
                if (rang[0] == -1)
                {
                    motDecoder += c;
                    continue;
                }
                rang[0] -= 13;
                if (rang[0] < 0)
                {
                    rang[0] += 26;
                }
                switch (rang[1])
                {
                    case 1:
                        char z = alphabet[rang[0]];
                        motDecoder += z;
                        break;
                    case 2:
                        motDecoder += alphabetMin[rang[0]];
                        break;
                }
            }

            return motDecoder;
        }

        public string Chiffrage(string message)
        {
            string msgChiffer = "", msg = Code(message);
            int rang = 0, rangCryptage = msg.Length - 1, harang = key.Length - 1;
            bool zigzag = true;
            for (int i = 0; i < (msg.Length * 2); i++)
            {
                if (i % 2 == 0)
                {
                    if (zigzag)
                    {
                        msgChiffer += CryptageLettre(key[harang]);
                        harang--;
                        if (harang < 0)
                        {
                            harang = key.Length - 2;
                        }
                        zigzag = false;
                    }
                    else
                    {
                        char s = CryptageLettre(msg[rangCryptage]);
                        msgChiffer += CryptageLettre(s);
                        rangCryptage--;
                        if (rangCryptage < 0)
                        {
                            rangCryptage = msg.Length - 1;
                        }
                        zigzag = true;
                    }
                }
                else
                {
                    msgChiffer += CryptageLettre(msg[rang]);
                    rang++;
                    if (rang == msg.Length)
                    {
                        break;
                    }
                }

            }

            return msgChiffer;
        }
        public string DeChiffrage(string message)
        {
            string msgDechiffrer = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (i % 2 != 0)
                {
                    msgDechiffrer += DeCryptageLettre(message[i]);
                }
            }

            msgDechiffrer = Decode(msgDechiffrer);
            return msgDechiffrer;
        }

    }
}
