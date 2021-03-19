﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ziarno = Convert.ToInt32(textSeed.Text);
            int pojemnoscPlecaka = Convert.ToInt32(textCapacity.Text);
            int liczbaPrzedmiotow = Convert.ToInt32(textNoItems.Text);
            Plecak plecaczek = new Plecak(pojemnoscPlecaka);
            Algorytmy algorytm = new Algorytmy(ziarno, liczbaPrzedmiotow); // Algorytmy(seed, iloscPrzedmiotow) <- konstruktor
            List<Przedmiot> listaPrzedmiotow = algorytm.generujPrzedmioty();

            var wypiszPrzedmioty = new string('');
            foreach (var przedmiot in listaPrzedmiotow)
            {
                przedmiot.WypiszPrzedmioty();
            }
            


            algorytm.sortujPlecak(listaPrzedmiotow);
            plecaczek.DodawaniePrzedmiotowDoPlecaka(listaPrzedmiotow);

        }


    }
}
