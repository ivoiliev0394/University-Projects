import java.util.Arrays;

/*
interface - 100%
abstract class - 0-100%
* */
class A{float f1;}
class B extends  A{ String d1;}
public class Main {
    public static void main(String[] args) {
       /*
       //zad 1
        Car c=new Car("BMW","M6");
        c.run();
        Vehicle v=new Car("Mercedes","CL55");
        v.run();

        //zad 2
        System.out.println();
        System.out.println("Triangle1");
        Triangle triangle=new Triangle(6,6,6);
        System.out.println("Sum = "+triangle.calcPerimeter());
        System.out.println("Equal side -"+triangle.equalSides());

        System.out.println();
        System.out.println("Triangle2");
        Triangle triangle2=new Triangle(6,4,6);
        System.out.println("Sum = "+triangle2.calcPerimeter());
        System.out.println("Equal side -"+triangle2.equalSides());

        System.out.println();System.out.println("Tetragon 1");

        Tetragon tetragon=new Tetragon(5,5,5,5);
        System.out.println("Sum = "+ tetragon.calcPerimeter());
        System.out.println("Equal side -"+tetragon.equalSides());

        System.out.println();System.out.println("Tetragon 2");
        Tetragon tetragon2=new Tetragon(3,4,5,5);
        System.out.println("Sum = "+ tetragon2.calcPerimeter());
        System.out.println("Equal side -"+tetragon2.equalSides());
        */
        A a=new A();
        B b=new B();
        a.f1=2.2f;
        b.f1=3.3f;
        b.d1="";
        System.out.println(b.d1+b.f1+a.f1);
        /*
        //zad 3
        System.out.println();
        Bike bike=new Bike("Sport",2);
        bike.motion();
        bike.poweredBy();
        System.out.println("PT = " + bike.isPublicTransport());
        System.out.println();
        Tcar car=new Tcar("Sport",4);
        car.motion();
        car.poweredBy();
        System.out.println("PT = " + car.isPublicTransport());
        System.out.println();
        Bus bus=new Bus("School",4);
        bus.motion();
        bus.poweredBy();
        System.out.println("PT = " + bus.isPublicTransport());
         */

    }
}