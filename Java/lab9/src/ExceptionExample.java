public class ExceptionExample
{
    private  int length;
    public ExceptionExample(){}
    public ExceptionExample(int l)throws Exception
    {
        if(l>=0)
            length=l;
        else {
            throw new Exception("Negative length");
        }
    }

    public int getLength() {
        return length;
    }

    public void setLength(int length) throws Exception {
        if (length >= 0)
            this.length = length;
        else {
            throw new Exception("Negative length");
        }
    }
}
