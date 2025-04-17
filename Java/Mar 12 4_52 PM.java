import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        File f = new File("output.txt");
        FileWriter fw = null;
        Scanner fr = null;
        try {
            fw = new FileWriter(f);
            fw.write("Hello world\n");  //method write(String s)
            fw.close();
        }
        catch (IOException e) {
            e.printStackTrace();
        }

        try {
            fr = new Scanner(new FileInputStream(f));
            String line = fr.nextLine();
            fr.close();
            System.out.println(line);
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }
}