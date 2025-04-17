import java.util.Scanner;

public class SecondTask {
    public static void main(String[] args)
    {
        Scanner scan=new Scanner(System.in);
        int[] src={1,2,3,4,5,6,7,8,9,10};
        for(int i = 0; i < src.length; i++)
        {
            System.out.print(src[i]+" ");
        }
        System.out.println();
        int[]dest=new int[10];
        for(int i = 0; i < dest.length; i++)
        {
            System.out.print(dest[i]+" ");
        }
        System.arraycopy(src,2,dest,3,5);
        System.out.println();
        for(int i = 0; i < dest.length; i++)
        {
            System.out.print(dest[i]+" ");
        }
        System.out.println();
        int pos1=0,pos2=0,pos3=0;
        do {
            System.out.print("srcpos=");
            pos1 = Integer.parseInt(scan.nextLine());
        }while(pos1<0||pos1>=src.length);
        System.out.println();
        do {
            System.out.print("destpos=");
            pos2 = Integer.parseInt(scan.nextLine());
        }while(pos2<0||pos2>=src.length);
        System.out.println();
        do {
            System.out.print("numelem=");
        pos3 = Integer.parseInt(scan.nextLine());
        }while(pos3<=0||pos3>=src.length);
        System.out.println();
        System.arraycopy(src,pos1,dest,pos2,pos3);
        for(int i = 0; i < dest.length; i++)
        {
            System.out.print(dest[i]+" ");
        }
    }
}
