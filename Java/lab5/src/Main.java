class  A{
    int num;
    public A()
    {
        this(0);
        System.out.println("A() called");
    }
    public A(int a){
        this.num=a;
    }
    public  void MyMethod(){
        System.out.println("A MyMethod() called");
    }
}
class B extends A{
    public B()
    {
        super(10);
        System.out.println("B() called");
    }
    public  void MyMethod(){
        super.MyMethod();
        System.out.println("A MyMethod() called");
    }
}
public class Main
{
    public static void main(String[] args)
    {
        /*
        A a=new A();//A() called
        B b=new B();//A() called , B() called
        b.MyMethod();
        System.out.println(b instanceof A);
        System.out.println(a instanceof B);
        b.num=50;*/
        Car car=new Car("AUDI","Q9");
        car.PrintInfo();
        MotorCycle motorCycle=new MotorCycle("Kawasaki","Ninja");
        motorCycle.setDriveShaft(true);
        motorCycle.PrintInfo();
    }
}