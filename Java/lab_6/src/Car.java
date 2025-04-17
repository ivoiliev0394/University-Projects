public class Car extends  Vehicle{
    public Car(String b, String m){
        super(b,m);
    }
    @Override
    public void run(){
        System.out.println(getBrand()+" "+getModel()+"  is running ok!");
    }
}
