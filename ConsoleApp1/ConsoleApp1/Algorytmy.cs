using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   public class Algorytmy
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
}
