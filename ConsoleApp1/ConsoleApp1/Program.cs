using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Algorytmy
{
    RandomNumberGenerator rng;
    int iloscPrzedmiotow;
    public Algorytmy(int Z, int Y) 
    {
        this.rng = new RandomNumberGenerator(Z);
        this.iloscPrzedmiotow = Y;
    }
    public void sortujPlecak(List<Przedmiot> listaPrzedmiotow)
    {
        listaPrzedmiotow.Sort(delegate (Przedmiot x, Przedmiot y)
        {
            return x.getvalueToWeight().CompareTo(y.getvalueToWeight());
        });

        listaPrzedmiotow.Reverse();
    }

    public List<Przedmiot> generujPrzedmioty()
    {
        List<int> values = new List<int>();
        List<int> weight = new List<int>();
        List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>();


        for (int i = 0; i < this.iloscPrzedmiotow; i++)
        {
            values.Add(rng.nextInt(1, 29));
            weight.Add(rng.nextInt(1, 29));
        }

        for (int i = 0; i < this.iloscPrzedmiotow; i++)
        {
            listaPrzedmiotow.Add(new Przedmiot(values[i], weight[i], i + 1));
        }
        return listaPrzedmiotow;
    }
}
public class Przedmiot
{
    int v; //wartość
    int w; //waga
    int numerPrzedmiotu;
    float valueToWeight; // wartość do wagi
    bool czyMiesci;

    public Przedmiot(int v, int w, int numerPrzedmiotu)
    {
        this.v = v;
        this.w = w;
        this.numerPrzedmiotu = numerPrzedmiotu;
        this.czyMiesci = false;
        this.valueToWeight = (float)v / (float)w;
    }
    //test commita
    public int getv()
    {
        return this.v;
    }

    public int getw()
    {
        return this.w;
    }

    public float getvalueToWeight()
    {
        return this.valueToWeight;
    }

    public void setczyMiesci(bool x)
    {
        this.czyMiesci = x;
    }

    public void WypiszPrzedmioty()
    {
        Console.WriteLine(this.numerPrzedmiotu + ". value to weight:" + this.valueToWeight.ToString("f2") + " value: " + this.v + " weight: " + this.w);
    }

}
public class Plecak
{
    int C; // capacity
    int usedSpace;
    List<Przedmiot> przedmiotyWPlecaku;

    public Plecak()
    {
        this.C = 50;
        this.usedSpace = 0;
        this.przedmiotyWPlecaku = new List<Przedmiot>();
    }

    public bool sprawdzMiejsce(Przedmiot x)
    {
        if (this.usedSpace + x.getw() > this.C) return false;
        else return true;
    }

    public void DodawaniePrzedmiotowDoPlecaka(List<Przedmiot> x)
    {
        foreach (Przedmiot y in x)
        {
            if (this.sprawdzMiejsce(y) == true)
            {
                this.przedmiotyWPlecaku.Add(y);
                this.usedSpace += y.getw();
                y.setczyMiesci(true);
            }
        }
    }

    public void wypiszPlecak()
    {
        Console.WriteLine("\n \nPrzedmioty które został umieszczone w plecaku:");
        foreach (var x in this.przedmiotyWPlecaku)
        {
                x.WypiszPrzedmioty();
        }
        Console.WriteLine($"Całkowita waga przedmiotów {this.usedSpace}");
        
    }

    public List<Przedmiot> getprzedmiotyWPlecaku()
    {
        return this.przedmiotyWPlecaku;
    }

    public int getusedSpace()
    {
        return this.usedSpace;
    }
}







namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Plecak plecaczek = new Plecak();
            Algorytmy algorytm = new Algorytmy(1,10);
            List<Przedmiot> listaPrzedmiotow = algorytm.generujPrzedmioty();


            foreach (var przedmiot in listaPrzedmiotow)
            {
                przedmiot.WypiszPrzedmioty();
            }

            algorytm.sortujPlecak(listaPrzedmiotow);
            plecaczek.DodawaniePrzedmiotowDoPlecaka(listaPrzedmiotow);
            plecaczek.wypiszPlecak();


            Console.Read();
        }
    }
}
