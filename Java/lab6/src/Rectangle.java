public class Rectangle {
    private  double A,B;
    private Calculation c;
    public  Rectangle(double a,double b)
    {
        A=a;B=b;
    }
    private  double calc(double a,double b)
    {
        return a*b;
    }
    public void calc(){
        c=new Calculation() {
            @Override
            public double rectSurfaceCalc(double a, double b) {
                if(a>0&&b>0) return  calc(a,b);
                else  return  0.0;
            }
        };
        System.out.println(c.rectSurfaceCalc(A,B));
    }
}
