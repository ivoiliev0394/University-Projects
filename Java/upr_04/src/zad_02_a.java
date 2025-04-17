import java.util.Scanner;

/*
Да се съзаде алгоритъм за проверка на въведените username
и password с твърдо въведените в програмата. Максимален брой опити - 3
 */
public class zad_02_a {
    public static void main(String[] args) {
        final String[] users = { "admin", "root", "user1" };
        final String[] passwords = { "admin@pass", "local@", "qwerty" };
        boolean loggedIn = false;
        int attempts = 3;
        Scanner scan = new Scanner(System.in);
        System.out.println("Login to the system:");
        String inputUser = "";
        String inputPass = "";
        attempts:
        for (int i = attempts; i > 0; i--) {
            if (i != 1)
                System.out.println("You have " + i + " attempts left.");
            else
                System.out.println("You have " + i + " attempt left.");
            System.out.print("Enter username:");
            inputUser = scan.nextLine();
            System.out.print("Enter password:");
            inputPass = scan.nextLine();
            for (int j = 0; j < users.length; j++) {
                if (inputUser.equals(users[j]) && inputPass.equals(passwords[j])) {
                    loggedIn = true;
                    break attempts;
                }
            }
            System.out.println("Wrong username or password.");
        }
        if (loggedIn)
            System.out.println("Successfully logged in.");
        else
            System.out.println("Login failed.");
    }
}
