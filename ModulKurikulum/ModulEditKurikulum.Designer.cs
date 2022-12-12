
namespace Ibuprofen
{
    partial class ModulEditKurikulum
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
            this.lstMapel = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNisn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabScore = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.nudRemedial = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudUjian = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTugasP = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTugas = new System.Windows.Forms.NumericUpDown();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox2.Controls.Add(this.lstMapel);
            this.groupBox2.Location = new System.Drawing.Point(18, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(416, 591);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Mata Pelajaran";
            // 
            // lstMapel
            // 
            this.lstMapel.FormattingEnabled = true;
            this.lstMapel.ItemHeight = 20;
            this.lstMapel.Location = new System.Drawing.Point(9, 46);
            this.lstMapel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMapel.Name = "lstMapel";
            this.lstMapel.Size = new System.Drawing.Size(396, 524);
            this.lstMapel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1064, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Logout);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabScore);
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Location = new System.Drawing.Point(456, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 591);
            this.tabControl1.TabIndex = 7;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnUbah);
            this.tabData.Controls.Add(this.txtNama);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.txtNisn);
            this.tabData.Controls.Add(this.label4);
            this.tabData.Location = new System.Drawing.Point(4, 29);
            this.tabData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabData.Size = new System.Drawing.Size(718, 558);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Ubah Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(542, 478);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(112, 35);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(231, 126);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(421, 26);
            this.txtNama.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama";
            // 
            // txtNisn
            // 
            this.txtNisn.Enabled = false;
            this.txtNisn.Location = new System.Drawing.Point(231, 62);
            this.txtNisn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNisn.Name = "txtNisn";
            this.txtNisn.Size = new System.Drawing.Size(421, 26);
            this.txtNisn.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // tabScore
            // 
            this.tabScore.Controls.Add(this.button4);
            this.tabScore.Controls.Add(this.nudRemedial);
            this.tabScore.Controls.Add(this.label13);
            this.tabScore.Controls.Add(this.nudUjian);
            this.tabScore.Controls.Add(this.label12);
            this.tabScore.Controls.Add(this.nudTugasP);
            this.tabScore.Controls.Add(this.label14);
            this.tabScore.Controls.Add(this.label11);
            this.tabScore.Controls.Add(this.nudTugas);
            this.tabScore.Location = new System.Drawing.Point(4, 29);
            this.tabScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabScore.Name = "tabScore";
            this.tabScore.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabScore.Size = new System.Drawing.Size(718, 558);
            this.tabScore.TabIndex = 1;
            this.tabScore.Text = "Pengaturan KKM";
            this.tabScore.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 465);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ubah";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nudRemedial
            // 
            this.nudRemedial.Location = new System.Drawing.Point(324, 315);
            this.nudRemedial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudRemedial.Name = "nudRemedial";
            this.nudRemedial.Size = new System.Drawing.Size(324, 26);
            this.nudRemedial.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(90, 318);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Remedial";
            // 
            // nudUjian
            // 
            this.nudUjian.Location = new System.Drawing.Point(324, 243);
            this.nudUjian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudUjian.Name = "nudUjian";
            this.nudUjian.Size = new System.Drawing.Size(324, 26);
            this.nudUjian.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ujian";
            // 
            // nudTugasP
            // 
            this.nudTugasP.Location = new System.Drawing.Point(324, 169);
            this.nudTugasP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTugasP.Name = "nudTugasP";
            this.nudTugasP.Size = new System.Drawing.Size(324, 26);
            this.nudTugasP.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 172);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tugas Tambahan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tugas";
            // 
            // nudTugas
            // 
            this.nudTugas.Location = new System.Drawing.Point(324, 102);
            this.nudTugas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTugas.Name = "nudTugas";
            this.nudTugas.Size = new System.Drawing.Size(324, 26);
            this.nudTugas.TabIndex = 1;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.button1);
            this.tabAttendance.Controls.Add(this.groupBox3);
            this.tabAttendance.Controls.Add(this.groupBox1);
            this.tabAttendance.Location = new System.Drawing.Point(4, 29);
            this.tabAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(718, 558);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "Pengaturan Kelas";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ubah";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Location = new System.Drawing.Point(4, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(705, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMA";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(538, 58);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(56, 24);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "XII";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(303, 58);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(51, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "XI";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(81, 58);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(46, 24);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "X";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(705, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMP";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(538, 58);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "IX";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(303, 58);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "VIII";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 58);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "VII";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ModulKurikulum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox txtNisn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabScore;
        private System.Windows.Forms.NumericUpDown nudUjian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTugas;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown nudRemedial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudTugasP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}