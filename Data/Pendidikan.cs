using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen
{
    public class P
    {
        readonly string nama;
        readonly int id;

        public P(string nama, int id)
        {
            this.nama = nama;
            this.id = id;
        }

        public string Nama
        {
            get
            {
                return nama;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
    }
    public static class Pendidikan
    {
        public static List<P> Data = new List<P>()
        {
            new P("SMP atau setingkat", 1), new P("SMA atau setingkat", 2),
            new P("S1 atau setingkat", 3), new P("S2 atau setingkat", 4)
        };
    }
}
