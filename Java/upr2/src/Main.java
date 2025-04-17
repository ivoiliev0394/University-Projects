import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        //System.out - izhod kum consolata -> print, println, printf(C and C++)
        // windows - \n\v - nov red ;
        // Linux/Unix-\n;
        //Mac -\n;
        //Sysyem.err - greshki
        //System.in - vhod
        //Scanner - Scanner scan=new Scanner(System.in);
        System.out.println();
        double d1=0.0,d2=0.0;
        Scanner scan=new Scanner(System.in);
        System.out.print("Enter double:");
        d1=scan.nextDouble();//d1=double.Parse(scam.nextLine());
        d2=scan.nextDouble();
        scan.nextLine();
        System.out.println("d1 + d2 = "+ (d1+d2));

        System.out.println();

        String input="";
        System.out.print("Enter string:");
        input=scan.nextLine();
        System.out.println("Enter string: "+ input);

        System.out.println();
        for (int i = 1; i <= 5; i++)
        {
            System.out.println("i = " + i);
        }
    }
}