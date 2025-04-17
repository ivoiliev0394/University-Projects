import java.util.Random;

public class zad_02 {

    public static void main(String[] args) {
        MouseMover mm = new MouseMover(800, 600);
        System.out.printf("Screen size is w:%d h:%d\n", mm.getWidth(), mm.getHeight());
        System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        while (mm.moveUp() && mm.moveLeft()) {
            System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        }
        System.out.println("Changing directions...");
        while (mm.moveDown() && mm.moveRight()) {
            System.out.printf("Mouse position is X:%d Y:%d\n", mm.getX(), mm.getY());
        }
    }
}

interface MovableMouse {
    public boolean moveUp();
    public boolean moveDown();
    public boolean moveLeft();
    public boolean moveRight();
}

class MouseMover implements MovableMouse {

    private int x, y;
    private final int screenWidth, screenHeight;

    public MouseMover(int w, int h) {
        screenWidth = w;
        screenHeight = h;
        Random r = new Random();
        x = r.nextInt(w) + 1;
        y = r.nextInt(h) + 1;
    }

    public void randomizePosition() {
        Random r = new Random();
        x = r.nextInt(screenWidth);
        y = r.nextInt(screenHeight);
    }

    public int getWidth() {
        return screenWidth;
    }
    public int getHeight() {
        return screenHeight;
    }
    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    @Override
    public boolean moveUp() {
        if (y > 0) {
            y--;
            return true;
        }
        else
            return false;
    }

    @Override
    public boolean moveDown() {
        if (y < screenHeight) {
            y++;
            return true;
        }
        else
            return false;
    }

    @Override
    public boolean moveLeft() {
        if (x > 0) {
            x--;
            return true;
        }
        else
            return false;
    }

    @Override
    public boolean moveRight() {
        if (x < screenWidth) {
            x++;
            return true;
        }
        else
            return false;
    }
}