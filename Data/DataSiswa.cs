using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen.Data
{
    class Siswa
    {
        public int NISN { get; set; }
        public string Nama { get; set; }
        public int JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public string TTL { get; set; }
        public int Tingkat { get; set; }
        public string Kelas { get; set; } // A-C
        public Siswa(
            int nisn, 
            string nama,
            int isMale,
            int tingkat = 11,
            string kelas = "A",
            string alamat = "Jl. MH Thamrin No 5",
            string noTelp = "62812345678",
            string ttl = "Medan, 1 Januari 2005"
            )
        {
            NISN = nisn;
            Nama = nama;
            JenisKelamin = isMale;
            Tingkat = tingkat;
            Kelas = kelas;
            Alamat = alamat;
            NoTelp = noTelp;
            TTL = ttl;
        }
    }

    class Nilai
    {
        public int NISNSiswa { get; set; } // 1001-1012
        public int IDMapel { get; set; } // 1-6
        public short Ujian { get; set; }
        public short? Remedial { get; set; }
        public short Tugas { get; set; }
        public short? TugasPlus { get; set; }
        public Nilai (int nisn, int idMapel = 5)
        {
            NISNSiswa = nisn;
            IDMapel = idMapel;
            Ujian = 75;
            Tugas = 80;
        }
        
        public Nilai (int nisn, short ujian, short tugas, int idMapel = 4)
        {
            NISNSiswa = nisn;
            IDMapel = idMapel;
            Ujian = ujian;
            Tugas = tugas;
        }
    }
    
    class DataSiswa
    {
        public static List<Nilai> DaftarNilai = new List<Nilai>()
        {
            new Nilai(1001, 6),
            new Nilai(1002, 6),
            new Nilai(1003, 6),
            new Nilai(1004, 6),
            new Nilai(1005, 1),
            new Nilai(1006, 1),
            new Nilai(1007, 1),
            new Nilai(1008, 1),
            new Nilai(1009, 2),
            new Nilai(1010, 42, 77),
            new Nilai(1011, 82, 55),
            new Nilai(1012, 92, 100)
        };
        public static List<Siswa> DaftarSiswa = new List<Siswa>()
        {
            new Siswa(1001, "Tono", 1, 10, "A"),
            new Siswa(1002, "Bono", 1, 11, "B"),
            new Siswa(1003, "Dono", 1, 10, "B"),
            new Siswa(1004, "Yuno", 1, 10, "C"),
            new Siswa(1005, "Rano", 1, 12, "B"),
            new Siswa(1006, "Tano", 1, 11, "C"),
            new Siswa(1007, "Wono", 1, 11),
            new Siswa(1008, "Bono", 1, 12, "C"),
            new Siswa(1009, "Mono", 1, 12),
            new Siswa(1010, "Bonar Simatupang", 1, 12),
            new Siswa(1011, "Andi Kevin Ang", 1, 12),
            new Siswa(1012, "Liliani", 0, 12),
        };
    }
}
