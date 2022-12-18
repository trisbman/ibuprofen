using System;
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

            cboMapel.DataSource = dsView;
            cboMapel.DisplayMember = Table.COURSE + ".Nama";
            cboMapel.ValueMember = Table.COURSE + ".ID_Mapel";
        }

        private void cboTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboKelasFilter.Items.Clear();
                cboKelas.Items.Clear();
                lstSiswa.Items.Clear();

                DataRowView v = (DataRowView)cboTingkatFilter.SelectedItem;
                int count = (int)v.Row.ItemArray[1];

                for (int i = 0; i < count; i++)
                {
                    cboKelasFilter.Items.Add(alpha[i]);
                    cboKelas.Items.Add(alpha[i]);
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
                DataTable dataTable = dataSet.Tables[Table.STUDENT].Clone();

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
                DataRow studentRow = dataSet.Tables[Table.STUDENT_DATA].Rows.Find(studentRv["ID_Siswa"]);
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
                DataRow studentRow = dataSet.Tables[Table.STUDENT_DATA].Rows.Find(studentRv["ID_Siswa"]);
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
            Console.WriteLine(UnsavedChanges);
            ToggleUnsavedChanges(false);
            Console.WriteLine(UnsavedChanges);
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
                DataRow[] courseRows = dataSet.Tables[Table.SCORE].Select(ex);
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
                connection.Close();
            }
        }

        private void UpdateScores(SqlConnection connection)
        {
            DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
            DataRowView courseRv = (DataRowView)cboMapel.SelectedItem;

            string courseId = courseRv["ID_Mapel"].ToString();
            string studentId = studentRv["ID_Siswa"].ToString();

            string q = $"UPDATE {Table.SCORE}" +
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
                    q = $"INSERT INTO {Table.SCORE}" +
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
            string q = $"UPDATE {Table.STUDENT}" +
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
            string q = $"UPDATE {Table.STUDENT_DATA}" +
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
