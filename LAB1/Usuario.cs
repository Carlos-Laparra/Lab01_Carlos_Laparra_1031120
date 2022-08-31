using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Usuario
    {
        public string name { get; set; }
        public string dpi { get; set; }
        public DateTime datebirth { get; set; }
        public string address { get; set; }


        public static int Compare_DPI(Usuario x, Usuario y)
        {
            int r = x.dpi.CompareTo(y.dpi);
            return r;
        }
        public static int Compare_Name(Usuario w, Usuario z)
        {
            int aux = w.name.CompareTo(z.name);
            return aux;
        }
    }
}
