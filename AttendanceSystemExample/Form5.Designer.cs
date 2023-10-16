namespace AttendanceSystemExample
{
    partial class Form5
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
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label yearLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.studentIDLabel1 = new System.Windows.Forms.Label();
            this.studentInformationTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationTblDataSet = new AttendanceSystemExample.StudentInformationTblDataSet();
            this.yearLevelLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.courseLabel1 = new System.Windows.Forms.Label();
            this.middleNameLabel1 = new System.Windows.Forms.Label();
            this.departmentLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelSchoolOAC = new System.Windows.Forms.Label();
            this.labelCPC = new System.Windows.Forms.Label();
            this.pictureBoxCPCLogo = new System.Windows.Forms.PictureBox();
            this.studentInformationTblTableAdapter = new AttendanceSystemExample.StudentInformationTblDataSetTableAdapters.StudentInformationTblTableAdapter();
            this.tableAdapterManager = new AttendanceSystemExample.StudentInformationTblDataSetTableAdapters.TableAdapterManager();
            this.studentInformationTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentInformationTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentInformationTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAMS = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            yearLevelLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblBindingNavigator)).BeginInit();
            this.studentInformationTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.BackColor = System.Drawing.Color.Transparent;
            studentIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIDLabel.ForeColor = System.Drawing.Color.GhostWhite;
            studentIDLabel.Location = new System.Drawing.Point(544, 104);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(98, 21);
            studentIDLabel.TabIndex = 45;
            studentIDLabel.Text = "Student ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.ForeColor = System.Drawing.Color.GhostWhite;
            firstNameLabel.Location = new System.Drawing.Point(544, 127);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(95, 21);
            firstNameLabel.TabIndex = 47;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.BackColor = System.Drawing.Color.Transparent;
            middleNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            middleNameLabel.ForeColor = System.Drawing.Color.GhostWhite;
            middleNameLabel.Location = new System.Drawing.Point(544, 150);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(119, 21);
            middleNameLabel.TabIndex = 49;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.ForeColor = System.Drawing.Color.GhostWhite;
            lastNameLabel.Location = new System.Drawing.Point(544, 173);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(97, 21);
            lastNameLabel.TabIndex = 51;
            lastNameLabel.Text = "Last Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.BackColor = System.Drawing.Color.Transparent;
            departmentLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.ForeColor = System.Drawing.Color.GhostWhite;
            departmentLabel.Location = new System.Drawing.Point(544, 196);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(112, 21);
            departmentLabel.TabIndex = 53;
            departmentLabel.Text = "Department:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.BackColor = System.Drawing.Color.Transparent;
            courseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courseLabel.ForeColor = System.Drawing.Color.GhostWhite;
            courseLabel.Location = new System.Drawing.Point(544, 219);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(68, 21);
            courseLabel.TabIndex = 55;
            courseLabel.Text = "Course:";
            // 
            // yearLevelLabel
            // 
            yearLevelLabel.AutoSize = true;
            yearLevelLabel.BackColor = System.Drawing.Color.Transparent;
            yearLevelLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLevelLabel.ForeColor = System.Drawing.Color.GhostWhite;
            yearLevelLabel.Location = new System.Drawing.Point(544, 242);
            yearLevelLabel.Name = "yearLevelLabel";
            yearLevelLabel.Size = new System.Drawing.Size(95, 21);
            yearLevelLabel.TabIndex = 57;
            yearLevelLabel.Text = "Year Level:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(216, 67);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(190, 167);
            this.textBoxSearch.TabIndex = 44;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.Color.Transparent;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAttendance.Location = new System.Drawing.Point(1164, 31);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(161, 23);
            this.buttonAttendance.TabIndex = 35;
            this.buttonAttendance.Text = "Attendance Record";
            this.buttonAttendance.UseVisualStyleBackColor = false;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.Transparent;
            this.buttonStudents.FlatAppearance.BorderSize = 0;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStudents.Location = new System.Drawing.Point(989, 31);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(169, 23);
            this.buttonStudents.TabIndex = 34;
            this.buttonStudents.Text = "Student Information";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonHome.Location = new System.Drawing.Point(919, 28);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(64, 28);
            this.buttonHome.TabIndex = 33;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonClose.Location = new System.Drawing.Point(1411, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(70, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 733);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(studentIDLabel);
            this.panel2.Controls.Add(this.studentIDLabel1);
            this.panel2.Controls.Add(this.yearLevelLabel1);
            this.panel2.Controls.Add(firstNameLabel);
            this.panel2.Controls.Add(yearLevelLabel);
            this.panel2.Controls.Add(this.firstNameLabel1);
            this.panel2.Controls.Add(this.courseLabel1);
            this.panel2.Controls.Add(middleNameLabel);
            this.panel2.Controls.Add(courseLabel);
            this.panel2.Controls.Add(this.middleNameLabel1);
            this.panel2.Controls.Add(this.departmentLabel1);
            this.panel2.Controls.Add(lastNameLabel);
            this.panel2.Controls.Add(departmentLabel);
            this.panel2.Controls.Add(this.lastNameLabel1);
            this.panel2.Location = new System.Drawing.Point(26, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 371);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(34, 76);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(70, 30);
            this.labelTime.TabIndex = 60;
            this.labelTime.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelDate.Location = new System.Drawing.Point(33, 34);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(81, 33);
            this.labelDate.TabIndex = 59;
            this.labelDate.Text = "Date";
            // 
            // studentIDLabel1
            // 
            this.studentIDLabel1.BackColor = System.Drawing.Color.Transparent;
            this.studentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "StudentID", true));
            this.studentIDLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.studentIDLabel1.Location = new System.Drawing.Point(690, 104);
            this.studentIDLabel1.Name = "studentIDLabel1";
            this.studentIDLabel1.Size = new System.Drawing.Size(214, 23);
            this.studentIDLabel1.TabIndex = 46;
            this.studentIDLabel1.Text = "label1";
            // 
            // studentInformationTblBindingSource
            // 
            this.studentInformationTblBindingSource.DataMember = "StudentInformationTbl";
            this.studentInformationTblBindingSource.DataSource = this.studentInformationTblDataSet;
            // 
            // studentInformationTblDataSet
            // 
            this.studentInformationTblDataSet.DataSetName = "StudentInformationTblDataSet";
            this.studentInformationTblDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yearLevelLabel1
            // 
            this.yearLevelLabel1.BackColor = System.Drawing.Color.Transparent;
            this.yearLevelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "YearLevel", true));
            this.yearLevelLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLevelLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.yearLevelLabel1.Location = new System.Drawing.Point(690, 242);
            this.yearLevelLabel1.Name = "yearLevelLabel1";
            this.yearLevelLabel1.Size = new System.Drawing.Size(214, 23);
            this.yearLevelLabel1.TabIndex = 58;
            this.yearLevelLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.firstNameLabel1.Location = new System.Drawing.Point(690, 127);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(214, 23);
            this.firstNameLabel1.TabIndex = 48;
            this.firstNameLabel1.Text = "label1";
            // 
            // courseLabel1
            // 
            this.courseLabel1.BackColor = System.Drawing.Color.Transparent;
            this.courseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "Course", true));
            this.courseLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.courseLabel1.Location = new System.Drawing.Point(690, 219);
            this.courseLabel1.Name = "courseLabel1";
            this.courseLabel1.Size = new System.Drawing.Size(214, 23);
            this.courseLabel1.TabIndex = 56;
            this.courseLabel1.Text = "label1";
            // 
            // middleNameLabel1
            // 
            this.middleNameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.middleNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "MiddleName", true));
            this.middleNameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.middleNameLabel1.Location = new System.Drawing.Point(690, 150);
            this.middleNameLabel1.Name = "middleNameLabel1";
            this.middleNameLabel1.Size = new System.Drawing.Size(214, 23);
            this.middleNameLabel1.TabIndex = 50;
            this.middleNameLabel1.Text = "label1";
            // 
            // departmentLabel1
            // 
            this.departmentLabel1.BackColor = System.Drawing.Color.Transparent;
            this.departmentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "Department", true));
            this.departmentLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.departmentLabel1.Location = new System.Drawing.Point(690, 196);
            this.departmentLabel1.Name = "departmentLabel1";
            this.departmentLabel1.Size = new System.Drawing.Size(214, 23);
            this.departmentLabel1.TabIndex = 54;
            this.departmentLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationTblBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.lastNameLabel1.Location = new System.Drawing.Point(690, 173);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(214, 23);
            this.lastNameLabel1.TabIndex = 52;
            this.lastNameLabel1.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Location = new System.Drawing.Point(193, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 254);
            this.panel3.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(229, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Scan QR Code";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(178)))), ((int)(((byte)(63)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLogout.Location = new System.Drawing.Point(1280, 810);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(98, 28);
            this.buttonLogout.TabIndex = 40;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelSchoolOAC
            // 
            this.labelSchoolOAC.AutoSize = true;
            this.labelSchoolOAC.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolOAC.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolOAC.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelSchoolOAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSchoolOAC.Location = new System.Drawing.Point(67, 54);
            this.labelSchoolOAC.Name = "labelSchoolOAC";
            this.labelSchoolOAC.Size = new System.Drawing.Size(216, 16);
            this.labelSchoolOAC.TabIndex = 39;
            this.labelSchoolOAC.Text = "The School of the Archdiocese of Capiz";
            this.labelSchoolOAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCPC
            // 
            this.labelCPC.AutoSize = true;
            this.labelCPC.BackColor = System.Drawing.Color.Transparent;
            this.labelCPC.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPC.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelCPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCPC.Location = new System.Drawing.Point(66, 28);
            this.labelCPC.Name = "labelCPC";
            this.labelCPC.Size = new System.Drawing.Size(261, 23);
            this.labelCPC.TabIndex = 38;
            this.labelCPC.Text = "Colegio de la Purisima Concepcion";
            this.labelCPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCPCLogo
            // 
            this.pictureBoxCPCLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCPCLogo.Image")));
            this.pictureBoxCPCLogo.Location = new System.Drawing.Point(12, 28);
            this.pictureBoxCPCLogo.Name = "pictureBoxCPCLogo";
            this.pictureBoxCPCLogo.Size = new System.Drawing.Size(48, 47);
            this.pictureBoxCPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCPCLogo.TabIndex = 37;
            this.pictureBoxCPCLogo.TabStop = false;
            // 
            // studentInformationTblTableAdapter
            // 
            this.studentInformationTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInformationTblTableAdapter = this.studentInformationTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = AttendanceSystemExample.StudentInformationTblDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentInformationTblBindingNavigator
            // 
            this.studentInformationTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentInformationTblBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.studentInformationTblBindingNavigator.BindingSource = this.studentInformationTblBindingSource;
            this.studentInformationTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentInformationTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentInformationTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentInformationTblBindingNavigatorSaveItem});
            this.studentInformationTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentInformationTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentInformationTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentInformationTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentInformationTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentInformationTblBindingNavigator.Name = "studentInformationTblBindingNavigator";
            this.studentInformationTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentInformationTblBindingNavigator.Size = new System.Drawing.Size(1460, 25);
            this.studentInformationTblBindingNavigator.TabIndex = 45;
            this.studentInformationTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentInformationTblBindingNavigatorSaveItem
            // 
            this.studentInformationTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentInformationTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInformationTblBindingNavigatorSaveItem.Image")));
            this.studentInformationTblBindingNavigatorSaveItem.Name = "studentInformationTblBindingNavigatorSaveItem";
            this.studentInformationTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentInformationTblBindingNavigatorSaveItem.Text = "Save Data";
            this.studentInformationTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentInformationTblBindingNavigatorSaveItem_Click);
            // 
            // studentInformationTblDataGridView
            // 
            this.studentInformationTblDataGridView.AutoGenerateColumns = false;
            this.studentInformationTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInformationTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.studentInformationTblDataGridView.DataSource = this.studentInformationTblBindingSource;
            this.studentInformationTblDataGridView.Location = new System.Drawing.Point(1145, 502);
            this.studentInformationTblDataGridView.Name = "studentInformationTblDataGridView";
            this.studentInformationTblDataGridView.Size = new System.Drawing.Size(290, 220);
            this.studentInformationTblDataGridView.TabIndex = 0;
            this.studentInformationTblDataGridView.Visible = false;
            this.studentInformationTblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentInformationTblDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn6.HeaderText = "Course";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "YearLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "YearLevel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAMS
            // 
            this.labelAMS.AutoSize = true;
            this.labelAMS.BackColor = System.Drawing.Color.Transparent;
            this.labelAMS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAMS.ForeColor = System.Drawing.Color.Ivory;
            this.labelAMS.Location = new System.Drawing.Point(1230, 105);
            this.labelAMS.Name = "labelAMS";
            this.labelAMS.Size = new System.Drawing.Size(205, 99);
            this.labelAMS.TabIndex = 46;
            this.labelAMS.Text = "   Attendance \r\nManagement \r\n             System";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 920);
            this.Controls.Add(this.labelAMS);
            this.Controls.Add(this.studentInformationTblDataGridView);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.studentInformationTblBindingNavigator);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelSchoolOAC);
            this.Controls.Add(this.labelCPC);
            this.Controls.Add(this.pictureBoxCPCLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPCLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblBindingNavigator)).EndInit();
            this.studentInformationTblBindingNavigator.ResumeLayout(false);
            this.studentInformationTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTblDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelSchoolOAC;
        private System.Windows.Forms.Label labelCPC;
        private System.Windows.Forms.PictureBox pictureBoxCPCLogo;
        private StudentInformationTblDataSet studentInformationTblDataSet;
        private System.Windows.Forms.BindingSource studentInformationTblBindingSource;
        private StudentInformationTblDataSetTableAdapters.StudentInformationTblTableAdapter studentInformationTblTableAdapter;
        private StudentInformationTblDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentInformationTblBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentInformationTblBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentInformationTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label studentIDLabel1;
        private System.Windows.Forms.Label yearLevelLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label courseLabel1;
        private System.Windows.Forms.Label middleNameLabel1;
        private System.Windows.Forms.Label departmentLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAMS;
    }
}