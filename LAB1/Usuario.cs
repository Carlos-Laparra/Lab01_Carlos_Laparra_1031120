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

        public List<string> companies { get; set; }

        public List<Carta> carta = new List<Carta>();

        public int codificado = 0;


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
        public static int Compare_DPI_byLength(Usuario j, Usuario p)
        {
            int length = j.dpi.Length;
            int r = j.dpi.CompareTo(p.dpi.Substring(0,length));
            return r;
        }
    }
}
