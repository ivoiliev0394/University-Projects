import com.shape.*;
import com.shape.calculations.*;
import my.pack.*;

public class Main {
    public static void main(String[] args) {
        Triangle t = new Triangle(5,6,7);
        Rectangle r = new Rectangle(6, 7);
        Polygon p = new Polygon(5, 7, 10, 30, 70, 100);
        Circle c = new Circle(55);
        System.out.println("Triangle " + PerimeterCalc.calc(t));
        System.out.println("Rectangle " + PerimeterCalc.calc(r));
        System.out.println("Polygon with " + p.getSides().length + " sides " + PerimeterCalc.calc(p));
        System.out.println("Circle " + PerimeterCalc.calc(c));

        ClassA1 a[] = new ClassA1[10];
        for (int i = 0; i < a.length; i++) {
            a[i] = new ClassA1();
        }
        a[0].staticVariable = 10;

        for (int i = 0; i < a.length; i++) {
            System.out.println(a[i].staticVariable);
        }
    }
}

