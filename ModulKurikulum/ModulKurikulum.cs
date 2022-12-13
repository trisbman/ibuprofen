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
    public partial class ModulKurikulum : Form
    {
        public ModulKurikulum()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dispose(); Close();
            ModulEditKurikulum modulEditKurikulum = new ModulEditKurikulum();
            modulEditKurikulum.ShowDialog();
        }
    }
}
