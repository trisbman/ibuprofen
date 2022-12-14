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

namespace Ibuprofen.ModulKurikulum
{
    public partial class ModulKurikulum : Form
    {

        readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;
        SqlDataAdapter adapter;

        public ModulKurikulum()
        {
            InitializeComponent();
        }

        private void Logout(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void ModulKurikulum_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                #region load data from db
                SqlCommand command = new SqlCommand("SELECT * FROM " + Table.COURSE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.COURSE);
                #endregion

                connection.Close();
            }

            dsView = dataSet.DefaultViewManager;

            #region set primary keys
            DataColumn[] staffKey = new DataColumn[1];
            staffKey[0] = dataSet.Tables[Table.COURSE].Columns[0];
            dataSet.Tables[Table.COURSE].PrimaryKey = staffKey;
            #endregion

            lstMapel.DataSource = dsView;
            lstMapel.DisplayMember = Table.COURSE + ".Nama";
            lstMapel.ValueMember = Table.COURSE + ".ID_Mapel";
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
            DataRowView courseRv = (DataRowView)lstMapel.SelectedItem;
            int courseId = int.Parse(courseRv["ID_Mapel"].ToString());
            string q = $"UPDATE {Table.COURSE}" +
                $" SET Nama='{txtNama.Text}'" +
                $" WHERE ID_Mapel='{courseId}'";
            using (SqlCommand cmd = new SqlCommand(q, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDataSet();
                MessageBox.Show("Data telah berhasil diubah!");

                Dispose();
                Close();
                ModulEditSiswa modulSiswa = new ModulEditSiswa();
                modulSiswa.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void lstMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            try
            {
                if (lstMapel.SelectedItem == null)
                {
                    return;
                }
                DataRowView courseRv = (DataRowView)lstMapel.SelectedItem;

                #region Tab 1
                txtId.Text = courseRv["ID_Mapel"].ToString();
                txtNama.Text = courseRv["Nama"].ToString();
                #endregion

                #region Tab 2
                nudTugas.Value = (int)courseRv["KKM_Tugas"];
                nudTugasP.Value = (int)courseRv["KKM_Tugas_Tambahan"];
                nudUjian.Value = (int)courseRv["KKM_Ujian"];
                nudRemedial.Value = (int)courseRv["KKM_Remedial"];
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
