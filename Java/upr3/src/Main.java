import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scan=new Scanner(System.in);
        int n ; n=Integer.parseInt(scan.nextLine());
        int[][] nums=new int[n][];
        for (int i = 0; i < n; i++) {
            System.out.print("Enter the size of sub-array " + (i + 1) + ": ");
            int sizeOfSubArray = scan.nextInt();
            nums[i] = new int[sizeOfSubArray];
        }
        for (int i = 0; i < nums.length; i++) {
            for (int j = 0; j < nums[i].length; j++) {
                nums[i][j]=scan.nextInt();
            }
        }
        System.out.println();
        for (int i = 0; i < nums.length; i++)
        {
            for (int j = 0; j < nums[i].length; j++)
            {
                System.out.print(nums[i][j]+" ");
            }
            System.out.println();
        }
        System.out.println();
        for (int i = 0; i < nums.length; i++)
        {
            for (int j = 0; j < nums[i].length; j++)
            {
                System.out.println("nums["+i+"]["+j+"]="+"\t"+nums[i][j]);
            }
        }
        System.out.println();

    }
}