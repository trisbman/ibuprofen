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
using Ibuprofen.Data;

namespace Ibuprofen
{
    public partial class ModulSiswa : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        private readonly string STUDENT_TABLE = "tbl_siswa";
        private readonly string STUDENT_DATA_TABLE = "tbl_data_siswa";
        private readonly string SCORE_TABLE = "tbl_nilai";
        private readonly string STUDENT_DATA_RELATION = "hub_siswa_data";
        private readonly string STUDENT_SCORE_RELATION = "hub_siswa_nilai";
        private readonly string GRADE_TABLE = "tbl_tingkat";
        private readonly string COURSE_TABLE = "tbl_mapel";

        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;

        readonly char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public ModulSiswa()
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
                SqlCommand command = new SqlCommand("SELECT * FROM " + GRADE_TABLE, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, GRADE_TABLE);

                command = new SqlCommand("SELECT * FROM " + STUDENT_TABLE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, STUDENT_TABLE);

                command = new SqlCommand("SELECT * FROM " + STUDENT_DATA_TABLE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, STUDENT_DATA_TABLE);

                command = new SqlCommand("SELECT * FROM " + SCORE_TABLE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, SCORE_TABLE);

                command = new SqlCommand("SELECT * FROM " + COURSE_TABLE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, COURSE_TABLE);
                #endregion

                connection.Close();

                dsView = dataSet.DefaultViewManager;

                #region set primary keys
                DataColumn[] gradeKey = new DataColumn[1];
                gradeKey[0] = dataSet.Tables[GRADE_TABLE].Columns[0];
                dataSet.Tables[GRADE_TABLE].PrimaryKey = gradeKey;

                DataColumn[] studentKey = new DataColumn[1];
                studentKey[0] = dataSet.Tables[STUDENT_TABLE].Columns["ID_Siswa"];
                dataSet.Tables[STUDENT_TABLE].PrimaryKey = studentKey;

                DataColumn[] dataKey = new DataColumn[1];
                dataKey[0] = dataSet.Tables[STUDENT_DATA_TABLE].Columns["ID_Siswa"];
                dataSet.Tables[STUDENT_DATA_TABLE].PrimaryKey = dataKey;

                DataColumn[] scoreKey = new DataColumn[1];
                scoreKey[0] = dataSet.Tables[SCORE_TABLE].Columns["ID_Nilai"];
                dataSet.Tables[SCORE_TABLE].PrimaryKey = scoreKey;

                DataColumn[] courseKey = new DataColumn[1];
                courseKey[0] = dataSet.Tables[COURSE_TABLE].Columns["ID_Mapel"];
                dataSet.Tables[COURSE_TABLE].PrimaryKey = courseKey;

                dataSet.Relations.Clear();
                dataSet.Relations.Add(STUDENT_DATA_RELATION, studentKey[0], dataKey[0]);
                dataSet.Relations.Add(STUDENT_SCORE_RELATION, studentKey[0], scoreKey[0]);
                #endregion

                cboTingkat.DataSource = dsView;
                cboTingkat.DisplayMember = GRADE_TABLE + ".tingkat";
                cboTingkat.ValueMember = GRADE_TABLE + ".tingkat";

                cboMapel.DataSource = dsView;
                cboMapel.DisplayMember = COURSE_TABLE + ".Nama";
                cboMapel.ValueMember = COURSE_TABLE + ".ID_Mapel";
            }
        }

        private void cboTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboKelas.Items.Clear();
                cboKls.Items.Clear();
                lstSiswa.Items.Clear();

                DataRowView v = (DataRowView)cboTingkat.SelectedItem;
                int count = (int)v.Row.ItemArray[1];

                for (int i = 0; i < count; i++)
                {
                    cboKelas.Items.Add(alpha[i]);
                    cboKls.Items.Add(alpha[i]);
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
                string c = cboKelas.Text;
                string grade = cboTingkat.Text;

                object[] values = new object[2] { grade, c };
                string ex = $"Tingkat = '{grade}' AND Kelas = '{c}'";

                DataRow[] rows = dataSet.Tables[STUDENT_TABLE].Select(ex);
                DataTable dataTable = dataSet.Tables[STUDENT_TABLE].Clone();

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
            DisplayData();
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
                DataRow studentRow = dataSet.Tables[STUDENT_DATA_TABLE].Rows.Find(studentRv["ID_Siswa"]);
                if (studentRow != null)
                {
                    #region Tab 1
                    txtNisn.Text = studentRow["NISN"].ToString();
                    txtNama.Text = studentRv["Nama"].ToString();
                    cboJk.Text = (bool)studentRow["Jenis_Kelamin"] ? "Laki-laki" : "Perempuan";
                    cboKls.Text = studentRv["Kelas"].ToString();
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
                DataRow courseRow = dataSet.Tables[SCORE_TABLE].Select(ex)[0];

                if (courseRow != null)
                {
                    nudTugas.Value = (int)courseRow["Tugas"];
                    nudTugasP.Value = (int)courseRow["Tugas_Tambahan"];
                    nudUjian.Value = (int)courseRow["Ujian"];
                    nudRemedial.Value = (int)courseRow["Remedial"];
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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView studentRv = (DataRowView)lstSiswa.SelectedItem;
                DataRow studentRow = dataSet.Tables[STUDENT_DATA_TABLE].Rows.Find(studentRv["ID_Siswa"]);
                if (studentRow != null)
                {
                    Clear();
                    LoadData();
                    DisplayData();
                    MessageBox.Show("Data telah berhasil diubah!");

                    this.Close();
                    ModulSiswa modulSiswa = new ModulSiswa();
                    modulSiswa.ShowDialog();
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

        private void Clear()
        {
            txtNisn.Text = "";
            txtNama.Text = "";
            cboJk.Text = "";
            cboKls.Text = "";
            txtTtl.Text = "";
            txtNotelp.Text = "";

            cboMapel.Text = "";
            nudTugas.Value = 0;
            nudTugasP.Value = 0;
            nudUjian.Value = 0;
            nudRemedial.Value = 0;

            cboMapel.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void exit(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
