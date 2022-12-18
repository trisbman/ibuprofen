
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkRemedial = new System.Windows.Forms.CheckBox();
            this.chkUjian = new System.Windows.Forms.CheckBox();
            this.chkTugasP = new System.Windows.Forms.CheckBox();
            this.chkTugas = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(295, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 173);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laporan Absensi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tanggal Akhir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tanggal Awal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKehadiran_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(276, 69);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.chkRemedial);
            this.groupBox3.Controls.Add(this.chkUjian);
            this.groupBox3.Controls.Add(this.chkTugasP);
            this.groupBox3.Controls.Add(this.chkTugas);
            this.groupBox3.Location = new System.Drawing.Point(295, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 169);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laporan Nilai";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(450, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNilai_Click);
            // 
            // chkRemedial
            // 
            this.chkRemedial.AutoSize = true;
            this.chkRemedial.Location = new System.Drawing.Point(116, 67);
            this.chkRemedial.Name = "chkRemedial";
            this.chkRemedial.Size = new System.Drawing.Size(70, 17);
            this.chkRemedial.TabIndex = 0;
            this.chkRemedial.Text = "Remedial";
            this.chkRemedial.UseVisualStyleBackColor = true;
            // 
            // chkUjian
            // 
            this.chkUjian.AutoSize = true;
            this.chkUjian.Checked = true;
            this.chkUjian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUjian.Location = new System.Drawing.Point(26, 67);
            this.chkUjian.Name = "chkUjian";
            this.chkUjian.Size = new System.Drawing.Size(50, 17);
            this.chkUjian.TabIndex = 0;
            this.chkUjian.Text = "Ujian";
            this.chkUjian.UseVisualStyleBackColor = true;
            // 
            // chkTugasP
            // 
            this.chkTugasP.AutoSize = true;
            this.chkTugasP.Location = new System.Drawing.Point(116, 44);
            this.chkTugasP.Name = "chkTugasP";
            this.chkTugasP.Size = new System.Drawing.Size(110, 17);
            this.chkTugasP.TabIndex = 0;
            this.chkTugasP.Text = "Tugas Tambahan";
            this.chkTugasP.UseVisualStyleBackColor = true;
            // 
            // chkTugas
            // 
            this.chkTugas.AutoSize = true;
            this.chkTugas.Checked = true;
            this.chkTugas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTugas.Location = new System.Drawing.Point(26, 44);
            this.chkTugas.Name = "chkTugas";
            this.chkTugas.Size = new System.Drawing.Size(56, 17);
            this.chkTugas.TabIndex = 0;
            this.chkTugas.Text = "Tugas";
            this.chkTugas.UseVisualStyleBackColor = true;
            // 
            // ModulReportSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLogout);
            this.Name = "ModulReportSiswa";
            this.Text = "ModulReportSiswa";
            this.Load += new System.EventHandler(this.ModulReportSiswa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkRemedial;
        private System.Windows.Forms.CheckBox chkUjian;
        private System.Windows.Forms.CheckBox chkTugasP;
        private System.Windows.Forms.CheckBox chkTugas;
    }
}