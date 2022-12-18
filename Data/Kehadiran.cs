using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen
{
    public class K
    {
        readonly string nama;
        readonly int id;

        public K(string nama, int id)
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

    public static class Kehadiran
    {
        public static List<K> Data = new List<K>
        {
            new K("Hadir", 1), new K("Absen", 2), new K("Izin", 3)
        };
    }
}
