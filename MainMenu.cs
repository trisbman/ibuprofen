﻿using System;
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
        public MainMenu(string username)
        {
            InitializeComponent();
            if (username.Length > 0)
            {
                lblIntro.Text = $"Hai, pengguna dengan username {username}";
            }
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            ModulSiswa.ModulSiswa modulSiswa = new ModulSiswa.ModulSiswa();
            modulSiswa.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            ModulStaff.ModulStaff modulStaff = new ModulStaff.ModulStaff();
            modulStaff.ShowDialog();
        }

        private void btnMapel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            ModulKurikulum.ModulKurikulum modulKurikulum = new ModulKurikulum.ModulKurikulum();
            modulKurikulum.ShowDialog();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
