namespace Ibuprofen
{
    public static class Database
    {
        public static class Table
        {
            public static readonly string LOGIN = "tbl_user";
            public static readonly string STUDENT = "tbl_siswa";
            public static readonly string STUDENT_DATA = "tbl_data_siswa";
            public static readonly string SCORE = "tbl_nilai";
            public static readonly string GRADE = "tbl_tingkat";
            public static readonly string COURSE = "tbl_mapel";
            public static readonly string ATTENDANCE = "tbl_absensi";
            public static readonly string STAFF = "tbl_staff";
            public static readonly string STAFF_DATA = "tbl_data_staff";
        }

        public static class Relation
        {
            public static readonly string STUDENT_DATA = "hub_siswa_data";
            public static readonly string STUDENT_SCORE = "hub_siswa_nilai";
        }
    }
}
