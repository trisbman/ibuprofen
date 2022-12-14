﻿using System;
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
    public partial class ModulAddStaff : Form
    {
        public ModulAddStaff()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ModulStaff modulStaff = new ModulStaff();
            modulStaff.ShowDialog();
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
