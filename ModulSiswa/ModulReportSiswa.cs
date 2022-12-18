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
            if(lstSiswa.SelectedItem == null)
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
            workSheet.Cells[bodyStartRow + 1, "B"] = "Tugas";
            workSheet.Cells[bodyStartRow + 1, "C"] = "Tugas Tambahan";
            workSheet.Cells[bodyStartRow + 1, "D"] = "Ujian";
            workSheet.Cells[bodyStartRow + 1, "E"] = "Remedial";
            var bodyEndRow = bodyStartRow + 1;
            foreach (DataRow courseRow in courseRows)
            {
                bodyEndRow++;
                int courseId = (int)courseRow["ID_Mapel"];
                string courseName = (string)dsView.DataSet.Tables[Table.COURSE].Rows.Find(courseId)["Nama"];
                workSheet.Cells[bodyEndRow, "A"] = courseName;
                workSheet.Cells[bodyEndRow, "B"] = courseRow["Tugas"];
                workSheet.Cells[bodyEndRow, "C"] = courseRow["Tugas_Tambahan"];
                workSheet.Cells[bodyEndRow, "D"] = courseRow["Ujian"];
                workSheet.Cells[bodyEndRow, "E"] = courseRow["Remedial"];
            }

            workSheet.Range["A" + bodyStartRow, "E" + bodyEndRow].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
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
    }
}
