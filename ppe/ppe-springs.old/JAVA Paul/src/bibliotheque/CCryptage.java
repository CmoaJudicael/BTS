/* @author paulb */
package bibliotheque;

public class CCryptage {

    //attributs
    private String key = "$&_*-#";
    private String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    //constructeur
    public CCryptage() {
    }

    //fonction cryptage d'un(1) caractère
    //char = 1 seul caractere
    private char cryptageLettre(char c) {
        //tous ce qui n'est pas dans l'alphabet n'est pas crypté (exemple : chiffre)
        if (rangLettre(c) == -1) {
            return c;
        }
        for(int i = 0; i < alphabet.length();i++){
            if(c == alphabet.charAt(i)){
                return alphabet.charAt(encrypt(i));
            }
        }
        return ' ';
    }

    //permet de savoir rang de la lettre
    private int rangLettre(char lettre) {
        //charAt method qui permet de chercher de recuper l'index d'un caractere
        int rang = -1;
        for (int i = 0; i < alphabet.length(); i++) {
            if (lettre == alphabet.charAt(i)) {
                rang = 0;
                while (this.alphabet.charAt(rang)!= lettre) {
                    rang ++;
                }
                break;
            }
        }
        return rang;

    }

    private int encrypt(int i){
        int a = 11 * i +8;
        int b = 26;
        int c = 0;
        
        while(a >= b){
            c +=1;
            a -= b;
        }
        return a;
    }
}


//Rotation 13 de chaque lettre
//1 lettre sur deux est mauvaise
//Sur celle qui sont bonne 
//Chiffrement affine (encrypt)
