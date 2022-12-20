using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ibuprofen.Database;

namespace Ibuprofen.ModulSiswa
{
    public partial class ModulReportSiswa : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;
        SqlDataAdapter adapter;

        readonly char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public ModulReportSiswa()
        {
            InitializeComponent();
        }

        private void ModulReportSiswa_Load(object sender, EventArgs e)
        {
            LoadData();

            // preselect
            cboKelasFilter.SelectedIndex = 0;
            DateTime dateTime = DateTime.Today;
            dateTimePicker2.MaxDate = dateTime;
            dateTimePicker2.Value = dateTime;
            dateTimePicker1.Value = new DateTime(dateTime.Year, dateTime.Month, 1);            
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                #region load data from db
                SqlCommand command = new SqlCommand("SELECT * FROM " + Table.GRADE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.GRADE);

                command = new SqlCommand("SELECT * FROM " + Table.STUDENT, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.STUDENT);

                command = new SqlCommand("SELECT * FROM " + Table.STUDENT_DATA, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.STUDENT_DATA);

                command = new SqlCommand("SELECT * FROM " + Table.SCORE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.SCORE);

                command = new SqlCommand("SELECT * FROM " + Table.COURSE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.COURSE);

                command = new SqlCommand("SELECT * FROM " + Table.ATTENDANCE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.ATTENDANCE);
                #endregion

                connection.Close();
            }

            dsView = dataSet.DefaultViewManager;

            #region set primary keys
            DataColumn[] gradeKey = new DataColumn[1];
            gradeKey[0] = dataSet.Tables[Table.GRADE].Columns[0];
            dataSet.Tables[Table.GRADE].PrimaryKey = gradeKey;

            DataColumn[] studentKey = new DataColumn[1];
            studentKey[0] = dataSet.Tables[Table.STUDENT].Columns["ID_Siswa"];
            dataSet.Tables[Table.STUDENT].PrimaryKey = studentKey;

            DataColumn[] dataKey = new DataColumn[1];
            dataKey[0] = dataSet.Tables[Table.STUDENT_DATA].Columns["ID_Siswa"];
            dataSet.Tables[Table.STUDENT_DATA].PrimaryKey = dataKey;

            DataColumn[] scoreKey = new DataColumn[1];
            scoreKey[0] = dataSet.Tables[Table.SCORE].Columns["ID_Nilai"];
            dataSet.Tables[Table.SCORE].PrimaryKey = scoreKey;

            DataColumn[] courseKey = new DataColumn[1];
            courseKey[0] = dataSet.Tables[Table.COURSE].Columns["ID_Mapel"];
            dataSet.Tables[Table.COURSE].PrimaryKey = courseKey;

            DataColumn[] attendanceKey = new DataColumn[1];
            attendanceKey[0] = dataSet.Tables[Table.ATTENDANCE].Columns["ID_Absensi"];
            dataSet.Tables[Table.ATTENDANCE].PrimaryKey = attendanceKey;

            dataSet.Relations.Clear();
            dataSet.Relations.Add(Relation.STUDENT_DATA, studentKey[0], dataKey[0], false);
            dataSet.Relations.Add(Relation.STUDENT_SCORE, studentKey[0], scoreKey[0], false);
            #endregion

