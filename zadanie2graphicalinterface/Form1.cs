using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.Entity;
using Zadanie2;

namespace zadanie2graphicalinterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var context = new KlasaGlowna();
            string date_string = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var checkIfExists = new List<Dane>();
            checkIfExists = context.ZestawyDanych.Where(x => x.date == date_string).ToList<Dane>();
            if (checkIfExists.Count != 0)
            {
                string call = "http://openexchangerates.org/api/historical/" + date_string + ".json?app_id=23e326842d4044d1a971b4fb0359c5a3";
                Task<string> Task = LoadJSON(call);
                string json = Task.Result;
                Dane obiektKlasy = JsonConvert.DeserializeObject<Dane>(json);
                obiektKlasy.date = date_string;
            }
            else
            {

            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void CreateMyDatePicker()
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.MaxDate = DateTime.Today;
        }
        static async Task<string> LoadJSON(string call)
        {
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(call);
            return json;
        }

        public class KlasaGlowna : DbContext
        {
            public virtual DbSet<Dane> ZestawyDanych { get; set; }
        }
    }
}
