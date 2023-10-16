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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudents_Click_1(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            this.Hide();
            Form3.ShowDialog();
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

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            Form Form5 = new Form5();
            this.Hide();
            Form5.ShowDialog();
        }
    }
}
