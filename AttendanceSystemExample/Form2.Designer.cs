using System;

namespace AttendanceSystemExample
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxCPCLogo = new System.Windows.Forms.PictureBox();
            this.labelCPC = new System.Windows.Forms.Label();
            this.labelSchoolOAC = new System.Windows.Forms.Label();
            this.ellipseControl1 = new AttendanceSystemExample.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(178)))), ((int)(((byte)(63)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLogout.Location = new System.Drawing.Point(903, 28);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(98, 28);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonHome.Location = new System.Drawing.Point(480, 28);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(64, 28);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.Transparent;
            this.buttonStudents.FlatAppearance.BorderSize = 0;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStudents.Location = new System.Drawing.Point(550, 31);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(169, 23);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Student Information";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click_1);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.Color.Transparent;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAttendance.Location = new System.Drawing.Point(725, 31);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(161, 23);
            this.buttonAttendance.TabIndex = 2;
            this.buttonAttendance.Text = "Attendance Record";
            this.buttonAttendance.UseVisualStyleBackColor = false;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonClose.Location = new System.Drawing.Point(1029, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBoxCPCLogo
            // 
            this.pictureBoxCPCLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCPCLogo.Image")));
            this.pictureBoxCPCLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCPCLogo.Name = "pictureBoxCPCLogo";
            this.pictureBoxCPCLogo.Size = new System.Drawing.Size(48, 47);
            this.pictureBoxCPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCPCLogo.TabIndex = 6;
            this.pictureBoxCPCLogo.TabStop = false;
            // 
            // labelCPC
            // 
            this.labelCPC.AutoSize = true;
            this.labelCPC.BackColor = System.Drawing.Color.Transparent;
            this.labelCPC.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPC.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelCPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCPC.Location = new System.Drawing.Point(66, 12);
            this.labelCPC.Name = "labelCPC";
            this.labelCPC.Size = new System.Drawing.Size(261, 23);
            this.labelCPC.TabIndex = 7;
            this.labelCPC.Text = "Colegio de la Purisima Concepcion";
            this.labelCPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSchoolOAC
            // 
            this.labelSchoolOAC.AutoSize = true;
            this.labelSchoolOAC.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolOAC.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolOAC.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelSchoolOAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSchoolOAC.Location = new System.Drawing.Point(67, 38);
            this.labelSchoolOAC.Name = "labelSchoolOAC";
            this.labelSchoolOAC.Size = new System.Drawing.Size(216, 16);
            this.labelSchoolOAC.TabIndex = 8;
            this.labelSchoolOAC.Text = "The School of the Archdiocese of Capiz";
            this.labelSchoolOAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRaidius = 20;
            this.ellipseControl1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(129)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1065, 560);
            this.Controls.Add(this.labelSchoolOAC);
            this.Controls.Add(this.labelCPC);
            this.Controls.Add(this.pictureBoxCPCLogo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private readonly EventHandler button2_Click;
        private readonly EventHandler buttonStudents_Click;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxCPCLogo;
        private System.Windows.Forms.Label labelCPC;
        private System.Windows.Forms.Label labelSchoolOAC;
        private EllipseControl ellipseControl1;
    }
}