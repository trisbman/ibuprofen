
namespace Ibuprofen.ModulStaff
{
    partial class ModulEditStaff
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGuru = new System.Windows.Forms.CheckBox();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboJk = new System.Windows.Forms.ComboBox();
            this.txtNotelp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTtl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboMapel = new System.Windows.Forms.ComboBox();
            this.rdoGuruT = new System.Windows.Forms.RadioButton();
            this.rdoGuruY = new System.Windows.Forms.RadioButton();
            this.nudGaji = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaji)).BeginInit();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGuru);
            this.groupBox2.Controls.Add(this.lstStaff);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 356);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Staff";
            // 
            // chkGuru
            // 
            this.chkGuru.AutoSize = true;
            this.chkGuru.Location = new System.Drawing.Point(6, 324);
            this.chkGuru.Name = "chkGuru";
            this.chkGuru.Size = new System.Drawing.Size(129, 17);
            this.chkGuru.TabIndex = 4;
            this.chkGuru.Text = "Hanya tampilkan guru";
            this.chkGuru.UseVisualStyleBackColor = true;
            this.chkGuru.CheckedChanged += new System.EventHandler(this.chkGuru_CheckedChanged);
            // 
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.Location = new System.Drawing.Point(6, 19);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(265, 290);
            this.lstStaff.TabIndex = 3;
            this.lstStaff.SelectedIndexChanged += new System.EventHandler(this.lstStaff_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(304, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 356);
            this.tabControl1.TabIndex = 7;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.txtAlamat);
            this.tabData.Controls.Add(this.label1);
            this.tabData.Controls.Add(this.cboJk);
            this.tabData.Controls.Add(this.txtNotelp);
            this.tabData.Controls.Add(this.label9);
            this.tabData.Controls.Add(this.txtTtl);
            this.tabData.Controls.Add(this.label8);
            this.tabData.Controls.Add(this.txtNama);
            this.tabData.Controls.Add(this.label6);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(476, 330);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Data Pribadi";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(152, 234);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(282, 53);
            this.txtAlamat.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alamat";
            // 
            // cboJk
            // 
            this.cboJk.Enabled = false;
            this.cboJk.FormattingEnabled = true;
            this.cboJk.Location = new System.Drawing.Point(152, 95);
            this.cboJk.Name = "cboJk";
            this.cboJk.Size = new System.Drawing.Size(282, 21);
            this.cboJk.TabIndex = 16;
            // 
            // txtNotelp
            // 
            this.txtNotelp.Location = new System.Drawing.Point(152, 190);
            this.txtNotelp.Name = "txtNotelp";
            this.txtNotelp.Size = new System.Drawing.Size(282, 20);
            this.txtNotelp.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "No Telepon";
            // 
            // txtTtl
            // 
            this.txtTtl.Enabled = false;
            this.txtTtl.Location = new System.Drawing.Point(152, 142);
            this.txtTtl.Name = "txtTtl";
            this.txtTtl.Size = new System.Drawing.Size(282, 20);
            this.txtTtl.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tempat, Tgl Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(152, 52);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(282, 20);
            this.txtNama.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboMapel);
            this.tabPage1.Controls.Add(this.rdoGuruT);
            this.tabPage1.Controls.Add(this.rdoGuruY);
            this.tabPage1.Controls.Add(this.nudGaji);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 330);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Data Pekerjaan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboMapel
            // 
            this.cboMapel.FormattingEnabled = true;
            this.cboMapel.Location = new System.Drawing.Point(162, 140);
            this.cboMapel.Name = "cboMapel";
            this.cboMapel.Size = new System.Drawing.Size(178, 21);
            this.cboMapel.TabIndex = 48;
            // 
            // rdoGuruT
            // 
            this.rdoGuruT.AutoSize = true;
            this.rdoGuruT.Location = new System.Drawing.Point(251, 97);
            this.rdoGuruT.Name = "rdoGuruT";
            this.rdoGuruT.Size = new System.Drawing.Size(52, 17);
            this.rdoGuruT.TabIndex = 47;
            this.rdoGuruT.TabStop = true;
            this.rdoGuruT.Text = "Tidak";
            this.rdoGuruT.UseVisualStyleBackColor = true;
            // 
            // rdoGuruY
            // 
            this.rdoGuruY.AutoSize = true;
            this.rdoGuruY.Location = new System.Drawing.Point(162, 97);
            this.rdoGuruY.Name = "rdoGuruY";
            this.rdoGuruY.Size = new System.Drawing.Size(38, 17);
            this.rdoGuruY.TabIndex = 46;
            this.rdoGuruY.TabStop = true;
            this.rdoGuruY.Text = "Ya";
            this.rdoGuruY.UseVisualStyleBackColor = true;
            this.rdoGuruY.CheckedChanged += new System.EventHandler(this.rdoGuruY_CheckedChanged);
            // 
            // nudGaji
            // 
            this.nudGaji.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGaji.Location = new System.Drawing.Point(162, 47);
            this.nudGaji.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudGaji.Minimum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.nudGaji.Name = "nudGaji";
            this.nudGaji.Size = new System.Drawing.Size(178, 20);
            this.nudGaji.TabIndex = 45;
            this.nudGaji.Value = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Gaji/Bulan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Mata Pelajaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apakah Guru?";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(709, 416);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ModulEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Name = "ModulEditStaff";
            this.Text = "Pengelolaan Staff & Guru";
            this.Load += new System.EventHandler(this.ModulStaff_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstStaff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.ComboBox cboJk;
        private System.Windows.Forms.TextBox txtNotelp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTtl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkGuru;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMapel;
        private System.Windows.Forms.RadioButton rdoGuruT;
        private System.Windows.Forms.RadioButton rdoGuruY;
        private System.Windows.Forms.NumericUpDown nudGaji;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}