using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibuprofen
{
    public partial class MainMenu : Form
    {
        public MainMenu(string username)
        {
            InitializeComponent();
            if (username.Length > 0)
            {
                lblIntro.Text = $"Hai, pengguna dengan username {username}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulSiswa modulSiswa = new ModulSiswa();
            modulSiswa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulStaff modulStaff = new ModulStaff();
            modulStaff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulKurikulum modulKurikulum = new ModulKurikulum();
            modulKurikulum.ShowDialog();
        }
    }
}
