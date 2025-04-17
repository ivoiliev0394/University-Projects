public class Vehicle {
    private  int doors;
    private  int wheels;

    public int getDoors() {
        return doors;
    }
    public void setDoors(int doors) {
        this.doors = doors;
    }

    public int getWheels() {
        return wheels;
    }
    public void setWheels(int wheels) {
        this.wheels = wheels;
    }
    public Vehicle()
    {
        this(0,0);
    }
    public Vehicle(int d,int w)
    {
        doors=d;wheels=w;
    }
}
