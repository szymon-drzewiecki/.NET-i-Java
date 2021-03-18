using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
}
