
namespace Ibuprofen.ModulKurikulum
{
    partial class ModulKurikulum
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstMapel = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabScore = new System.Windows.Forms.TabPage();
            this.nudRemedial = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudUjian = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTugasP = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTugas = new System.Windows.Forms.NumericUpDown();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemedial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUjian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugasP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTugas)).BeginInit();
            this.tabAttendance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.lstMapel);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 363);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Mata Pelajaran";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(143, 326);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 31);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Hapus";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstMapel
            // 
            this.lstMapel.FormattingEnabled = true;
            this.lstMapel.Location = new System.Drawing.Point(6, 30);
            this.lstMapel.Name = "lstMapel";
            this.lstMapel.Size = new System.Drawing.Size(265, 290);
            this.lstMapel.TabIndex = 3;
            this.lstMapel.SelectedIndexChanged += new System.EventHandler(this.lstMapel_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kembali";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabScore);
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Location = new System.Drawing.Point(304, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 363);
            this.tabControl1.TabIndex = 7;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.txtNama);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.txtId);
            this.tabData.Controls.Add(this.label4);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(476, 337);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Ubah Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(154, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(282, 20);
            this.txtNama.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(154, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(282, 20);
            this.txtId.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // tabScore
            // 
            this.tabScore.Controls.Add(this.nudRemedial);
            this.tabScore.Controls.Add(this.label13);
            this.tabScore.Controls.Add(this.nudUjian);
            this.tabScore.Controls.Add(this.label12);
            this.tabScore.Controls.Add(this.nudTugasP);
            this.tabScore.Controls.Add(this.label14);
            this.tabScore.Controls.Add(this.label11);
            this.tabScore.Controls.Add(this.nudTugas);
            this.tabScore.Location = new System.Drawing.Point(4, 22);
            this.tabScore.Name = "tabScore";
            this.tabScore.Padding = new System.Windows.Forms.Padding(3);
            this.tabScore.Size = new System.Drawing.Size(476, 337);
            this.tabScore.TabIndex = 1;
            this.tabScore.Text = "Pengaturan KKM";
            this.tabScore.UseVisualStyleBackColor = true;
            // 
            // nudRemedial
            // 
            this.nudRemedial.Location = new System.Drawing.Point(216, 205);
            this.nudRemedial.Name = "nudRemedial";
            this.nudRemedial.Size = new System.Drawing.Size(216, 20);
            this.nudRemedial.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Remedial";
            // 
            // nudUjian
            // 
            this.nudUjian.Location = new System.Drawing.Point(216, 158);
            this.nudUjian.Name = "nudUjian";
            this.nudUjian.Size = new System.Drawing.Size(216, 20);
            this.nudUjian.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ujian";
            // 
            // nudTugasP
            // 
            this.nudTugasP.Location = new System.Drawing.Point(216, 110);
            this.nudTugasP.Name = "nudTugasP";
            this.nudTugasP.Size = new System.Drawing.Size(216, 20);
            this.nudTugasP.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tugas Tambahan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tugas";
            // 
            // nudTugas
            // 
            this.nudTugas.Location = new System.Drawing.Point(216, 66);
            this.nudTugas.Name = "nudTugas";
            this.nudTugas.Size = new System.Drawing.Size(216, 20);
            this.nudTugas.TabIndex = 1;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.groupBox3);
            this.tabAttendance.Controls.Add(this.groupBox1);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(476, 337);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "Pengaturan Kelas";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk12);
            this.groupBox3.Controls.Add(this.chk11);
            this.groupBox3.Controls.Add(this.chk10);
            this.groupBox3.Location = new System.Drawing.Point(3, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMA";
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Location = new System.Drawing.Point(359, 38);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(39, 17);
            this.chk12.TabIndex = 0;
            this.chk12.Text = "XII";
            this.chk12.UseVisualStyleBackColor = true;
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Location = new System.Drawing.Point(202, 38);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(36, 17);
            this.chk11.TabIndex = 0;
            this.chk11.Text = "XI";
            this.chk11.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(54, 38);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(33, 17);
            this.chk10.TabIndex = 0;
            this.chk10.Text = "X";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk9);
            this.groupBox1.Controls.Add(this.chk8);
            this.groupBox1.Controls.Add(this.chk7);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMP";
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(359, 38);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(36, 17);
            this.chk9.TabIndex = 0;
            this.chk9.Text = "IX";
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(202, 38);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(42, 17);
            this.chk8.TabIndex = 0;
            this.chk8.Text = "VIII";
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(54, 38);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(39, 17);
            this.chk7.TabIndex = 0;
            this.chk7.Text = "VII";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(709, 415);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Simpan";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(709, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ModulKurikulum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "ModulKurikulum";
            this.Text = "Pengelolaan Materi Pembelajaran";
            this.Load += new System.EventHandler(this.ModulKurikulum_Load);
            this.groupBox2.ResumeLayout(false);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMapel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk12;
        private System.Windows.Forms.CheckBox chk11;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabPage tabScore;
        private System.Windows.Forms.NumericUpDown nudRemedial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudUjian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTugasP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTugas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
    }
}