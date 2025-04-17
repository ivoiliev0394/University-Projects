import java.util.Scanner;

/*
Да се съзаде алгоритъм за проверка на въведените username
и password с твърдо въведените в програмата. Максимален брой опити - 3
 */
public class zad_02 {
    public static void main(String[] args) {
        final String user = "admin";
        final String pass = "admin@pass";
        int attempts = 3;
        boolean loggedIn = false;
        Scanner scan = new Scanner(System.in);
        System.out.println("Login to the system:");
        String inputUser = "";
        String inputPass = "";
        for (int i = attempts; i > 0; i--) {
            if (i != 1)
                System.out.println("You have " + i + " attempts left.");
            else
                System.out.println("You have " + i + " " + " attempts left.");
            System.out.print("Enter username:");
            inputUser = scan.nextLine();
            System.out.print("Enter password:");
            inputPass = scan.nextLine();
            if (inputUser.equals(user) && inputPass.equals(pass)) {
                loggedIn = true;
                break;
            }
            else {
                System.out.println("Username and password does not match.");
                try {
                    Thread.sleep(1000); //Изчакваме 1 секунда
                }
                catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
        if (loggedIn)
            System.out.println("Successfully logged in.");
        else
            System.out.println("Login failed.");
    }
}
