using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibuprofen.ModulStaff
{
    public partial class ModulStaff : Form
    {
        public ModulStaff()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dispose(); Close();
            ModulEditStaff modulEditStaff = new ModulEditStaff();
            modulEditStaff.ShowDialog();
        }
    }
}
