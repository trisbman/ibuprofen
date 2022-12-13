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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            ModulEditSiswa modulEditSiswa = new ModulEditSiswa();
            modulEditSiswa.ShowDialog();
        }
    }
}
