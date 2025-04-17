import java.util.*;

public class Resh {
    public static void main(String[] args) {
        int[][] nums = new int[4][];
        /*nums[0] = new int[3];
        nums[1] = new int[5];
        nums[2] = new int[4];
        nums[3] = new int[2];
         */
        Random ran = new Random();
        for (int i = 0; i < nums.length; i++) {
            nums[i] = new int[ran.nextInt(6) + 1];
        }
        Scanner scan = new Scanner(System.in);

        for (int i = 0; i < nums.length; i++) {
            for (int j = 0; j < nums[i].length; j++) {
                System.out.printf("nums[%d][%d]=", i, j);
                nums[i][j] = Integer.parseInt(scan.nextLine());
            }
        }

        for (int i = 0; i < nums.length; i++) {
            System.out.printf("nums[%d]=", i);
            for (int j = 0; j < nums[i].length; j++) {
                System.out.printf("\t%d", nums[i][j]);
            }
            System.out.println();
        }
    }
}