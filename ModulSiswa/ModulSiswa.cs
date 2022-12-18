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
    public partial class ModulSiswa : Form
    {
        public ModulSiswa()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            ModulAddSiswa modulAddSiswa = new ModulAddSiswa();
            modulAddSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();
            ModulEditSiswa modulEditSiswa = new ModulEditSiswa();
            modulEditSiswa.ShowDialog();
            Dispose(); Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Dispose(); Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Hide();
            ModulReportSiswa modulReportSiswa = new ModulReportSiswa();
            modulReportSiswa.ShowDialog();
            Dispose(); Close();
        }
    }
}
