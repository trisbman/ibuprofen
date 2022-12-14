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
            Hide();
            ModulEditStaff modulEditStaff = new ModulEditStaff();
            modulEditStaff.ShowDialog();
            Dispose(); Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Dispose(); Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            ModulAddStaff modulAddStaff = new ModulAddStaff();
            modulAddStaff.ShowDialog();
            Dispose(); Close();
        }
    }
}
