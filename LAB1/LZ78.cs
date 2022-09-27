using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class LZ78
    {
        struct Pair
        {
            public Pair(ushort position, byte next)
            {
                this.position = position;
                this.next = next;
            }
            public ushort position;
            public byte next;
        }

        public byte[] Encode(byte[] content)
        {
            Dictionary<string, ushort> dict = new Dictionary<string, ushort>() { { "", 0 } };
            List<Pair> pairs = new List<Pair>();
            string prefijo = "";
            for (int i = 0; i < content.Length; i++)
            {
                if (dict.ContainsKey(prefijo + (char)content[i]))
                {
                    prefijo += (char)content[i];
                }
                else
                {
                    if (dict.Count <= 65535) dict.Add(prefijo + (char)content[i], (UInt16)dict.Count);
                    pairs.Add(new Pair(dict[prefijo], content[i]));
                    prefijo = "";
                }
            }
            if (!string.IsNullOrEmpty(prefijo))
            {
                byte last_byte = (byte)prefijo[prefijo.Length - 1];
                prefijo = prefijo.Substring(0, prefijo.Length - 1);
                pairs.Add(new Pair(dict[prefijo], last_byte));
            }
            byte[] result = new byte[pairs.Count * 3];
            for (int i = 0, j = 0; i < pairs.Count; i++, j += 3)
            {
                result[j] = (byte)pairs[i].position;
                result[j + 1] = (byte)(pairs[i].position >> 8);
                result[j + 2] = pairs[i].next;
            }
            return result;
        }

        public byte[] Decode(byte[] content, string dpi)
        {
            List<string> dict = new List<string>() { "" };
            List<byte> result = new List<byte>();
            for (int i = 0; i < content.Length; i += 3)
            {
                ushort position = (UInt16)(content[i] | content[i + 1] << 8);
                result.AddRange((dict[position] + (char)content[i + 2]).Select(c => (byte)c).ToArray());
                if (dict.Count <= 65535) dict.Add(dict[position] + (char)content[i + 2]);
            }
            return result.ToArray();
        }

        public string separeDpi(string cadenaDec, string dpi)
        {
            string aux = cadenaDec;
            string[] charsToRemove = new string[] { dpi };
            foreach (var c in charsToRemove)
            {
                aux = aux.Replace(c, string.Empty);
            }
            
            
            return aux;
        }
    }
}
