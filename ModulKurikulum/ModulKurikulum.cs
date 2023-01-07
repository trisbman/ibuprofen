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
using Microsoft.VisualBasic;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            Dispose(); Close();
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
                SqlCommand command = new SqlCommand("SELECT * FROM " + TABLE.COURSE, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, TABLE.COURSE);
                #endregion

                connection.Close();
            }

            dsView = dataSet.DefaultViewManager;

            #region set primary keys
            DataColumn[] staffKey = new DataColumn[1];
            staffKey[0] = dataSet.Tables[TABLE.COURSE].Columns[0];
            dataSet.Tables[TABLE.COURSE].PrimaryKey = staffKey;
            #endregion

            lstMapel.DataSource = dsView;
            lstMapel.DisplayMember = TABLE.COURSE + ".Nama";
            lstMapel.ValueMember = TABLE.COURSE + ".ID_Mapel";
        }

        #region Database Update
        private void UpdateDataSet()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UpdateCourse(connection);
                connection.Close();
            }
        }
        private void UpdateCourse(SqlConnection connection)
        {
            DataRowView courseRv = (DataRowView)lstMapel.SelectedItem;
            int courseId = int.Parse(courseRv["ID_Mapel"].ToString());
            string q = $"UPDATE {TABLE.COURSE}" +
                $" SET Nama='{txtNama.Text}'," +
                $" KKM_Tugas='{nudTugas.Value}'," +
                $" KKM_Tugas_Tambahan='{nudTugasP.Value}'," +
                $" KKM_Ujian='{nudUjian.Value}'," +
                $" KKM_Remedial='{nudRemedial.Value}' " +
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
                RestartForm();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }

        #region DB Modifier
        private void AddCourse(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string q = $"INSERT INTO {TABLE.COURSE}" +
                    $" (Nama) VALUES ('{name}') ";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void DeleteCourse(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string q = $"DELETE FROM {TABLE.COURSE}" +
                    $" WHERE ID_Mapel = {id} ";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Masukkan nama mata pelajaran", "Tambah mata pelajaran baru");
                AddCourse(name);
                RestartForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private void RestartForm()
        {
            Hide();
            ModulKurikulum modulKurikulum = new ModulKurikulum();
            modulKurikulum.ShowDialog();
            Dispose(); Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView courseRv = (DataRowView)lstMapel.SelectedItem;
                int courseId = int.Parse(courseRv["ID_Mapel"].ToString());
                DeleteCourse(courseId);
                RestartForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
