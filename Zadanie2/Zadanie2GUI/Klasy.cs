using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2GUI
{
    public class Dane
    {
        public string date { get; set; }
        public int Id { get; set; }
        public int timestamp { get; set; }
        public Przeliczniki rates { get; set; }

    }

    public class Przeliczniki
    {
        public float PLN { get; set; }
        public float EUR { get; set; }
        public float BTC { get; set; }
        public float COP { get; set; }
    }
}
