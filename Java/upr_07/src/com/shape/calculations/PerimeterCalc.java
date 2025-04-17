package com.shape.calculations;
import com.shape.*;
import static java.lang.Math.*;
public class PerimeterCalc {

    public static double calc(Triangle t) {
        if (t != null)
            return t.getA() + t.getB() + t.getC();
        else return 0.0;
    }

    public static double calc(Rectangle r) {
        if (r != null)
            return r.getA() * 2 + r.getB() * 2;
        else return 0.0;
    }

    public static double calc(Polygon p) {
        if (p != null) {
            double sides[] = p.getSides();
            double r = 0.0;
            for (int i = 0; i < sides.length; i++) {
                r += sides[i];
            }
            return r;
        }
        else return 0.0;
    }

    public static double calc(Circle c) {
        if (c != null) {
            return PI * 2 * c.getR();
        }
        else return 0.0;
    }
}
