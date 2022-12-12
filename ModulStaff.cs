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
    public partial class ModulStaff : Form
    {
        public ModulStaff()
        {
            InitializeComponent();

            // WIP
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
