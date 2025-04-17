public class Triangle extends Shape{

    public Triangle(double a,double b, double c)
    {
        super(a,b,c);
    }
    @Override
    public double calcPerimeter() {
        double [] s=getSides();
        return s[0]+s[1]+s[2];
    }

    @Override
    public boolean equalSides() {
        double [] s=getSides();
        return s[0]==s[1]&&s[0]==s[2];
    }
}
