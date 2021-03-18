using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
}
