using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj seed losowania:");
            int Z = Convert.ToInt32(Console.ReadLine());
            Plecak plecaczek = new Plecak(50);
            Algorytmy algorytm = new Algorytmy(Z,10); // Algorytmy(seed, iloscPrzedmiotow) <- konstruktor
            List<Przedmiot> listaPrzedmiotow = algorytm.generujPrzedmioty();

            foreach (var przedmiot in listaPrzedmiotow)
            {
                przedmiot.WypiszPrzedmioty();
            }
            algorytm.sortujPlecak(listaPrzedmiotow);
            plecaczek.DodawaniePrzedmiotowDoPlecaka(listaPrzedmiotow);
            plecaczek.wypiszPlecak();

            Console.Read(); // dodane aby aplikacja się nie zamknęła 
        }
    }
}
