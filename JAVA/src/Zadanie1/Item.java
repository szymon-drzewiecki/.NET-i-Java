package Zadanie1;

public class Item {
    private int weight;
    int value;
    int itemNr;

    public Item (int x, int y, int z){
        itemNr = x;
        value = y;
        weight = z;
    }

    public int getValue()
    {
        return this.value;
    }


    public int getWeightt(){return this.weight;}

    public int getItemNr()
    {
        return this.itemNr;
    }

    public String writeItem(){
        String string = String.format("Numer przedmiotu: %2d, wartość: %2d, waga: %2d \r\n", itemNr, value, weight);
        return string;
    }

}
