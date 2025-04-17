package com.shape;

public class Polygon {
    private double[] sides;

    public Polygon(double ... s) {
        sides = s;
    }

    public double[] getSides() {
        return sides;
    }

    public void setSides(double[] sides) {
        this.sides = sides;
    }
}
