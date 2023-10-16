namespace AttendanceSystemExample
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.labelSchoolOAC = new System.Windows.Forms.Label();
            this.labelCPC = new System.Windows.Forms.Label();
            this.pictureBoxCPCLogo = new System.Windows.Forms.PictureBox();
            this.MyprogressBar = new System.Windows.Forms.ProgressBar();
            this.labelAMS = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ellipseControl1 = new AttendanceSystemExample.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSchoolOAC
            // 
            this.labelSchoolOAC.AutoSize = true;
            this.labelSchoolOAC.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolOAC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolOAC.ForeColor = System.Drawing.Color.Ivory;
            this.labelSchoolOAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSchoolOAC.Location = new System.Drawing.Point(193, 48);
            this.labelSchoolOAC.Name = "labelSchoolOAC";
            this.labelSchoolOAC.Size = new System.Drawing.Size(240, 17);
            this.labelSchoolOAC.TabIndex = 100;
            this.labelSchoolOAC.Text = "The School of the Archdiocese of Capiz";
            this.labelSchoolOAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCPC
            // 
            this.labelCPC.AutoSize = true;
            this.labelCPC.BackColor = System.Drawing.Color.Transparent;
            this.labelCPC.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPC.ForeColor = System.Drawing.Color.Ivory;
            this.labelCPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCPC.Location = new System.Drawing.Point(191, 22);
            this.labelCPC.Name = "labelCPC";
            this.labelCPC.Size = new System.Drawing.Size(289, 26);
            this.labelCPC.TabIndex = 99;
            this.labelCPC.Text = "Colegio de la Purisima Concepcion";
            this.labelCPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCPCLogo
            // 
            this.pictureBoxCPCLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCPCLogo.Image")));
            this.pictureBoxCPCLogo.Location = new System.Drawing.Point(137, 18);
            this.pictureBoxCPCLogo.Name = "pictureBoxCPCLogo";
            this.pictureBoxCPCLogo.Size = new System.Drawing.Size(48, 47);
            this.pictureBoxCPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCPCLogo.TabIndex = 98;
            this.pictureBoxCPCLogo.TabStop = false;
            // 
            // MyprogressBar
            // 
            this.MyprogressBar.BackColor = System.Drawing.Color.GhostWhite;
            this.MyprogressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(143)))));
            this.MyprogressBar.Location = new System.Drawing.Point(176, 231);
            this.MyprogressBar.Name = "MyprogressBar";
            this.MyprogressBar.Size = new System.Drawing.Size(377, 23);
            this.MyprogressBar.TabIndex = 101;
            this.MyprogressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelAMS
            // 
            this.labelAMS.AutoSize = true;
            this.labelAMS.BackColor = System.Drawing.Color.Transparent;
            this.labelAMS.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAMS.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelAMS.Location = new System.Drawing.Point(12, 195);
            this.labelAMS.Name = "labelAMS";
            this.labelAMS.Size = new System.Drawing.Size(458, 27);
            this.labelAMS.TabIndex = 102;
            this.labelAMS.Text = "   Attendance Management System";
            this.labelAMS.Click += new System.EventHandler(this.labelAMS_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelPercentage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.ForeColor = System.Drawing.Color.Ivory;
            this.labelPercentage.Location = new System.Drawing.Point(525, 211);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(28, 17);
            this.labelPercentage.TabIndex = 103;
            this.labelPercentage.Text = "%%";
            this.labelPercentage.Click += new System.EventHandler(this.labelPercentage_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRaidius = 20;
            this.ellipseControl1.TargetControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 266);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelAMS);
            this.Controls.Add(this.MyprogressBar);
            this.Controls.Add(this.labelSchoolOAC);
            this.Controls.Add(this.labelCPC);
            this.Controls.Add(this.pictureBoxCPCLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSchoolOAC;
        private System.Windows.Forms.Label labelCPC;
        private System.Windows.Forms.PictureBox pictureBoxCPCLogo;
        private System.Windows.Forms.ProgressBar MyprogressBar;
        private System.Windows.Forms.Label labelAMS;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Timer timer1;
        private EllipseControl ellipseControl1;
    }
}