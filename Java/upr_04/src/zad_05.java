/*
Да се въведе един стринг от конзолата и да се преброи колко пъти се повтаря даден символ.
Символът да се въвежда също от конзолата.
 */

import java.util.Scanner;

public class zad_05 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = "";
        String searchString = "";
        System.out.println("Enter string: ");
        input = scan.nextLine();
        System.out.println("Enter string to search: ");
        searchString = scan.nextLine();
        int i = -1;
        int count = 0;
        while(true) {
            i = input.indexOf(searchString, i + 1);
            //System.out.println(i);
            if (i != -1) {
                i = i + searchString.length() - 1;
                count++;
            }
            else
                break;
        }
        System.out.println("The \"" + searchString + "\" is found " + count + " times.");

    }
}
