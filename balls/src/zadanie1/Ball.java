package zadanie1;
import java.awt.*;
import javax.swing.*;
import java.util.ArrayList;
import java.util.Random;


class Ball extends JPanel implements Runnable
{
    Random random = new Random();
    private boolean isGoingRight;
    private boolean isGoingUp;
    private int x, y, deltaX, deltaY;
    private int sizeX = 800, sizeY = 520;
    private String colour;
    private int size;

    public Ball(String colour, int size)
    {
        this.isGoingRight = random.nextBoolean();
        this.isGoingUp = random.nextBoolean();
        this.deltaX = random.nextInt(15);
        this.deltaY = random.nextInt(15);
        this.colour = colour;
        this.size = size;
        this.x = 400;
        this.y = 240;

        setOpaque(false);
        setPreferredSize(new Dimension(sizeX, sizeY));
    }
    public void run()
    {
        while ( true ) {

            try {
                Thread.sleep( 20 );
            }catch ( InterruptedException exception ) {
                System.err.println( exception );
            }

            if (isGoingRight)
                x += deltaX;
            else
                x -= deltaX;

            if (isGoingUp)
                y += deltaY;
            else
                y -= deltaY;

            if (y <= 0) {
                isGoingUp = true;
            }else if ( y >= sizeY - this.size ) {
                isGoingUp = false;
            }

            if ( x <= 0) {
                isGoingRight = true;
            }else if ( x >= sizeX - this.size ) {
                isGoingRight = false;
            }
            repaint();
        }
    }


    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);

        if (this.colour == "green")
        {
            g.setColor( Color.green );
        }else if(this.colour == "red")
        {
            g.setColor( Color.red );
        }else if(this.colour == "blue"){
            g.setColor( Color.blue );
        }

        g.fillOval( x, y, this.size, this.size );
    }

    static class BouncingBalls extends JFrame {

        public BouncingBalls() {

            Random random = new Random();
            setResizable(false);
            setSize(800, 520);
            String[] ballColours = {"green", "red", "blue"};
            int[]    ballSizes = {24, 37, 45, 19, 58, 63, 30};
            int numberOfBalls = 25;

            ArrayList<Ball> listOfBalls = new ArrayList<>();
            for (int i = 0; i < numberOfBalls; ++i){
                listOfBalls.add(i, new Ball(ballColours[random.nextInt(3)], ballSizes[random.nextInt(7)]));
            }


            for (int i = 0; i < numberOfBalls - 1; ++i){
                listOfBalls.get(i).add(listOfBalls.get(i+1));
            }

            getContentPane().add(listOfBalls.get(0));
            setVisible(true);

            ArrayList <Thread> listOfThreads = new ArrayList<>();
            for (int i = 0; i < numberOfBalls; ++i) {
                listOfThreads.add(i, new Thread(listOfBalls.get(i)));
            }

            for (int i = 0; i < numberOfBalls; ++i){
                listOfThreads.get(i).start();
            }

        }
    }
}