package zadanie1;

import javax.swing.*;

class BouncingBalls extends JFrame {

    public BouncingBalls() {

        setResizable(false);
        setSize(800, 480);

        Ball ball1 = new Ball();
        Ball ball2 = new Ball();
        Ball ball3 = new Ball();

        ball1.add(ball2);
        ball2.add(ball3);
        getContentPane().add(ball1);
        setVisible(true);
        Thread x = new Thread(ball1);
        Thread y = new Thread(ball2);
        Thread z = new Thread(ball3);

        x.start();
        y.start();
        z.start();
    }
}

public class Main {

    public static void main(String[] args) {
        new BouncingBalls();
    }
}