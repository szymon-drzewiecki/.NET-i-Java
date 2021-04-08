using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie2;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.Entity;




namespace Zadanie2GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private async void button1_Click(object sender, EventArgs e)
        {
            var context = new KlasaGlowna();
            string date_string = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string currency = listBox1.GetItemText(listBox1.SelectedItem);


            var ifExists = new List<Dane>();
            ifExists = context.ZestawyDanych.Where(x => x.date == date_string).ToList<Dane>();
            if (ifExists.Count != 0)
            {
                textBox1.Text = WriteByDay(context, date_string, currency);
            }
            else
            {
                textBox1.Text = "przed pobraniem";
                string call = "http://openexchangerates.org/api/historical/" + date_string + ".json?app_id=23e326842d4044d1a971b4fb0359c5a3";
                HttpClient httpClient = new HttpClient();
                string json = await httpClient.GetStringAsync(call);
                textBox1.Text = json;
                Dane obiektKlasy = JsonConvert.DeserializeObject<Dane>(json);
                obiektKlasy.date = date_string;
                context.ZestawyDanych.Add(obiektKlasy);
                context.SaveChanges();
                textBox1.Text = WriteByDay(context, date_string, currency);



            }
        }




        string WriteAll(KlasaGlowna context, string currency, string date_of_data)
        {
            string retString = "";
            var allDownloaded = context.ZestawyDanych.Where(d => d.date == date_of_data).ToList<Dane>();
            foreach (var d in allDownloaded)
            {
                /*
                if (currency == "EUR")
                retString += d.date + " " + "EUR:" + (d.rates.EUR).ToString();
                else if (currency == "PLN")
                retString += d.date + " " + "PLN:" + (d.rates.PLN).ToString();
                */



                retString = d.date + "       " + (d.rates.PLN).ToString() + Environment.NewLine;



                /*
                Console.WriteLine("Dane dla dnia: " + d.date);
                Console.WriteLine("PLN: {0}", d.rates.PLN);
                Console.WriteLine("EUR: {0}", d.rates.EUR);
                Console.WriteLine("BTC: {0}", d.rates.BTC);
                Console.WriteLine("COP: {0}", d.rates.COP);
                */



            }
            return retString;
        }


        string WriteByDay(KlasaGlowna context, string date_of_data, string currency)
        {
            string retString = "";
            var justDownloaded = context.ZestawyDanych.Where(d => d.date == date_of_data).ToList<Dane>();

            if (currency == "PLN")
                retString = justDownloaded[0].date + "   PLN: " + (justDownloaded[0].rates.PLN).ToString() + Environment.NewLine;
            else if (currency == "EUR")
                retString = justDownloaded[0].date + "   EUR: " + (justDownloaded[0].rates.EUR).ToString() + Environment.NewLine;
            else if (currency == "BTC")
                retString = justDownloaded[0].date + "   BTC: " + (justDownloaded[0].rates.BTC).ToString() + Environment.NewLine;
            else if (currency == "COP")
                retString = justDownloaded[0].date + "   COP: " + (justDownloaded[0].rates.COP).ToString() + Environment.NewLine;

            return retString;
        }

        public class KlasaGlowna : DbContext
        {
            public virtual DbSet<Dane> ZestawyDanych { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}