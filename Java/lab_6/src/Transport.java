public abstract class Transport {
    private String name;

    public String getName() {
        return name;
    }

    public Transport(String n){
        name=n;
    }
    abstract  void motion();
    abstract  void poweredBy();
    abstract  boolean isPublicTransport();
}
