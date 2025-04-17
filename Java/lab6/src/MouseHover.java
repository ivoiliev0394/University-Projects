import java.util.Random;
public class MouseHover implements  MovableMouse{
    private  int x,y;
    public int getX() {
        return x;
    }
    public int getY() {
        return y;
    }
    private  final int Height,Width;
    public MouseHover(int h, int w) {
        Random r=new Random();
        this.Height = h;
        this.Width = w;
        this.x=r.nextInt(w);
        this.y=r.nextInt(h);
    }

    public int getHeight() {
        return Height;
    }

    public int getWidth() {
        return Width;
    }

    @Override
    public boolean moveUp() {
        if(y<0) return false;
        else {y--; return true;}
    }

    @Override
    public boolean moveDown() {
        if(y>getHeight()) return false;
        else {y++; return true;}
    }

    @Override
    public boolean moveLeft() {
        if(x<0) return false;
        else {x--; return true;}
    }

    @Override
    public boolean moveRight() {
        if(x>getWidth()) return false;
        else {x++; return true;}
    }
}

