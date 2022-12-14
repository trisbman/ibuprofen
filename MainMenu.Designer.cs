
namespace Ibuprofen
{
    partial class MainMenu
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
            this.btnSiswa = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnMapel = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSiswa
            // 
            this.btnSiswa.BackgroundImage = global::Ibuprofen.Properties.Resources.write;
            this.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiswa.Location = new System.Drawing.Point(47, 160);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new System.Drawing.Size(150, 150);
            this.btnSiswa.TabIndex = 1;
            this.btnSiswa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiswa.UseVisualStyleBackColor = true;
            this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackgroundImage = global::Ibuprofen.Properties.Resources.manager;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaff.Location = new System.Drawing.Point(254, 160);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(150, 150);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnMapel
            // 
            this.btnMapel.BackgroundImage = global::Ibuprofen.Properties.Resources.file;
            this.btnMapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapel.Location = new System.Drawing.Point(463, 160);
            this.btnMapel.Name = "btnMapel";
            this.btnMapel.Size = new System.Drawing.Size(150, 150);
            this.btnMapel.TabIndex = 3;
            this.btnMapel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMapel.UseVisualStyleBackColor = true;
            this.btnMapel.Click += new System.EventHandler(this.btnMapel_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(444, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "L&ogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pengelolaan Peserta Didik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pengelolaan Guru && Staff";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(472, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pengelolaan Materi Pembelajaran";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(45, 33);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(77, 13);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Hai, pengguna";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "K&eluar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 424);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMapel);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnSiswa);
            this.Controls.Add(this.lblIntro);
            this.Name = "MainMenu";
            this.Text = "Menu Utama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnMapel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnExit;
    }
}