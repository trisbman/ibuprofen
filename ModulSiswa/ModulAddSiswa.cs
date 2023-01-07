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
    public partial class ModulAddSiswa : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public ModulAddSiswa()
        {
            InitializeComponent();
        }
        private void ModulAddSiswa_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM " + TABLE.GRADE, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtGrade = new DataTable();
                adapter.Fill(dtGrade);
                cboTingkat.DataSource = dtGrade;
                cboTingkat.DisplayMember = "tingkat";
                cboTingkat.ValueMember = "tingkat";
                connection.Close();
            }

            cboJk.DataSource = JenisKelamin.Data;
            cboJk.DisplayMember = "Nama";
            cboJk.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string q = $"INSERT INTO {TABLE.STUDENT} " +
                    $" (Nama, Kelas, Tingkat) " +
                    $" VALUES ('{txtNama.Text}', '{cboKelas.Text}', '{cboTingkat.Text}');" +
                    $" SELECT TOP 1 * FROM {TABLE.STUDENT} ORDER BY ID_Siswa DESC ";
                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];

                int studentId = row.Field<int>("ID_Siswa");
                q = $"INSERT INTO {TABLE.STUDENT_DATA} " +
                    $" (ID_Siswa, NISN, Jenis_Kelamin, Alamat, Nomor_Telepon," +
                    $" Nama_Ayah, Nama_Ibu, Tanggal_Lahir, Tempat_Lahir)" +
                    $" VALUES" +
                    $" ('{studentId}', '{txtNisn.Text}', '{cboJk.SelectedValue}'," +
                    $" '{txtAlamat.Text}', '{txtNotelp.Text}', '{txtAyah.Text}'," +
                    $" '{txtIbu.Text}', '{dtpLahir.Value}', '{txtKotaLahir.Text}') ";

                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Siswa berhasil ditambahkan!");
            RestartForm();
        }

        private void RestartForm()
        {
            Hide();
            ModulAddSiswa modulAddSiswa = new ModulAddSiswa();
            modulAddSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulSiswa modulSiswa = new ModulSiswa();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        private void cboTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKelas.Items.Clear();
            DataRowView v = (DataRowView)cboTingkat.SelectedItem;
            int count = (int)v.Row.ItemArray[1];

            for (int i = 0; i < count; i++)
            {
                cboKelas.Items.Add(alpha[i]);
            }
        }
    }
}
