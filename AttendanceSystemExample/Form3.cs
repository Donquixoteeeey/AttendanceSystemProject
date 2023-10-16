using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemExample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            studentInformationTblDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.studentInformationTblDataGridView.DefaultCellStyle.Font = new Font("Courier New", 9);
            this.studentInformationTblDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInformationTblDataSet.StudentInformationTbl' table. You can move, or remove it, as needed.
            //this.studentInformationTblTableAdapter.Fill(this.studentInformationTblDataSet.StudentInformationTbl);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentInformationTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxCPCLogo_Click(object sender, EventArgs e)
        {

        }

        private void labelCPC_Click(object sender, EventArgs e)
        {

        }

        private void labelSchoolOAC_Click(object sender, EventArgs e)
        {

        }

        private void studentInformationTblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form Form1 = new Form1();
                this.Hide();
                Form1.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.AddNew();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationTblBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.studentInformationTblDataSet);
            this.studentInformationTblTableAdapter.Update(this.studentInformationTblDataSet.StudentInformationTbl);

            MessageBox.Show("Updated Successfully");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.Filter = "StudentID LIKE '%" + textBoxSearch.Text + "%'";
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationTblBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.studentInformationTblDataSet);
            this.studentInformationTblTableAdapter.Update(this.studentInformationTblDataSet.StudentInformationTbl);

            MessageBox.Show("New Record Added Successfully");
        }

        private void buttonLoadRecord_Click(object sender, EventArgs e)
        {
            this.studentInformationTblTableAdapter.Fill(this.studentInformationTblDataSet.StudentInformationTbl);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.RemoveCurrent();
            this.studentInformationTblTableAdapter.Update(this.studentInformationTblDataSet.StudentInformationTbl);

            MessageBox.Show("Deleted Successfully");
        }

        private void buttonMovePrevious_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.MovePrevious();
        }

        private void buttonMoveLast_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.MoveLast();
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.MoveNext();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            this.Hide();
            Form3.ShowDialog();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            Form Form5 = new Form5();
            this.Hide();
            Form5.ShowDialog();
        }
    }
}
