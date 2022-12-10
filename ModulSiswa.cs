using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ibuprofen.Data;

namespace Ibuprofen
{
    public partial class ModulSiswa : Form
    {
        List<Siswa> daftarSiswa = DataSiswa.DaftarSiswa;

        public ModulSiswa()
        {
            InitializeComponent();

            DataMapel.DaftarMapel.ForEach(m =>
            {
                cboMapel.Items.Add(m.Name);
            });

            cboMapel.SelectedIndex = 0;

            cboStatus.SelectedIndex = 0;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            string kelas = cboKelas.Text;
            int tingkat = int.Parse(cboTingkat.Text);
            lstSiswa.Items.Clear();

            daftarSiswa.Where((siswa) =>
                siswa.Kelas == kelas && siswa.Tingkat == tingkat
            ).ToList().ForEach((siswa) =>
            {
                lstSiswa.Items.Add(siswa.Nama);
            });
        }

        private void lstSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void UpdateFields()
        {
            if (lstSiswa.SelectedItem == null) { return; }
            string nama = lstSiswa.SelectedItem.ToString();
            Siswa siswa = daftarSiswa.Where((s) =>
            {
                return s.Nama == nama && s.Kelas == cboKelas.Text;
            }).ElementAt(0);

            //

            txtNisn.Text = siswa.NISN.ToString();
            cboJk.Text = siswa.JenisKelamin == 1 ? "Laki-laki" : "Perempuan";

            txtNama.Text = siswa.Nama;
            cboKls.SelectedItem = siswa.Kelas;
            txtNotelp.Text = siswa.NoTelp;
            txtTtl.Text = siswa.TTL;

            //

            int idMapel = DataMapel.DaftarMapel.Where(m => m.Name == cboMapel.Text).ElementAt(0).ID;
            var daftarNilai = DataSiswa.DaftarNilai.Where(n => n.NISNSiswa == siswa.NISN && n.IDMapel == idMapel);
            if (daftarNilai.Count() < 1) return;
            Nilai nilai = daftarNilai.ElementAt(0);
            nudUjian.Value = nilai.Ujian;
            if (nilai.Remedial.HasValue) nudRemedial.Value = (decimal)nilai.Remedial;
            nudTugas.Value = nilai.Tugas;
            if (nilai.TugasPlus.HasValue) nudTugasP.Value = (decimal)nilai.TugasPlus;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            // WIP
            daftarSiswa[0] = new Siswa(2003, "Jessica Mila", 0);


            UpdateFields();
        }

        private void cboMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
