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

namespace Ibuprofen
{
    public partial class Login : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        private readonly string LOGIN_TABLE = "tbl_user";

        public Login()
        {
            InitializeComponent();
        }

        private DataRow Authenticate()
        {
            DataSet dataSet = LoadData();
            return dataSet.Tables[LOGIN_TABLE].Rows.Find(txtUsername.Text);
        }

        private DataSet LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM " + LOGIN_TABLE, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, LOGIN_TABLE);

                var key = new DataColumn[1];
                key[0] = dataSet.Tables[LOGIN_TABLE].Columns[0];
                dataSet.Tables[LOGIN_TABLE].PrimaryKey = key;

                connection.Close();
                return dataSet;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataRow result = Authenticate();

            if (result != null)
            {
                if (result[1].ToString() == txtPassword.Text)
                {
                    MessageBox.Show("Login berhasil!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    MainMenu mainMenu = new MainMenu(txtUsername.Text);
                    mainMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login gagal!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User " + txtUsername.Text + " tidak terdaftar!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
