﻿
namespace Ibuprofen.ModulSiswa
{
    partial class ModulEditSiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.cboKelas = new System.Windows.Forms.ComboBox();
            this.cboJk = new System.Windows.Forms.ComboBox();
            this.txtNotelp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTtl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNisn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabScore = new System.Windows.Forms.TabPage();
            this.cboMapel = new System.Windows.Forms.ComboBox();
            this.nudRemedial = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudUjian = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTugasP = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTugas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpAbsensi = new System.Windows.Forms.DateTimePicker();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSiswa = new System.Windows.Forms.ListBox();
            this.cboTingkatFilter = new System.Windows.Forms.ComboBox();
            this.cboKelasFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemedial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUjian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugasP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugas)).BeginInit();
            this.tabAttendance.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabScore);
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Location = new System.Drawing.Point(304, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.cboKelas);
            this.tabData.Controls.Add(this.cboJk);
            this.tabData.Controls.Add(this.txtNotelp);
            this.tabData.Controls.Add(this.label9);
            this.tabData.Controls.Add(this.txtTtl);
            this.tabData.Controls.Add(this.label8);
            this.tabData.Controls.Add(this.label7);
            this.tabData.Controls.Add(this.txtNama);
            this.tabData.Controls.Add(this.label6);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.txtNisn);
            this.tabData.Controls.Add(this.label4);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(476, 322);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Ubah Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // cboKelas
            // 
            this.cboKelas.FormattingEnabled = true;
            this.cboKelas.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboKelas.Location = new System.Drawing.Point(154, 169);
            this.cboKelas.Name = "cboKelas";
            this.cboKelas.Size = new System.Drawing.Size(282, 21);
            this.cboKelas.TabIndex = 16;
            // 
            // cboJk
            // 
            this.cboJk.Enabled = false;
            this.cboJk.FormattingEnabled = true;
            this.cboJk.Location = new System.Drawing.Point(154, 128);
            this.cboJk.Name = "cboJk";
            this.cboJk.Size = new System.Drawing.Size(282, 21);
            this.cboJk.TabIndex = 16;
            // 
            // txtNotelp
            // 
            this.txtNotelp.Location = new System.Drawing.Point(154, 259);
            this.txtNotelp.Name = "txtNotelp";
            this.txtNotelp.Size = new System.Drawing.Size(282, 20);
            this.txtNotelp.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "No Telepon";
            // 
            // txtTtl
            // 
            this.txtTtl.Enabled = false;
            this.txtTtl.Location = new System.Drawing.Point(154, 211);
            this.txtTtl.Name = "txtTtl";
            this.txtTtl.Size = new System.Drawing.Size(282, 20);
            this.txtTtl.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tempat, Tgl Lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kelas";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(154, 85);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(282, 20);
            this.txtNama.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama";
            // 
            // txtNisn
            // 
            this.txtNisn.Enabled = false;
            this.txtNisn.Location = new System.Drawing.Point(154, 40);
            this.txtNisn.Name = "txtNisn";
            this.txtNisn.Size = new System.Drawing.Size(282, 20);
            this.txtNisn.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NISN";
            // 
            // tabScore
            // 
            this.tabScore.Controls.Add(this.cboMapel);
            this.tabScore.Controls.Add(this.nudRemedial);
            this.tabScore.Controls.Add(this.label13);
            this.tabScore.Controls.Add(this.nudUjian);
            this.tabScore.Controls.Add(this.label12);
            this.tabScore.Controls.Add(this.nudTugasP);
            this.tabScore.Controls.Add(this.label14);
            this.tabScore.Controls.Add(this.label11);
            this.tabScore.Controls.Add(this.nudTugas);
            this.tabScore.Controls.Add(this.label10);
            this.tabScore.Location = new System.Drawing.Point(4, 22);
            this.tabScore.Name = "tabScore";
            this.tabScore.Padding = new System.Windows.Forms.Padding(3);
            this.tabScore.Size = new System.Drawing.Size(476, 322);
            this.tabScore.TabIndex = 1;
            this.tabScore.Text = "Pengaturan Nilai";
            this.tabScore.UseVisualStyleBackColor = true;
            // 
            // cboMapel
            // 
            this.cboMapel.FormattingEnabled = true;
            this.cboMapel.Location = new System.Drawing.Point(217, 48);
            this.cboMapel.Name = "cboMapel";
            this.cboMapel.Size = new System.Drawing.Size(216, 21);
            this.cboMapel.TabIndex = 2;
            this.cboMapel.SelectedIndexChanged += new System.EventHandler(this.cboMapel_SelectedIndexChanged);
            this.cboMapel.SelectionChangeCommitted += new System.EventHandler(this.cboMapel_SelectionChangedCommited);
            // 
            // nudRemedial
            // 
            this.nudRemedial.Location = new System.Drawing.Point(217, 238);
            this.nudRemedial.Name = "nudRemedial";
            this.nudRemedial.Size = new System.Drawing.Size(216, 20);
            this.nudRemedial.TabIndex = 1;
            this.nudRemedial.ValueChanged += new System.EventHandler(this.nudScore_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Remedial";
            // 
            // nudUjian
            // 
            this.nudUjian.Location = new System.Drawing.Point(217, 191);
            this.nudUjian.Name = "nudUjian";
            this.nudUjian.Size = new System.Drawing.Size(216, 20);
            this.nudUjian.TabIndex = 1;
            this.nudUjian.ValueChanged += new System.EventHandler(this.nudScore_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ujian";
            // 
            // nudTugasP
            // 
            this.nudTugasP.Location = new System.Drawing.Point(217, 143);
            this.nudTugasP.Name = "nudTugasP";
            this.nudTugasP.Size = new System.Drawing.Size(216, 20);
            this.nudTugasP.TabIndex = 1;
            this.nudTugasP.ValueChanged += new System.EventHandler(this.nudScore_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tugas Tambahan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tugas";
            // 
            // nudTugas
            // 
            this.nudTugas.Location = new System.Drawing.Point(217, 99);
            this.nudTugas.Name = "nudTugas";
            this.nudTugas.Size = new System.Drawing.Size(216, 20);
            this.nudTugas.TabIndex = 1;
            this.nudTugas.ValueChanged += new System.EventHandler(this.nudScore_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mata Pelajaran";
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.textBox2);
            this.tabAttendance.Controls.Add(this.cboStatus);
            this.tabAttendance.Controls.Add(this.label16);
            this.tabAttendance.Controls.Add(this.label17);
            this.tabAttendance.Controls.Add(this.label15);
            this.tabAttendance.Controls.Add(this.dtpAbsensi);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(476, 322);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "Pengaturan Absensi";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 130);
            this.textBox2.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Hadir",
            "Alpha",
            "Izin"});
            this.cboStatus.Location = new System.Drawing.Point(114, 85);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 21);
            this.cboStatus.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Keterangan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tanggal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Status";
            // 
            // dtpAbsensi
            // 
            this.dtpAbsensi.Location = new System.Drawing.Point(114, 38);
            this.dtpAbsensi.Name = "dtpAbsensi";
            this.dtpAbsensi.Size = new System.Drawing.Size(200, 20);
            this.dtpAbsensi.TabIndex = 0;
            this.dtpAbsensi.ValueChanged += new System.EventHandler(this.dtpAbsensi_ValueChanged);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.button2);
            this.tabReport.Controls.Add(this.button1);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(476, 322);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Laporan";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Generate Laporan Absensi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Laporan Nilai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnScoreReport_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(709, 407);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Simpan";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSiswa);
            this.groupBox2.Controls.Add(this.cboTingkatFilter);
            this.groupBox2.Controls.Add(this.cboKelasFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 348);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Siswa";
            // 
            // lstSiswa
            // 
            this.lstSiswa.FormattingEnabled = true;
            this.lstSiswa.Location = new System.Drawing.Point(25, 179);
            this.lstSiswa.Name = "lstSiswa";
            this.lstSiswa.Size = new System.Drawing.Size(217, 147);
            this.lstSiswa.TabIndex = 3;
            this.lstSiswa.SelectedIndexChanged += new System.EventHandler(this.lstSiswa_SelectedIndexChanged);
            // 
            // cboTingkatFilter
            // 
            this.cboTingkatFilter.FormattingEnabled = true;
            this.cboTingkatFilter.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cboTingkatFilter.Location = new System.Drawing.Point(25, 59);
            this.cboTingkatFilter.Name = "cboTingkatFilter";
            this.cboTingkatFilter.Size = new System.Drawing.Size(217, 21);
            this.cboTingkatFilter.TabIndex = 0;
            this.cboTingkatFilter.SelectedIndexChanged += new System.EventHandler(this.cboTingkat_SelectedIndexChanged);
            // 
            // cboKelasFilter
            // 
            this.cboKelasFilter.FormattingEnabled = true;
            this.cboKelasFilter.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboKelasFilter.Location = new System.Drawing.Point(25, 117);
            this.cboKelasFilter.Name = "cboKelasFilter";
            this.cboKelasFilter.Size = new System.Drawing.Size(217, 21);
            this.cboKelasFilter.TabIndex = 0;
            this.cboKelasFilter.SelectedIndexChanged += new System.EventHandler(this.cboKelas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tingkat";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(709, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ModulEditSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "ModulEditSiswa";
            this.Text = "Pengelolaan Peserta Didik";
            this.Load += new System.EventHandler(this.ModulSiswa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabScore.ResumeLayout(false);
            this.tabScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemedial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUjian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugasP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugas)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            this.tabAttendance.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabScore;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSiswa;
        private System.Windows.Forms.ComboBox cboTingkatFilter;
        private System.Windows.Forms.ComboBox cboKelasFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboJk;
        private System.Windows.Forms.TextBox txtNotelp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTtl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNisn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRemedial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudUjian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTugasP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTugas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMapel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpAbsensi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboKelas;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
    }
}