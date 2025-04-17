import java.util.ArrayList;

public class Polygon {
    double[] sides;
    public void setSides(double[] sides) {
        this.sides = sides;
    }
    public double[] getSides() {
        return sides;
    }
    int numSide;
    public int getNumSide() {
        return numSide;
    }
    public Polygon(int sides){
        numSide=sides;

    }
}
