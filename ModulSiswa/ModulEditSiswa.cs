﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ibuprofen.Database;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Ibuprofen.ModulSiswa
{
    public partial class ModulKurikulum : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;
        SqlDataAdapter adapter;

        readonly char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        bool UnsavedChanges = false;

        public ModulKurikulum()
        {
            InitializeComponent();
        }

        private void ModulSiswa_Load(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("SELECT * FROM " + TABLE.GRADE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.GRADE);

                command = new SqlCommand("SELECT * FROM " + TABLE.STUDENT, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.STUDENT);

                command = new SqlCommand("SELECT * FROM " + TABLE.STUDENT_DATA, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.STUDENT_DATA);

                command = new SqlCommand("SELECT * FROM " + TABLE.SCORE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.SCORE);

                command = new SqlCommand("SELECT * FROM " + TABLE.COURSE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.COURSE);

                command = new SqlCommand("SELECT * FROM " + TABLE.ATTENDANCE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.ATTENDANCE);
                #endregion

                connection.Close();
            }

            dsView = dataSet.DefaultViewManager;

            #region set primary keys
            DataColumn[] gradeKey = new DataColumn[1];
            gradeKey[0] = dataSet.Tables[TABLE.GRADE].Columns[0];
            dataSet.Tables[TABLE.GRADE].PrimaryKey = gradeKey;

            DataColumn[] studentKey = new DataColumn[1];
            studentKey[0] = dataSet.Tables[TABLE.STUDENT].Columns["ID_Siswa"];
            dataSet.Tables[TABLE.STUDENT].PrimaryKey = studentKey;

            DataColumn[] dataKey = new DataColumn[1];
            dataKey[0] = dataSet.Tables[TABLE.STUDENT_DATA].Columns["ID_Siswa"];
            dataSet.Tables[TABLE.STUDENT_DATA].PrimaryKey = dataKey;

            DataColumn[] scoreKey = new DataColumn[1];
            scoreKey[0] = dataSet.Tables[TABLE.SCORE].Columns["ID_Nilai"];
            dataSet.Tables[TABLE.SCORE].PrimaryKey = scoreKey;

            DataColumn[] courseKey = new DataColumn[1];
            courseKey[0] = dataSet.Tables[TABLE.COURSE].Columns["ID_Mapel"];
            dataSet.Tables[TABLE.COURSE].PrimaryKey = courseKey;

            DataColumn[] attendanceKey = new DataColumn[1];
            attendanceKey[0] = dataSet.Tables[TABLE.ATTENDANCE].Columns["ID_Absensi"];
            dataSet.Tables[TABLE.ATTENDANCE].PrimaryKey = attendanceKey;

            dataSet.Relations.Clear();
            dataSet.Relations.Add(Relation.STUDENT_DATA, studentKey[0], dataKey[0], false);
            dataSet.Relations.Add(Relation.STUDENT_SCORE, studentKey[0], scoreKey[0], false);
            #endregion

            cboTingkatFilter.DataSource = dsView;
            cboTingkatFilter.DisplayMember = TABLE.GRADE + ".tingkat";
            cboTingkatFilter.ValueMember = TABLE.GRADE + ".tingkat";

            cboMapel.DataSource = dsView;
            cboMapel.DisplayMember = TABLE.COURSE + ".Nama";
            cboMapel.ValueMember = TABLE.COURSE + ".ID_Mapel";

            cboStatus.DataSource = Kehadiran.Data;
            cboStatus.DisplayMember = "Nama";
            cboStatus.ValueMember = "Id";
        }

        private void cboTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboKelasFilter.Items.Clear();
                cboKelas.Items.Clear();

                DataRowView v = (DataRowView)cboTingkatFilter.SelectedItem;
                int count = (int)v.Row["jumlah_kelas"];

                for (int i = 0; i < count; i++)
                {
                    cboKelasFilter.Items.Add(alpha[i]);
                    cboKelas.Items.Add(alpha[i]);
                }

                FilterStudent();
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
                FilterStudent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void FilterStudent()
        {
            string c = cboKelasFilter.Text;
            string grade = cboTingkatFilter.Text;

            string ex = $"Tingkat = '{grade}' AND Kelas = '{c}'";

            DataRow[] rows = dataSet.Tables[TABLE.STUDENT].Select(ex);
            DataTable dataTable = dataSet.Tables[TABLE.STUDENT].Clone();

            foreach (DataRow row in rows)
            {
                dataTable.ImportRow(row);
            }
            DataView dv = dataTable.DefaultView;

            lstSiswa.DataSource = dv;
            lstSiswa.DisplayMember = "Nama";
            lstSiswa.ValueMember = "ID_Siswa";
        }

        private void lstSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void cboMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySecondTabData();
            ToggleUnsavedChanges(false);
        }

        private void cboMapel_SelectionChangedCommited(object sender, EventArgs e)
        {
            // check if unsaved changes
            if (UnsavedChanges)
            {
                DialogResult dialogResult = MessageBox.Show("Perubahan Anda akan terhapus. Yakin ingin mengubah mata pelajaran?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DisplaySecondTabData();
                }
                else
                {
                    return;
                }
            }
            else
            {
                DisplaySecondTabData();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
                DataRow studentRow = dataSet.Tables[TABLE.STUDENT_DATA].Rows.Find(studentRv["ID_Siswa"]);
                if (studentRow != null)
                {
                    UpdateDataSet();
                    MessageBox.Show("Data telah berhasil diubah!");
                    RestartForm();
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void DisplayData()
        {
            try
            {
                if (lstSiswa.SelectedItem == null)
                {
                    return;
                }
                DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
                DataRow studentRow = dataSet.Tables[TABLE.STUDENT_DATA].Rows.Find(studentRv["ID_Siswa"]);
                if (studentRow != null)
                {
                    #region Tab 1
                    txtNisn.Text = studentRow["NISN"].ToString();
                    txtNama.Text = studentRv["Nama"].ToString();
                    cboJk.Text = (bool)studentRow["Jenis_Kelamin"] ? "Laki-laki" : "Perempuan";
                    cboKelas.Text = studentRv["Kelas"].ToString();
                    DateTime ttl = (DateTime)studentRow["Tanggal_Lahir"];
                    txtTtl.Text = studentRow["Tempat_Lahir"].ToString() + ", " + ttl.ToString("dd MMMM yyyy");
                    txtNotelp.Text = studentRow["Nomor_Telepon"].ToString();
                    #endregion

                    #region Tab 2
                    DisplaySecondTabData();
                    #endregion

                    #region Tab 3
                    DisplayThirdTabData();
                    #endregion
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            ToggleUnsavedChanges(false);
        }

        private void DisplaySecondTabData()
        {
            try
            {
                DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
                DataRowView courseRv = (DataRowView)cboMapel.SelectedItem;

                string courseId = courseRv["ID_Mapel"].ToString();
                string studentId = studentRv["ID_Siswa"].ToString();

                object[] values = new object[2] { courseId, studentId };
                string ex = $"ID_Mapel = '{courseId}' AND ID_Siswa = '{studentId}'";
                DataRow[] courseRows = dataSet.Tables[TABLE.SCORE].Select(ex);
                if (courseRows.Length > 0)
                {
                    DataRow courseRow = courseRows[0];
                    nudTugas.Value = (int)courseRow["Tugas"];
                    nudTugasP.Value = (int)courseRow["Tugas_Tambahan"];
                    nudUjian.Value = (int)courseRow["Ujian"];
                    nudRemedial.Value = (int)courseRow["Remedial"];
                }
                else
                {
                    ClearAllScore();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void ClearAllScore()
        {
            nudTugas.Value = 0;
            nudTugasP.Value = 0;
            nudUjian.Value = 0;
            nudRemedial.Value = 0;
        }

        #region Database Update
        private void UpdateDataSet()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UpdateStudent(connection);
                UpdateStudentData(connection);
                UpdateScores(connection);
                UpdateAttendance(connection);
                connection.Close();
            }
        }

        private void UpdateAttendance(SqlConnection connection)
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            string studentId = studentRv["ID_Siswa"].ToString();

            string date = $"{dtpAbsensi.Value:yyyy-MM-dd}";

            string q = $"UPDATE {TABLE.ATTENDANCE}" +
                $" SET Kehadiran='{cboStatus.SelectedValue}', " +
                $" Keterangan='{txtKeterangan.Text}' " +
                $" WHERE ID_Siswa='{studentId}' AND Tanggal='{date}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    q = $"INSERT INTO {TABLE.ATTENDANCE}" +
                        $" (ID_Siswa, Tanggal, Kehadiran, Keterangan) " +
                        $" VALUES ('{studentId}', '{date}', " +
                        $" '{cboStatus.SelectedValue}', '{txtKeterangan.Text}') ";

                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateScores(SqlConnection connection)
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            DataRowView courseRv = (DataRowView)cboMapel.SelectedItem;

            string courseId = courseRv["ID_Mapel"].ToString();
            string studentId = studentRv["ID_Siswa"].ToString();

            string q = $"UPDATE {TABLE.SCORE}" +
                $" SET Ujian='{nudUjian.Value}', " +
                $" Remedial='{nudRemedial.Value}', " +
                $" Tugas='{nudTugas.Value}', " +
                $" Tugas_Tambahan='{nudTugasP.Value}' " +
                $" WHERE ID_Siswa='{studentId}' AND ID_Mapel='{courseId}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    q = $"INSERT INTO {TABLE.SCORE}" +
                        $" (ID_Siswa, ID_Mapel, Ujian, Remedial, Tugas, Tugas_Tambahan) " +
                        $" VALUES ('{studentId}', '{courseId}', " +
                        $" '{nudUjian.Value}', '{nudRemedial.Value}', " +
                        $" '{nudTugas.Value}', '{nudTugasP.Value}') ";

                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateStudent(SqlConnection connection)
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            int studentId = int.Parse(studentRv["ID_Siswa"].ToString());
            string q = $"UPDATE {TABLE.STUDENT}" +
                $" SET Nama='{txtNama.Text}', Kelas='{cboKelas.Text}'" +
                $" WHERE ID_Siswa='{studentId}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateStudentData(SqlConnection connection)
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            int studentId = int.Parse(studentRv["ID_Siswa"].ToString());
            string q = $"UPDATE {TABLE.STUDENT_DATA}" +
                $" SET Nomor_Telepon='{txtNotelp.Text}'" +
                $" WHERE ID_Siswa='{studentId}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        private void nudScore_ValueChanged(object sender, EventArgs e)
        {
            ToggleUnsavedChanges(true);
        }

        private void ToggleUnsavedChanges(bool? value)
        {
            if (value.HasValue)
            {
                UnsavedChanges = (bool)value;
            }
            else
            {
                UnsavedChanges = !UnsavedChanges;
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        private void dtpAbsensi_ValueChanged(object sender, EventArgs e)
        {
            DisplayThirdTabData();
        }

        private void DisplayThirdTabData()
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            string studentId = studentRv["ID_Siswa"].ToString();

            string ex = $"Tanggal='{dtpAbsensi.Value:yyyy-MM-dd}' AND ID_Siswa='{studentId}'";
            DataRow[] rows = dataSet.Tables[TABLE.ATTENDANCE].Select(ex);
            if (rows.Length > 0)
            {
                DataRow row = rows[0];
                int attendanceId = int.Parse(row["Kehadiran"].ToString());
                cboStatus.SelectedValue = attendanceId;
                if (attendanceId == 3)
                {
                    txtKeterangan.Text = row["Keterangan"].ToString();
                }
            }
            else
            {
                cboStatus.SelectedValue = 1;
                txtKeterangan.Text = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulSiswa modulSiswa = new ModulSiswa();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void RestartForm()
        {
            Hide();
            ModulKurikulum modulSiswa = new ModulKurikulum();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

    }
}
