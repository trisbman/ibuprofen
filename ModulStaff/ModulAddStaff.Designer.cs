
namespace Ibuprofen.ModulStaff
{
    partial class ModulAddStaff
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboMapel = new System.Windows.Forms.ComboBox();
            this.rdoGuruT = new System.Windows.Forms.RadioButton();
            this.rdoGuruY = new System.Windows.Forms.RadioButton();
            this.nudGaji = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUniv = new System.Windows.Forms.TextBox();
            this.cboTingkat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLahir = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboJk = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotelp = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKotaLahir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaji)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboMapel);
            this.groupBox3.Controls.Add(this.rdoGuruT);
            this.groupBox3.Controls.Add(this.rdoGuruY);
            this.groupBox3.Controls.Add(this.nudGaji);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(399, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 203);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Pekerjaan";
            // 
            // cboMapel
            // 
            this.cboMapel.FormattingEnabled = true;
            this.cboMapel.Location = new System.Drawing.Point(148, 138);
            this.cboMapel.Name = "cboMapel";
            this.cboMapel.Size = new System.Drawing.Size(182, 21);
            this.cboMapel.TabIndex = 41;
            // 
            // rdoGuruT
            // 
            this.rdoGuruT.AutoSize = true;
            this.rdoGuruT.Checked = true;
            this.rdoGuruT.Location = new System.Drawing.Point(232, 99);
            this.rdoGuruT.Name = "rdoGuruT";
            this.rdoGuruT.Size = new System.Drawing.Size(52, 17);
            this.rdoGuruT.TabIndex = 40;
            this.rdoGuruT.TabStop = true;
            this.rdoGuruT.Text = "Tidak";
            this.rdoGuruT.UseVisualStyleBackColor = true;
            // 
            // rdoGuruY
            // 
            this.rdoGuruY.AutoSize = true;
            this.rdoGuruY.Location = new System.Drawing.Point(147, 99);
            this.rdoGuruY.Name = "rdoGuruY";
            this.rdoGuruY.Size = new System.Drawing.Size(38, 17);
            this.rdoGuruY.TabIndex = 39;
            this.rdoGuruY.TabStop = true;
            this.rdoGuruY.Text = "Ya";
            this.rdoGuruY.UseVisualStyleBackColor = true;
            // 
            // nudGaji
            // 
            this.nudGaji.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGaji.Location = new System.Drawing.Point(148, 52);
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
            this.nudGaji.Size = new System.Drawing.Size(182, 20);
            this.nudGaji.TabIndex = 38;
            this.nudGaji.Value = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Gaji/Bulan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Mata Pelajaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apakah Guru?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUniv);
            this.groupBox2.Controls.Add(this.cboTingkat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(399, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 147);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Akademis";
            // 
            // txtUniv
            // 
            this.txtUniv.Location = new System.Drawing.Point(147, 86);
            this.txtUniv.Name = "txtUniv";
            this.txtUniv.Size = new System.Drawing.Size(183, 20);
            this.txtUniv.TabIndex = 27;
            // 
            // cboTingkat
            // 
            this.cboTingkat.FormattingEnabled = true;
            this.cboTingkat.Location = new System.Drawing.Point(147, 43);
            this.cboTingkat.Name = "cboTingkat";
            this.cboTingkat.Size = new System.Drawing.Size(183, 21);
            this.cboTingkat.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Universitas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pendidikan Terakhir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpLahir);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboJk);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNotelp);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtKotaLahir);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(26, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 356);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pribadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tanggal Lahir";
            // 
            // dtpLahir
            // 
            this.dtpLahir.Location = new System.Drawing.Point(147, 165);
            this.dtpLahir.Name = "dtpLahir";
            this.dtpLahir.Size = new System.Drawing.Size(183, 20);
            this.dtpLahir.TabIndex = 32;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(147, 249);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(183, 64);
            this.txtAlamat.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nama";
            // 
            // cboJk
            // 
            this.cboJk.FormattingEnabled = true;
            this.cboJk.Location = new System.Drawing.Point(147, 83);
            this.cboJk.Name = "cboJk";
            this.cboJk.Size = new System.Drawing.Size(183, 21);
            this.cboJk.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Jenis Kelamin";
            // 
            // txtNotelp
            // 
            this.txtNotelp.Location = new System.Drawing.Point(147, 208);
            this.txtNotelp.Name = "txtNotelp";
            this.txtNotelp.Size = new System.Drawing.Size(183, 20);
            this.txtNotelp.TabIndex = 24;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(147, 40);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(183, 20);
            this.txtNama.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "No Telepon";
            // 
            // txtKotaLahir
            // 
            this.txtKotaLahir.Location = new System.Drawing.Point(147, 127);
            this.txtKotaLahir.Name = "txtKotaLahir";
            this.txtKotaLahir.Size = new System.Drawing.Size(183, 20);
            this.txtKotaLahir.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kota Kelahiran";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(700, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(700, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ModulAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "ModulAddStaff";
            this.Text = "Menu Tambah Staff";
            this.Load += new System.EventHandler(this.ModulAddStaff_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaji)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUniv;
        private System.Windows.Forms.ComboBox cboTingkat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpLahir;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboJk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotelp;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKotaLahir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudGaji;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboMapel;
        private System.Windows.Forms.RadioButton rdoGuruT;
        private System.Windows.Forms.RadioButton rdoGuruY;
    }
}