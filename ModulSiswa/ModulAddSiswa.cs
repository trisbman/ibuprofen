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

        public ModulAddSiswa()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string q = $"INSERT INTO {Table.STUDENT} " +
                    $" (Nama, ID_Kelas) " +
                    $" VALUES ('{txtNama.Text}', '{cboKelas.Text}');" +
                    $" SELECT TOP 1 * FROM {Table.STUDENT} ORDER BY ID_Siswa DESC ";
                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];

                int studentId = row.Field<int>("ID_Siswa");
                q = $"INSERT INTO {Table.STUDENT_DATA} " +
                    $" (ID_Siswa, NISN, Jenis_Kelamin, Alamat, Nomor_Telepon," +
                    $" Nama_Ayah, Nama_Ibu, Tanggal_Lahir, Tempat_Lahir)" +
                    $" VALUES" +
                    $" ('{studentId}', '{txtNisn.Text}', '{cboJk.Text}'," +
                    $" '{txtAlamat.Text}', '{txtNotelp.Text}', '{txtAyah.Text}'," +
                    $" '{txtIbu.Text}', '{dtpLahir.Value}', '{txtKotaLahir.Text}') ";

                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
            }
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
    }
}
