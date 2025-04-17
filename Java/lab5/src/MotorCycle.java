public class MotorCycle extends Vehicle {
    String brand;
    public String getBrand() {
        return brand;
    }
    public void setBrand(String brand) {
        this.brand = brand;
    }
    String model;
    public String getModel() {
        return model;
    }
    public void setModel(String model) {
        this.model = model;
    }

    boolean DriveShaft;
    public void setDriveShaft(boolean driveShaft) {
        DriveShaft = driveShaft;
    }
    public boolean isDriveShaft() {
        return DriveShaft;
    }


    public MotorCycle(String b, String m){
        super(0,2);
        brand=b;model=m;
    }
    public  void PrintInfo(){
        System.out.println("*******************");
        System.out.println("Brand: "+getBrand());
        System.out.println("Model: "+getModel());
        System.out.println("DriveShaft: "+isDriveShaft());
        System.out.println("Doors: "+getDoors());
        System.out.println("Wheels: "+getWheels());
        System.out.println("*******************");
    }
}
