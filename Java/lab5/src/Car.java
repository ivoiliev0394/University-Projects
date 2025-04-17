public class Car extends Vehicle {
    String brand;
    private String getBrand() {
        return brand;
    }
    private void setBrand(String brand) {
        this.brand = brand;
    }
    String model;
    private String getModel() {
        return model;
    }
    private void setModel(String model) {
        this.model = model;
    }
    public Car(String b, String m){
        super(4,4);
        brand=b;model=m;
    }
    public Car(String b,String m,int w){
        super(4,w);
        brand=b;model=m;
    }
    public void PrintInfo()
    {
        System.out.println("*******************");
        System.out.println("Brand: "+getBrand());
        System.out.println("Model: "+getModel());
        System.out.println("Doors: "+getDoors());
        System.out.println("Wheels: "+getWheels());
        System.out.println("*******************");
    }
}
