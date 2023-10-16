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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            studentInformationTblDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void studentInformationTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInformationTblDataSet);

            MessageBox.Show("New Record Added Successfully");

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInformationTblDataSet.StudentInformationTbl' table. You can move, or remove it, as needed.
            this.studentInformationTblTableAdapter.Fill(this.studentInformationTblDataSet.StudentInformationTbl);

            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.studentInformationTblBindingSource.Filter = "StudentID LIKE '%" + textBoxSearch.Text + "%'";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentInformationTblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form Form1 = new Form1();
                this.Hide();
                Form1.ShowDialog();
            }
        }
    }
}
