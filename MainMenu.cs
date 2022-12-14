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
        public MainMenu()
        {

            InitializeComponent();
        }

        public MainMenu(string username)
        {
            InitializeComponent();
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            Hide();
            ModulSiswa.ModulSiswa modulSiswa = new ModulSiswa.ModulSiswa();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Hide();
            ModulStaff.ModulStaff modulStaff = new ModulStaff.ModulStaff();
            modulStaff.ShowDialog();
            Dispose(); Close();
        }

        private void btnMapel_Click(object sender, EventArgs e)
        {
            Hide();
            ModulKurikulum.ModulKurikulum modulKurikulum = new ModulKurikulum.ModulKurikulum();
            modulKurikulum.ShowDialog();
            Dispose(); Close();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }
    }
}
