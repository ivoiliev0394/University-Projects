public abstract class Vehicle {
    private String brand,model;

    public String getBrand() {
        return brand;
    }

    public String getModel() {
        return model;
    }
    public  Vehicle(String b,String m)
    {
        brand=b;model=m;
    }
    public  abstract  void run();
}
