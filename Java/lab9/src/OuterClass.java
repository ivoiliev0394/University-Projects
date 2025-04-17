public class OuterClass {
    private int A;
    private int outerVal;
    public void setA(int a) {
        A = a;
    }

    public int getA() {
        return A;
    }
    public  int getOuterVal(){return outerVal;}
    public OuterClass(int a){
        A=a;
    }
    class InnerClass
    {
        private  int A;
        private int B;

        public int getA() {
            return A;
        }

        public void setA(int a) {
            A = a;
        }

        public int getB() {
            return B;
        }

        public void setB(int b) {
            B = b;
        }
        public InnerClass(int a, int b)
        {
            A=a;B=b;
        }
        public  void setOuterVal(int v){ outerVal=v;}
    }
    static class StaticInnerClass{
        private int A;

        public int getA() {
            return A;
        }

        public void setA(int a) {
            A = a;
        }
        public StaticInnerClass(int a)
        {
           A=a;
        }
    }
}
