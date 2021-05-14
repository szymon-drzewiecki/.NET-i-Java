package Zadanie1;

import java.util.ArrayList;

public class Backpack {
    int capacity;
    int usedSpace;
    ArrayList<Item> itemsInBackpack;
    int totalValue;

    public Backpack(int capacity)
    {
        this.capacity = capacity;
        this.usedSpace = 0;
        this.itemsInBackpack = new ArrayList<Item>();
        this.totalValue = 0;
    }

    public boolean isThereSpace(Item item)
    {
        if(this.usedSpace + item.getWeightt() > this.capacity) return false;
        else return true;
    }

    public void AddItems(ArrayList<Item> ListOfItems)
    {
        for (int i = 0; i < ListOfItems.size(); i++)
        {
            if(this.isThereSpace(ListOfItems.get(i)))
            {
                this.itemsInBackpack.add(ListOfItems.get(i));
                this.usedSpace += ListOfItems.get(i).getWeightt();
                this.totalValue += ListOfItems.get(i).getValue();
            }
        }
    }

    public String writeBackpack(){
        String string = "";
        for (Item przedmiot: itemsInBackpack){
            string = string + przedmiot.writeItem();
        }
        string = string + "Całkowita wartość plecaka: " + totalValue + "\r\nCałkowita waga plecaka: " + usedSpace;
        return string;
    }
}
