

public class Main {
    public static void main(String[] args) {
        String s1 = "Hello"; //String s1 = new String("Hello");
        String s2 = "Hello"; //String s2 = new String("Hello");
        String s3 = new String("I am programming with Java");
        //Проверката на стрингове не се извършва с ==. В този случай резултатът е true,
        //защото Java дава една и съща референция при инициализацията на стринга чрез "".
        //Ако използваме new, то тогава резултатът ще е false.
        //Сравнението трябва да става с метода equals.
        if (s1 == s2) //if (s1.equals(s2))
            System.out.println("s1 == s2");
        else
            System.out.println("s1 != s2");
    }
}