using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibuprofen.ModulKurikulum
{
    public partial class ModulKurikulumOld : Form
    {
        public ModulKurikulumOld()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dispose(); Close();
            ModulKurikulum modulEditKurikulum = new ModulKurikulum();
            modulEditKurikulum.ShowDialog();
        }
    }
}
