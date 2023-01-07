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
    public partial class Login : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private DataRow Authenticate()
        {
            DataSet dataSet = LoadData();
            return dataSet.Tables[TABLE.LOGIN].Rows.Find(txtUsername.Text);
        }

        private DataSet LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM " + TABLE.LOGIN, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, TABLE.LOGIN);

                var key = new DataColumn[1];
                key[0] = dataSet.Tables[TABLE.LOGIN].Columns[0];
                dataSet.Tables[TABLE.LOGIN].PrimaryKey = key;

                connection.Close();
                return dataSet;
            }
        }

        private void Continue()
        {
            Hide();
            MainMenu mainMenu = new MainMenu(txtUsername.Text);
            mainMenu.ShowDialog();
            Dispose();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataRow result = Authenticate();
            string loginTitle = "Login";

            if (result != null)
            {
                if (result[1].ToString() == txtPassword.Text)
                {
                    MessageBox.Show("Login berhasil!\nSelamat datang kembali " + txtUsername.Text + "!", loginTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Continue();
                }
                else
                {
                    MessageBox.Show("Login gagal! Password tidak sesuai!", loginTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User " + txtUsername.Text + " tidak terdaftar!", loginTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                pboEye.BackgroundImage = Properties.Resources.hidden;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                pboEye.BackgroundImage = Properties.Resources.view;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}
