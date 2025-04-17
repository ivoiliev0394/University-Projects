//Nested Classes
// try{} catch{} finally{}
/*
* Throwable
* |->Exception -> наследници -> базов клас
* |             ->printStackTraced-> Всички методи по време на RunTime до спиране и възникване на  Exception
* |->Error(не трябва да се прихващат -> синия екран при рибут)
* */
import java.util.*;
public class Main {
    public static void main(String[] args) {
       /*
       OuterClass.StaticInnerClass s=new OuterClass.StaticInnerClass(99);
        System.out.println(s.getA());
        OuterClass out=new OuterClass(77);
        OuterClass.InnerClass inner=out.new InnerClass(66,55);
        System.out.println(inner.getA()+" "+ inner.getB());
        inner.setOuterVal(777);
        System.out.println(out.getOuterVal());
        */
        ExceptionExample ee = new ExceptionExample();
        try {
            ee.setLength(44);
            System.out.println(ee.getLength());
            ee.setLength(-50);
            System.out.println(ee.getLength());
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        ee.inputLength();
        System.out.println(ee.getLength());

        ExceptionExample ee1 = null;
        try {
            ee1 = new ExceptionExample(-10);
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        System.out.println("object: " + ee1);
    }
}