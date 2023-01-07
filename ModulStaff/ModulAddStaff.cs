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
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;

        public ModulAddStaff()
        {
            InitializeComponent();
        }

        private void ModulAddStaff_Load(object sender, EventArgs e)
        {
            cboJk.DataSource = JenisKelamin.Data;
            cboJk.DisplayMember = "Nama";
            cboJk.ValueMember = "Id";

            cboTingkat.DataSource = Pendidikan.Data;
            cboTingkat.DisplayMember = "Nama";
            cboTingkat.ValueMember = "Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM " + TABLE.COURSE, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.COURSE);
            }
            dsView = dataSet.DefaultViewManager;

            cboMapel.DataSource = dsView;
            cboMapel.DisplayMember = TABLE.COURSE + ".Nama";
            cboMapel.ValueMember = TABLE.COURSE + ".ID_Mapel";
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

        private void AddStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                bool isGuru = rdoGuruY.Checked;

                string q = $"INSERT INTO {TABLE.STAFF} " +
                $" (Nama, IS_Guru, ID_Mapel) " +
                $" VALUES ('{txtNama.Text}', '{isGuru}', '{cboMapel.SelectedValue}');" +
                $" SELECT TOP 1 * FROM {TABLE.STAFF} ORDER BY ID_Staff DESC ";

                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];

                int staffId = row.Field<int>("ID_Staff");
                string ttl = $"{txtKotaLahir.Text}, {dtpLahir.Value:yyyy-MM-dd}";
                q = $"INSERT INTO {TABLE.STAFF_DATA} " +
                    $" (ID_Staff, TTL, Jenis_Kelamin," +
                    $" No_Telepon, Alamat, Universitas, Pendidikan, Gaji) " +
                    $" VALUES" +
                    $" ('{staffId}', '{ttl}', '{cboJk.SelectedValue}'," +
                    $" '{txtNotelp.Text}', '{txtAlamat.Text}', " +
                    $" '{txtUniv.Text}', '{cboTingkat.SelectedValue}', '{nudGaji.Value}') ";

                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddStaff();
            MessageBox.Show("Staff berhasil ditambahkan");
            BackToMainMenu();
        }

        private void BackToMainMenu()
        {
            Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            Dispose(); Close();
        }

        private void rdoGuruY_CheckedChanged(object sender, EventArgs e)
        {
            cboMapel.Enabled = rdoGuruY.Checked;
        }
    }
}
