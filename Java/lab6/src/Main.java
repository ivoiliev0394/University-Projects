import java.awt.*;
import java.util.Random;

//------------------------INTERFACE---------------------------------
/*
* -задава функционалноста на един клас, но не и как ще се изпълни
* */
//------------------------------------------------------------------
interface  Drivable
{
    public int maxSpeed=140;
    public void stop();
    public void start();
    public void accelerate();
    public void decelerate();
}
//*********************************************************************
class  Car implements  Drivable
{
    private  int speed=0;
    private  boolean enginestarterd=false;
    public  Car(){}
    @Override
    public void stop() {
        for (int i = speed; i >0 ; i--) {
            System.out.print(i+" ");
        }
        System.out.println("\nCar stopped");
        enginestarterd=false; speed=0;
    }
    @Override
    public void start() {
        System.out.println("Engine started");
        enginestarterd=true;
    }
    @Override
    public void accelerate() {
        if(enginestarterd) speed++;
        else System.out.println("Start engine first");
    }
    @Override
    public void decelerate() {
        if (speed > 0) {
            speed -= 5;
            System.out.println("Decelerating " + speed + "km/h");
        }
        else System.out.println("Car is stationary.");
    }
}
//==================================================
class Train implements Drivable {
    private boolean electricityOn = false;
    private int speed = 0;
    public Train() { }

    @Override
    public void start() {
        electricityOn = true;
        System.out.println("Electricity is on.");
    }

    @Override
    public void stop() {
        for (;speed > 0; speed--) {
            System.out.println("Stopping " + speed + " km/h");
        }
        electricityOn = false;
        System.out.println("Electricity is off.");
    }

    @Override
    public void accelerate() {
        speed = speed + 10;
        System.out.println("Accelerating " + speed + " km/h");
    }

    @Override
    public void decelerate() {
        if (speed > 0) {
            speed = speed - 10;
            if (speed < 0)
                speed = 0;
        }
        System.out.println("Accelerating " + speed + " km/h");
    }
}

//============================================================================
public class Main {
    public static void main(String[] args) {

        Rectangle r=new Rectangle(44.44,66.66);
        r.calc();
        /*
        MouseHover mm = new MouseHover(800, 600);
        System.out.printf("Screen size is w:%d h:%d\n", mm.getWidth(), mm.getHeight());
        System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        while (mm.moveUp() && mm.moveLeft()) {
            System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        }
        System.out.println("Changing directions...");
        while (mm.moveDown() && mm.moveRight()) {
            System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        }
        */
/*
            Car car = new Car();
            car.accelerate();
            car.start();
            for (int i = 0; i < 50; i++) {
                car.accelerate();
            }
            car.decelerate();
            car.stop();

            System.out.println();

            System.out.println("Train:");
            Train t = new Train();
            t.start();
            for (int i = 0; i < 20; i++)
                t.accelerate();
            for (int i = 0; i < 5; i++)
                t.decelerate();
            t.stop();*/

    }
}


