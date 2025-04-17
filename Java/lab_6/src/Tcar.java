public class Tcar extends  Transport{
    private  int numWheels;

    public int getNumWheels() {
        return numWheels;
    }

    public Tcar(String n, int w) {
        super(n);
        numWheels=w;
    }

    @Override
    void motion() {
        System.out.println(getName()+" "+getClass()+"has and move with "+getNumWheels()+" wheels");
    }

    @Override
    void poweredBy() {
        System.out.println(getClass()+"is powered by engine)");
    }

    @Override
    boolean isPublicTransport() {
        return false;
    }
}
