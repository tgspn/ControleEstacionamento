﻿namespace ControleEstacionamento
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblLoginPasswd = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 195);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbLogin);
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 128);
            this.panel2.TabIndex = 1;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogar);
            this.gbLogin.Controls.Add(this.txtPasswd);
            this.gbLogin.Controls.Add(this.txtUser);
            this.gbLogin.Controls.Add(this.lblLoginPasswd);
            this.gbLogin.Controls.Add(this.lblLoginUser);
            this.gbLogin.Location = new System.Drawing.Point(13, 9);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(568, 105);
            this.gbLogin.TabIndex = 9;
            this.gbLogin.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(376, 27);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(105, 56);
            this.btnLogar.TabIndex = 13;
            this.btnLogar.Text = "Login";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(143, 63);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(227, 20);
            this.txtPasswd.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(144, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(226, 20);
            this.txtUser.TabIndex = 11;
            // 
            // lblLoginPasswd
            // 
            this.lblLoginPasswd.AutoSize = true;
            this.lblLoginPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPasswd.Location = new System.Drawing.Point(76, 66);
            this.lblLoginPasswd.Name = "lblLoginPasswd";
            this.lblLoginPasswd.Size = new System.Drawing.Size(61, 13);
            this.lblLoginPasswd.TabIndex = 10;
            this.lblLoginPasswd.Text = "Password";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.Location = new System.Drawing.Point(100, 30);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(33, 13);
            this.lblLoginUser.TabIndex = 9;
            this.lblLoginUser.Text = "User";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLoginPasswd;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}