            cboTingkatFilter.DataSource = dsView;
            cboTingkatFilter.DisplayMember = Table.GRADE + ".tingkat";
            cboTingkatFilter.ValueMember = Table.GRADE + ".tingkat";
        }

        private void cboTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboKelasFilter.Items.Clear();
                lstSiswa.Items.Clear();

                DataRowView v = (DataRowView)cboTingkatFilter.SelectedItem;
                int count = (int)v.Row.ItemArray[1];

                for (int i = 0; i < count; i++)
                {
                    cboKelasFilter.Items.Add(alpha[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
        private void cboKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string c = cboKelasFilter.Text;
                string grade = cboTingkatFilter.Text;

                object[] values = new object[2] { grade, c };
                string ex = $"Tingkat = '{grade}' AND Kelas = '{c}'";

                DataRow[] rows = dataSet.Tables[Table.STUDENT].Select(ex);
                System.Data.DataTable dataTable = dataSet.Tables[Table.STUDENT].Clone();

                foreach (DataRow row in rows)
                {
                    dataTable.ImportRow(row);
                }
                DataView dv = dataTable.DefaultView;

                lstSiswa.DataSource = dv;
                lstSiswa.DisplayMember = "Nama";
                lstSiswa.ValueMember = "ID_Siswa";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnScoreReport_Click(object sender, EventArgs e)
        {
            try
            {
                Guard();
                GenerateScoreReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void GenerateScoreReport()
        {
            if (lstSiswa.SelectedItem == null)
            {
                return;
            }
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            int studentId = (int)studentRv["ID_Siswa"];
            string ex = $"ID_Siswa = '{studentId}'";
            DataRow[] courseRows = dataSet.Tables[Table.SCORE].Select(ex);

            #region Populate sheet
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            xlApp.Workbooks.Add();
            Workbook workBook = xlApp.ActiveWorkbook;
            Worksheet workSheet = xlApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Nama"; workSheet.Cells[1, "B"] = studentRv["Nama"];
            workSheet.Cells[2, "A"] = "Tingkat"; workSheet.Cells[2, "B"] = studentRv["Tingkat"];

            var bodyStartRow = 3;
            workSheet.Cells[bodyStartRow, "A"] = "Mata Pelajaran";
            workSheet.Cells[bodyStartRow, "B"] = "Nilai";

            int charIndex = 0;
            if (chkTugas.Checked)
            {
                workSheet.Cells[bodyStartRow + 1, alpha[++charIndex].ToString()] = "Tugas";
            }
            if (chkTugasP.Checked)
            {
                workSheet.Cells[bodyStartRow + 1, alpha[++charIndex].ToString()] = "Tugas Tambahan";
            }
            if (chkUjian.Checked)
            {
                workSheet.Cells[bodyStartRow + 1, alpha[++charIndex].ToString()] = "Ujian";
            }
            if (chkRemedial.Checked)
            {
                workSheet.Cells[bodyStartRow + 1, alpha[++charIndex].ToString()] = "Remedial";
            }
            var bodyEndRow = bodyStartRow + 1;
            foreach (DataRow courseRow in courseRows)
            {
                bodyEndRow++;
                int courseId = (int)courseRow["ID_Mapel"];
                string courseName = (string)dsView.DataSet.Tables[Table.COURSE].Rows.Find(courseId)["Nama"];
                workSheet.Cells[bodyEndRow, "A"] = courseName;

                int ci = 0;
                if (chkTugas.Checked)
                {
                    workSheet.Cells[bodyEndRow, alpha[++ci].ToString()] = courseRow["Tugas"];
                }
                if (chkTugasP.Checked)
                {
                    workSheet.Cells[bodyEndRow, alpha[++ci].ToString()] = courseRow["Tugas_Tambahan"];
                }
                if (chkUjian.Checked)
                {
                    workSheet.Cells[bodyEndRow, alpha[++ci].ToString()] = courseRow["Ujian"];
                }
                if (chkRemedial.Checked)
                {
                    workSheet.Cells[bodyEndRow, alpha[++ci].ToString()] = courseRow["Remedial"];
                }
            }

            workSheet.Range["A" + bodyStartRow, alpha[charIndex].ToString() + bodyEndRow].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            #endregion            

            xlApp.Visible = true;
        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            try
            {
                Guard();
                GenerateAttendanceReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void GenerateAttendanceReport()
        {
            if (lstSiswa.SelectedItem == null)
            {
                return;
            }
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            int studentId = (int)studentRv["ID_Siswa"];
            string ex = $"ID_Siswa = '{studentId}'";
            DataRow[] attendanceRows = dataSet.Tables[Table.ATTENDANCE].Select(ex);

            #region Populate sheet
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            xlApp.Workbooks.Add();
            Workbook workBook = xlApp.ActiveWorkbook;
            Worksheet workSheet = xlApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Nama"; workSheet.Cells[1, "B"] = studentRv["Nama"];
            workSheet.Cells[2, "A"] = "Tingkat"; workSheet.Cells[2, "B"] = studentRv["Tingkat"];

            var bodyStartRow = 3;
            workSheet.Cells[bodyStartRow, "A"] = "Tanggal";
            workSheet.Cells[bodyStartRow, "B"] = "Kehadiran";
            workSheet.Cells[bodyStartRow, "C"] = "Keterangan";
            var bodyEndRow = bodyStartRow;

            int diff = (dateTimePicker2.Value - dateTimePicker1.Value).Days + 1;
            for (int i = 0; i < diff; i++)
            {
                bodyEndRow++;

                DateTime idate = dateTimePicker1.Value.AddDays(i);
                workSheet.Cells[bodyEndRow, "A"] = idate.Date;
                string attendance = "Libur";
                if (idate.DayOfWeek != DayOfWeek.Sunday && idate.DayOfWeek != DayOfWeek.Saturday)
                {
                    int attendanceId = 1;
                    DataRow row = attendanceRows.Where(r => (
                    (DateTime)r["Tanggal"]).ToString("yyyy-MM-dd") == idate.ToString("yyyy-MM-dd")
                    ).FirstOrDefault();

                    if (row != null)
                    {
                        int id = (int)row["ID_Absensi"];
                        DateTime date = (DateTime)dsView.DataSet.Tables[Table.ATTENDANCE].Rows.Find(id)["Tanggal"];
                        attendanceId = int.Parse(row["Kehadiran"].ToString());

                        string note = row["Keterangan"].ToString();
                        workSheet.Cells[bodyEndRow, "C"] = note;
                    }
                    attendance = Kehadiran.Data.Where(k => k.Id == attendanceId).FirstOrDefault().Nama;
                }

                workSheet.Cells[bodyEndRow, "B"] = attendance;
            }

            workSheet.Range["A" + bodyStartRow, "C" + bodyEndRow].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            #endregion            

            xlApp.Visible = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulSiswa modulSiswa = new ModulSiswa();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void Guard()
        {
            if (lstSiswa.SelectedItem == null)
            {
                MessageBox.Show("Pilih Siswa terlebih dahulu");
            }
        }

        private void btnKehadiran_Click(object sender, EventArgs e)
        {
            Guard();
            GenerateAttendanceReport();
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            Guard();
            GenerateScoreReport();
        }
    }
}
