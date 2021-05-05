using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Models
{
    public class Dane
    {
        public int ID { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public float PLN { get; set; }
        public float EUR { get; set; }
        public float BTC { get; set; }
        public float COP { get; set; }


    }


}
