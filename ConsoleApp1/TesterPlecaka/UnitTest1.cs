using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
using System.Collections.Generic;

namespace TesterPlecaka
{
    [TestClass]
    public class TestyPlecaka
    {
        [TestMethod]
        public void CzyZwracaPusteRozwiazanieGdyZadenPrzedmiotNieSpelniaOgraniczen()
        {
            var przedmioty = new List<Przedmiot>();
            przedmioty.Add(new Przedmiot(1, 51, 1));
            przedmioty.Add(new Przedmiot(1, 60, 2));
            przedmioty.Add(new Przedmiot(1, 75, 3));

            var plecaczek = new Plecak();
            plecaczek.DodawaniePrzedmiotowDoPlecaka(przedmioty);
            Assert.IsTrue(plecaczek.getprzedmiotyWPlecaku().Count == 0);
        }

        [TestMethod]
        public void CzyZwracaPrzynajmniejJedenElementGdyJedenPrzedmiotSpelniaOgraniczenia()
        {
            var przedmioty = new List<Przedmiot>();
            przedmioty.Add(new Przedmiot(1, 1, 1));
            przedmioty.Add(new Przedmiot(1, 1000, 2));

            var plecaczek = new Plecak();
            plecaczek.DodawaniePrzedmiotowDoPlecaka(przedmioty);
            Assert.IsNotNull(plecaczek.getprzedmiotyWPlecaku());
        }

        [TestMethod]
        public void CzyKolejnoscPrzedmiotowMaWplywNaZnalezioneRozwiazanie()
        {
            var przedmiot1 = new Przedmiot(1, 1, 1);
            var przedmiot2 = new Przedmiot(5, 25, 2);
            var przedmiot3 = new Przedmiot(5, 33, 3);
            var przedmioty = new List<Przedmiot>();
            var przedmioty1 = new List<Przedmiot>();
            przedmioty.Add(przedmiot1);
            przedmioty.Add(przedmiot2);
            przedmioty.Add(przedmiot3);

            przedmioty1.Add(przedmiot3);
            przedmioty1.Add(przedmiot2);
            przedmioty1.Add(przedmiot1);

            var plecaczek = new Plecak();
            var plecaczek1 = new Plecak();
            plecaczek.DodawaniePrzedmiotowDoPlecaka(przedmioty);
            plecaczek1.DodawaniePrzedmiotowDoPlecaka(przedmioty1);

            Assert.AreNotEqual(plecaczek, plecaczek1);
        }

        [TestMethod]
        public void SprawdzenieRozwiazaniaDlaKonkretnegoSeedu()
        {
            int expectedResult = 49; // zakodowany wynik spodziewany
            var values = new List<int>();
            var weight = new List<int>();
            var przedmioty = new List<Przedmiot>();
            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            int iloscPrzedmiotow = 5;
            var plecaczek = new Plecak();
            for (int i = 0; i < iloscPrzedmiotow; i++)
            {
                values.Add(rng.nextInt(1, 29));
                weight.Add(rng.nextInt(1, 29));
                przedmioty.Add(new Przedmiot(values[i], weight[i], i + 1));
            }

            przedmioty.Sort(delegate (Przedmiot x, Przedmiot y)
            {
                return x.getvalueToWeight().CompareTo(y.getvalueToWeight());
            });
            przedmioty.Reverse();

            plecaczek.DodawaniePrzedmiotowDoPlecaka(przedmioty);
            Assert.AreEqual(expectedResult, plecaczek.getusedSpace());
        }
    }
}