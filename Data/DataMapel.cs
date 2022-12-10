using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen.Data
{
    public class Mapel
    {
        public int ID;
        public string Name;
        public Mapel(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
    public class DataMapel
    {
        public static List<Mapel> DaftarMapel = new List<Mapel>()
        {
            new Mapel(1, "Bahasa Indonesia"),
            new Mapel(2, "Bahasa Inggris"),
            new Mapel(3, "IPA"),
            new Mapel(4, "IPS"),
            new Mapel(5, "Matematika"),
            new Mapel(6, "PKN")
        };
    }
}
