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

namespace Ibuprofen.ModulStaff
{
    public partial class ModulAddStaff : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        
        public ModulAddStaff()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulStaff modulStaff = new ModulStaff();
            modulStaff.ShowDialog();
            Dispose(); Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int isGuru = int.Parse(rdoGuruY.Checked.ToString());
                int courseId = 1;

                string q = $"INSERT INTO {Table.STAFF} " +
                $" (Nama, IS_Guru, ID_Mapel) " +
                $" VALUES ('{txtNama.Text}', '{isGuru}', '{courseId}');" +
                $" SELECT TOP 1 * FROM {Table.STAFF} ORDER BY ID_Staff DESC ";
                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];

                int staffId = row.Field<int>("ID_Staff");
                q = $"INSERT INTO {Table.STAFF_DATA} " +
                    $" (Kota_Lahir, Tanggal_Lahir, Jenis_Kelamin, No_Telp, " +
                    $" Alamat, Pendidikan, Universitas, Gaji) " +
                    $" VALUES" +
                    $" ('{txtKotaLahir.Text}', '{dtpLahir.Value}', '{cboJk.Text}'," +
                    $" '{txtNotelp.Text}', '{txtAlamat.Text}', '{cboTingkat.Text}'," +
                    $" '{nudGaji.Value}') ";

                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
