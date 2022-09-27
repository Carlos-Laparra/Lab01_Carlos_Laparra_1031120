using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Carta
    {
        public string key { get; set; }
        public string mensaje { get; set; }
        public  int codificado { get; set; }

        public List<int> comp = new List<int>();

        public static int Compare_DPI(Carta x, Usuario y)
        {
            int r = x.key.CompareTo(y.dpi);
            return r;
        }
    }
}
