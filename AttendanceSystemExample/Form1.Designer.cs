using System;
using System.Windows.Forms;

namespace AttendanceSystemExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBackround = new System.Windows.Forms.Panel();
            this.labelAMS = new System.Windows.Forms.Label();
            this.pictureBoxCPCLogo = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelCPC = new System.Windows.Forms.Label();
            this.labelLogintoYA = new System.Windows.Forms.Label();
            this.labelSchoolOAC = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelPasswordLogo = new System.Windows.Forms.Panel();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelUsernameLogo = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.ellipseControl1 = new AttendanceSystemExample.EllipseControl();
            this.ellipseControl2 = new AttendanceSystemExample.EllipseControl();
            this.panelBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackround
            // 
            this.panelBackround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackround.BackgroundImage")));
            this.panelBackround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackround.Controls.Add(this.labelAMS);
            this.panelBackround.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBackround.Location = new System.Drawing.Point(0, 0);
            this.panelBackround.Name = "panelBackround";
            this.panelBackround.Size = new System.Drawing.Size(313, 417);
            this.panelBackround.TabIndex = 0;
            // 
            // labelAMS
            // 
            this.labelAMS.AutoSize = true;
            this.labelAMS.BackColor = System.Drawing.Color.Transparent;
            this.labelAMS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAMS.ForeColor = System.Drawing.Color.Ivory;
            this.labelAMS.Location = new System.Drawing.Point(105, 135);
            this.labelAMS.Name = "labelAMS";
            this.labelAMS.Size = new System.Drawing.Size(205, 99);
            this.labelAMS.TabIndex = 1;
            this.labelAMS.Text = "   Attendance \r\nManagement \r\n             System";
            this.labelAMS.Click += new System.EventHandler(this.labelAMS_Click);
            // 
            // pictureBoxCPCLogo
            // 
            this.pictureBoxCPCLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCPCLogo.Image")));
            this.pictureBoxCPCLogo.Location = new System.Drawing.Point(320, 12);
            this.pictureBoxCPCLogo.Name = "pictureBoxCPCLogo";
            this.pictureBoxCPCLogo.Size = new System.Drawing.Size(35, 34);
            this.pictureBoxCPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCPCLogo.TabIndex = 0;
            this.pictureBoxCPCLogo.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonClose.Location = new System.Drawing.Point(685, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelCPC
            // 
            this.labelCPC.AutoSize = true;
            this.labelCPC.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCPC.Location = new System.Drawing.Point(360, 12);
            this.labelCPC.Name = "labelCPC";
            this.labelCPC.Size = new System.Drawing.Size(206, 19);
            this.labelCPC.TabIndex = 3;
            this.labelCPC.Text = "Colegio de la Purisima Concepcion";
            this.labelCPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLogintoYA
            // 
            this.labelLogintoYA.AutoSize = true;
            this.labelLogintoYA.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogintoYA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.labelLogintoYA.Location = new System.Drawing.Point(408, 103);
            this.labelLogintoYA.Name = "labelLogintoYA";
            this.labelLogintoYA.Size = new System.Drawing.Size(220, 25);
            this.labelLogintoYA.TabIndex = 5;
            this.labelLogintoYA.Text = "Login to Your Account";
            // 
            // labelSchoolOAC
            // 
            this.labelSchoolOAC.AutoSize = true;
            this.labelSchoolOAC.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolOAC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelSchoolOAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSchoolOAC.Location = new System.Drawing.Point(361, 33);
            this.labelSchoolOAC.Name = "labelSchoolOAC";
            this.labelSchoolOAC.Size = new System.Drawing.Size(177, 13);
            this.labelSchoolOAC.TabIndex = 4;
            this.labelSchoolOAC.Text = "The School of the Archdiocese of Capiz";
            this.labelSchoolOAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(59, 10);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(325, 20);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Controls.Add(this.panelPasswordLogo);
            this.panelPassword.Location = new System.Drawing.Point(316, 231);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(393, 33);
            this.panelPassword.TabIndex = 14;
            // 
            // panelPasswordLogo
            // 
            this.panelPasswordLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordLogo.BackgroundImage")));
            this.panelPasswordLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPasswordLogo.Location = new System.Drawing.Point(22, 6);
            this.panelPasswordLogo.Name = "panelPasswordLogo";
            this.panelPasswordLogo.Size = new System.Drawing.Size(17, 20);
            this.panelPasswordLogo.TabIndex = 1;
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.Lavender;
            this.panelUsername.Controls.Add(this.textBoxUsername);
            this.panelUsername.Controls.Add(this.panelUsernameLogo);
            this.panelUsername.Location = new System.Drawing.Point(317, 176);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(393, 33);
            this.panelUsername.TabIndex = 16;
            this.panelUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsername_Paint);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(58, 10);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(325, 20);
            this.textBoxUsername.TabIndex = 13;
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_TextChanged_2);
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged_3);
            // 
            // panelUsernameLogo
            // 
            this.panelUsernameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUsernameLogo.BackgroundImage")));
            this.panelUsernameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUsernameLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.panelUsernameLogo.Location = new System.Drawing.Point(19, 6);
            this.panelUsernameLogo.Name = "panelUsernameLogo";
            this.panelUsernameLogo.Size = new System.Drawing.Size(20, 20);
            this.panelUsernameLogo.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLogin.Location = new System.Drawing.Point(450, 312);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 34);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.buttonReset.Location = new System.Drawing.Point(479, 352);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.labelPassword.Location = new System.Drawing.Point(316, 217);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 17);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Lavender;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.labelUsername.Location = new System.Drawing.Point(317, 162);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 17);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.checkBoxShowPass.Location = new System.Drawing.Point(319, 270);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(110, 20);
            this.checkBoxShowPass.TabIndex = 20;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.cbRememberMe.Location = new System.Drawing.Point(604, 270);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(106, 20);
            this.cbRememberMe.TabIndex = 21;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRaidius = 20;
            this.ellipseControl1.TargetControl = this;
            // 
            // ellipseControl2
            // 
            this.ellipseControl2.CornerRaidius = 20;
            this.ellipseControl2.TargetControl = this.buttonLogin;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(712, 417);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogintoYA);
            this.Controls.Add(this.labelSchoolOAC);
            this.Controls.Add(this.labelCPC);
            this.Controls.Add(this.pictureBoxCPCLogo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelBackround);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelBackround.ResumeLayout(false);
            this.panelBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCPCLogo;
        private System.Windows.Forms.Label labelAMS;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelCPC;
        private System.Windows.Forms.Panel panelBackround;
        private System.Windows.Forms.Label labelLogintoYA;
        private System.Windows.Forms.Label labelSchoolOAC;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelPasswordLogo;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panelUsernameLogo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReset;
        private EventHandler label1_Click;
        private EventHandler pictureBox1_Click;
        private EventHandler label3_Click;
        private EventHandler label2_Click;
        private EventHandler label4_Click;
        private EventHandler textBoxUsername_TextChanged;
        private PaintEventHandler panel4_Paint_1;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private EventHandler Form1_Load;
        private readonly EventHandler textBoxUsername_TextChanged_1;
        private readonly EventHandler textBoxUsername_Click;
        private Label labelPassword;
        private Label labelUsername;
        private CheckBox checkBoxShowPass;
        private CheckBox cbRememberMe;
        private EllipseControl ellipseControl1;
        private EllipseControl ellipseControl2;
    }
}

