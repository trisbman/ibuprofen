using Ibuprofen.ModulSiswa;
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
    public partial class ModulEditStaff : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        readonly DataSet dataSet = new DataSet();
        DataViewManager dsView;
        DataViewManager dsViewGuru;

        public ModulEditStaff()
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
                SqlCommand command = new SqlCommand("SELECT * FROM " + Table.COURSE, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, Table.COURSE);

                string q = $"SELECT * FROM {Table.STAFF} s" +
                    $" JOIN {Table.STAFF_DATA} sd" +
                    $" ON s.ID_Staff = sd.ID_Staff";
                command.CommandText = q;
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

            cboMapel.DataSource = dsView;
            cboMapel.DisplayMember = Table.COURSE + ".Nama";
            cboMapel.ValueMember = Table.COURSE + ".ID_Mapel";

            InitGuruView();
        }

        private void InitGuruView()
        {
            string ex = $"IS_Guru='true'";
            DataRow[] rows = dsView.DataSet.Tables[Table.STAFF].Select(ex);
            DataSet dataSet = new DataSet();
            DataTable dataTable = dsView.DataSet.Tables[Table.STAFF].Clone();

            foreach (DataRow row in rows)
            {
                dataTable.ImportRow(row);
            }
            dataSet.Tables.Add(dataTable);
            dsViewGuru = dataSet.DefaultViewManager;
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

                #region tab 1
                txtNama.Text = staffRv["Nama"].ToString();
                int jkId = Convert.ToInt32(staffRv["Jenis_Kelamin"]);
                cboJk.Text = JenisKelamin.Data.Where(item => item.Id == jkId).FirstOrDefault().Nama;
                txtTtl.Text = staffRv["TTL"].ToString();
                txtNotelp.Text = staffRv["No_Telepon"].ToString();
                txtAlamat.Text = staffRv["Alamat"].ToString();
                #endregion

                #region tab 2
                bool isGuru = (bool)staffRv["IS_Guru"];
                if (isGuru)
                {
                    rdoGuruY.Checked = true;
                    cboMapel.SelectedValue = staffRv["ID_Mapel"].ToString();
                }
                else
                {
                    rdoGuruT.Checked = true;
                }

                nudGaji.Value = (decimal)staffRv["Gaji"];
                #endregion

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
                ModulEditSiswa modulSiswa = new ModulEditSiswa();
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
            MessageBox.Show("Data staff berhasil diubah");
            RestartForm();
        }
        private void UpdateStaff(SqlConnection connection)
        {
            DataRowView staffRv = (DataRowView)lstStaff.SelectedItem;

            #region staff
            int staffId = int.Parse(staffRv["ID_Staff"].ToString());
            string q = $"UPDATE {Table.STAFF}" +
                $" SET Nama='{txtNama.Text}', " +
                $" IS_Guru='{rdoGuruY.Checked}'," +
                $" ID_Mapel='{cboMapel.SelectedValue}'" +
                $" WHERE ID_Staff='{staffId}'";
            SqlCommand cmd = new SqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            #endregion

            #region staff data
            q = $"UPDATE {Table.STAFF_DATA}" +
                $" SET No_Telepon='{txtNotelp.Text}'," +
                $" Alamat='{txtAlamat.Text}', " +
                $" Gaji='{nudGaji.Value}' " +
                $" WHERE ID_Staff='{staffId}'";
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            #endregion
        }
        #endregion

        private void Logout(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulStaff modulStaff = new ModulStaff();
            modulStaff.ShowDialog();
            Dispose(); Close();
        }

        private void RestartForm()
        {
            Hide();
            ModulEditStaff modul = new ModulEditStaff();
            modul.ShowDialog();
            Dispose(); Close();
        }

        private void rdoGuruY_CheckedChanged(object sender, EventArgs e)
        {
            cboMapel.Enabled = rdoGuruY.Checked;
        }

        private void chkGuru_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGuru.Checked)
            {
                lstStaff.DataSource = dsViewGuru;
            }
            else
            {
                lstStaff.DataSource = dsView;
            }
        }
    }
}
