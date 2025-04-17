//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import  java.io.*;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        File f = new File(".");
        String[] filesNames = f.list();
        for (int i = 0; i < filesNames.length; i++)
            System.out.println("File:" + filesNames[i]);
        System.out.println();
        File[] files = f.listFiles();
        for (int i = 0; i < files.length; i++)
            System.out.println("File:" + files[i].getAbsolutePath());

        String path = System.getProperty("user.dir");
        System.out.println("User dir: " + path);
        System.out.println(f.getPath());
        System.out.println(f.getAbsolutePath());

        Scanner scan = new Scanner(System.in);
        System.out.print("Enter file name:");
        String inputName = scan.nextLine();
        File inputFile = new File(inputName);
        System.out.println("Exists: " + inputFile.exists());
        System.out.println("Can write: " + inputFile.canWrite());
        System.out.println("Can read: " + inputFile.canRead());
        
    }
}