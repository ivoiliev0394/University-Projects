public abstract class Shape {
    private  double[] sides;
    public  Shape(double ... a){
        sides=a;
    }

    public double[] getSides() {
        return sides;
    }
    public abstract  double calcPerimeter();
    public  abstract  boolean equalSides();
}
