import java.io.BufferedInputStream;
import java.io.Console;
import java.util.Scanner;
import java.security.*;
/*
Да се съзаде алгоритъм за проверка на въведените username
и password с твърдо въведените в програмата. Максимален брой опити - 3
в този пример паролата е с MD5

Възможни стойности алгоритми - MD5, SHA-1, SHA-256, SHA-512
MessageDigest md = MessageDigest.getInstance("MD5");
String inputPass = "myPass@";
byte[] MD5digest = md.digest(inputPass.getBytes());
преобразуваме данните в byte масива MD5digest в hex
чрез метода public static String hex(byte[] bytes).
 */

public class zad_03 {
    public static String hex(byte[] bytes) {
        StringBuilder result = new StringBuilder();
        for (byte aByte : bytes) {
            result.append(String.format("%02x", aByte));
            // upper case
            // result.append(String.format("%02X", aByte));
        }
        return result.toString();
    }

    public static void main(String[] args) throws NoSuchAlgorithmException {
        final String user = "admin";
        final String passHash = "9760b45791726e6374884945d694c57a"; //admin@local
        //SHA-512 хеш за admin@local
        //final String passHash = "9457ccfce609e2f460505a9c45515b17e8e5bc12019b06e39343c8e34bb064eca95cd15b4aa29c26695ca113303d134320a48042ca77caec1f4122c34b37bdb7";
        boolean loggedIn = false;
        Scanner scan = new Scanner(System.in);
        System.out.println("Login to the system:");
        String inputUser = "";
        String inputPass = "";
        MessageDigest md = MessageDigest.getInstance("MD5");
        for (int i = 3; i > 0; i--) {
            if (i != 1)
                System.out.println("You have " + i + " attempts left.");
            else
                System.out.println("You have " + i + " attempt left.");
            System.out.print("Enter username:");
            inputUser = scan.nextLine();
            System.out.print("Enter password:");
            inputPass = scan.nextLine();
            //калкулиране на MD5 от входния стринг
            byte[] theMD5digest = md.digest(inputPass.getBytes());
            String md5InputHash = hex(theMD5digest);
            if (inputUser.equals(user) && md5InputHash.equals(passHash)) {
                loggedIn = true;
                break;
            }
            else System.out.println("Username and password does not match.");
        }
        if (loggedIn)
            System.out.println("Successfully logged in.");
        else
            System.out.println("Login failed.");
    }
}
