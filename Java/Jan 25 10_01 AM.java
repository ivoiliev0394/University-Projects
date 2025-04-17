import java.util.*;

public class zad_02 {
    public static void main(String[] args) {
        int[] src = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] dest = new int[10];
        int srcpos, destpos, numelem;
        
        Scanner scan = new Scanner(System.in);
        /*
        System.arraycopy(src, 2, dest, 6, 3);
        for (int i = 0; i < dest.length; i++) {
            //System.out.println("dest[" + i + "]" + "=" + dest[i]);
            System.out.print(dest[i] + " ");
        }
        System.out.println();*/

        while (true) {
            System.out.print("Enter src array index:");
            srcpos = Integer.parseInt(scan.nextLine());
            /*
            if (srcpos < 0 || srcpos > src.length - 1)
                System.out.println("Incorrect value.");
            else
                break;*/
            if (srcpos >= 0 && srcpos <= src.length - 1)
                break;
            else System.out.println("Incorrect value.");
        }

        while (true) {
            System.out.print("Enter dest array index:");
            destpos = Integer.parseInt(scan.nextLine());
            /*
            if (destpos < 0 || destpos > dest.length - 1)
                System.out.println("Incorrect value.");
            else
                break;*/
            if (destpos >= 0 && destpos <= dest.length - 1)
                break;
            else System.out.println("Incorrect value.");
        }

        while(true) {
            System.out.print("Enter number of elements to copy:");
            numelem = Integer.parseInt(scan.nextLine());
            if (numelem <= (src.length - srcpos) && numelem <= (dest.length - destpos) && numelem > 0)
                break;
            else
                System.out.println("Incorrect value.");
        }

        System.out.println("Copying from src at " +  srcpos + " to dest at " + destpos + " " + numelem + " elements.");
        System.arraycopy(src, srcpos, dest, destpos, numelem);
        System.out.println("Copied successfully.");
        System.out.print("src[]  = ");
        for (int i = 0; i < src.length; i++)
            System.out.print(src[i] + " ");
        System.out.println();

        System.out.print("dest[] = ");
        for (int i = 0; i < dest.length; i++)
            System.out.print(dest[i] + " ");
        System.out.println();
    }
}
