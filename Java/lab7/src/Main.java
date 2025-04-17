import my.pack.*;
public class Main {
    public static void main(String[] args) {
        ClassA1 array[]=new ClassA1[10];
        for (int i = 0; i < array.length; i++) {
            array[i]=new ClassA1();
        }
        array[7].staticVariable=777;//ClassA1.staticVariable=777;
        for (int i = 0; i < array.length; i++) {
            System.out.println(array[i].staticVariable);
        }
    }
}