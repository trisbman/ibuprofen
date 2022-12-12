using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibuprofen
{
    public static class Database
    {
        public static class Table
        {
            public static readonly string STUDENT = "tbl_siswa";
            public static readonly string STUDENT_DATA = "tbl_data_siswa";
            public static readonly string STAFF = "tbl_staff";
            public static readonly string SCORE = "tbl_nilai";
            public static readonly string GRADE = "tbl_tingkat";
            public static readonly string COURSE = "tbl_mapel";
            public static readonly string ATTENDANCE = "tbl_absensi";
        }

        public static class Relation
        {
            public static readonly string STUDENT_DATA = "hub_siswa_data";
            public static readonly string STUDENT_SCORE = "hub_siswa_nilai";
        }
    }
}
