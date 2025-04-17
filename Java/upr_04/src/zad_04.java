/*
Да се въведе един стринг от конзолата и да се преброи колко пъти се повтаря даден символ.
Символът да се въвежда също от конзолата.
 */

import java.util.Scanner;

public class zad_04 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = "";
        String searchChar = "";
        System.out.println("Enter string: ");
        input = scan.nextLine();
        System.out.println("Enter char: ");
        searchChar = "" + scan.nextLine().charAt(0);
        int i = -1;
        int count = 0;
        while(true) {
            i = input.indexOf(searchChar, i + 1);
            //System.out.println(i);
            if (i != -1) {
                count++;
            }
            else
                break;
        }
        System.out.println("The \"" + searchChar + "\" is found " + count + " times.");
    }
}
