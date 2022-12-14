using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibuprofen.ModulSiswa
{
    public partial class ModulAddSiswa : Form
    {
        public ModulAddSiswa()
        {
            InitializeComponent();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulSiswa modulSiswa = new ModulSiswa();
            modulSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Dispose(); Close();
        }
    }
}
