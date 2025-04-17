import java.util.Scanner;

public class Arrays
{
    //int[] arr1 or int arr1[]  = new int[5];
    //String[] arr2=new String[5];
    public static void main(String[] args)
    {
        Scanner scan=new Scanner(System.in);
        int[] arr1 = new int[5];
        for(int i = 0; i < arr1.length; i++)
        {
            System.out.print(arr1[i]+" ");
        }

        System.out.println();
        String[] arr2=new String[5];
        for(int i = 0; i < arr2.length; i++)
        {
            System.out.print(arr2[i]+" ");
        }
        System.out.println();
        for(int i = 0; i < arr2.length; i++)
        {
            System.out.print(i+"="+arr1[i]);
            arr2[i]=new String(""+i);
            System.out.println(" After int:"+arr2[i]);
        }
        int[] a={1,2,3,4,5,6,7,8,9,10};
        int[]b={1,2,3,4,5};
        a=b;
        //a[7]=50; Index out of bounds
        System.out.println();
        int n ; n=Integer.parseInt(scan.nextLine());
        int[] x = new int[n];
        int[] y = new int[n];
        for(int i = 0; i < x.length; i++)
        {
            x[i]=Integer.parseInt(scan.nextLine());
            y[i]=Integer.parseInt(scan.nextLine());
        }
    }
}
