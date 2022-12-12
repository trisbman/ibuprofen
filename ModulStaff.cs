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

namespace Ibuprofen
{
    public partial class ModulStaff : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;
        SqlDataAdapter adapter;

        public ModulStaff()
        {
            InitializeComponent();
        }

        private void ModulStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                #region load data from db
                SqlCommand command = new SqlCommand("SELECT * FROM " + Table.STAFF, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.STAFF);
                #endregion

                connection.Close();
            }

            dsView = dataSet.DefaultViewManager;

            #region set primary keys
            DataColumn[] staffKey = new DataColumn[1];
            staffKey[0] = dataSet.Tables[Table.STAFF].Columns[0];
            dataSet.Tables[Table.STAFF].PrimaryKey = staffKey;
            #endregion

            lstStaff.DataSource = dsView;
            lstStaff.DisplayMember = Table.STAFF + ".Nama";
            lstStaff.ValueMember = Table.STAFF + ".ID_Staff";
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstStaff.SelectedItem == null)
                {
                    return;
                }

                DataRowView staffRv = (DataRowView)lstStaff.SelectedItem;
                txtId.Text = staffRv["ID_Staff"].ToString();
                txtNama.Text = staffRv["Nama"].ToString();
                cboJk.Text = (bool)staffRv["Jenis_Kelamin"] ? "Laki-laki" : "Perempuan";
                DateTime ttl = (DateTime)staffRv["Tanggal_Lahir"];
                txtTtl.Text = staffRv["Tempat_Lahir"].ToString() + ", " + ttl.ToString("dd MMMM yyyy");
                txtNotelp.Text = staffRv["Nomor_Telepon"].ToString();
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
                UpdateDataSet();
                MessageBox.Show("Data telah berhasil diubah!");

                Dispose();
                Close();
                ModulSiswa modulSiswa = new ModulSiswa();
                modulSiswa.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        #region Database Update
        private void UpdateDataSet()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UpdateStaff(connection);
                connection.Close();
            }
        }
        private void UpdateStaff(SqlConnection connection)
        {
            DataRowView staffRv = (DataRowView)lstStaff.SelectedItem;
            int staffId = int.Parse(staffRv["ID_Staff"].ToString());
            string q = $"UPDATE {Table.STAFF}" +
                $" SET Nama='{txtNama.Text}'," +
                $" Nomor_Telepon='{txtNotelp.Text}'" +
                $" WHERE ID_Staff='{staffId}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        private void Logout(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
