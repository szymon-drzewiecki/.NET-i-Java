package Zadanie1;

import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
import javax.swing.*;
import java.awt.*;

public class Main{
    public static void main(String[] args){
    int seed = 21231;
    int numberOfItems = 10;
    ArrayList<Item> listOfItems = new ArrayList<Item>();
    Backpack plecak = new Backpack(50 );

    RandomNumberGenerator rng = new RandomNumberGenerator(seed);

    for (int i = 0; i < numberOfItems; i++){
        listOfItems.add(new Item(i+1, rng.nextInt(1,29), rng.nextInt(1,29)));
        }

    plecak.AddItems(listOfItems);
    System.out.print(plecak.writeBackpack());
    }

}