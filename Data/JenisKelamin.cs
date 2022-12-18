using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen
{
    public class JK
    {
        readonly string nama;
        readonly int id;

        public JK(string nama, int id)
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

    public static class JenisKelamin
    {
        public static List<JK> Data = new List<JK>()
        {
            new JK("Laki-laki", 1), new JK("Perempuan", 0)
        };
    }
}
