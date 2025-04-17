import java.util.Arrays;

public class Tetragon extends Shape{
    public Tetragon(double a,double b,double c,double d)
    {
        super(a,b,c,d);
    }
    @Override
    public double calcPerimeter() {
        double [] s=getSides();
        return Arrays.stream(s).sum();
    }

    @Override
    public boolean equalSides() {
        double [] s=getSides();
        return s[0]==s[1]&&s[0]==s[2]&&s[0]==s[3];
    }
}
