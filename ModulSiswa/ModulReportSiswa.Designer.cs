
namespace Ibuprofen.ModulSiswa
{
    partial class ModulReportSiswa
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
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSiswa = new System.Windows.Forms.ListBox();
            this.cboTingkatFilter = new System.Windows.Forms.ComboBox();
            this.cboKelasFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbsensi = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSiswa);
            this.groupBox2.Controls.Add(this.cboTingkatFilter);
            this.groupBox2.Controls.Add(this.cboKelasFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 348);
            this.groupBox2.TabIndex = 11;
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
            this.btnLogout.Location = new System.Drawing.Point(709, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbsensi
            // 
            this.btnAbsensi.Location = new System.Drawing.Point(314, 54);
            this.btnAbsensi.Name = "btnAbsensi";
            this.btnAbsensi.Size = new System.Drawing.Size(470, 88);
            this.btnAbsensi.TabIndex = 0;
            this.btnAbsensi.Text = "Generate Laporan Absensi";
            this.btnAbsensi.UseVisualStyleBackColor = true;
            this.btnAbsensi.Click += new System.EventHandler(this.btnAbsensi_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(314, 169);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(470, 94);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Generate Laporan Nilai";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScoreReport_Click);
            // 
            // ModulReportSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.btnAbsensi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLogout);
            this.Name = "ModulReportSiswa";
            this.Text = "ModulReportSiswa";
            this.Load += new System.EventHandler(this.ModulReportSiswa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSiswa;
        private System.Windows.Forms.ComboBox cboTingkatFilter;
        private System.Windows.Forms.ComboBox cboKelasFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAbsensi;
        private System.Windows.Forms.Button btnScore;
    }
}