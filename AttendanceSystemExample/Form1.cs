using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AttendanceSystemExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init_Data();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBoxUsername_TextChanged_2(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.Lavender;
            panelUsername.BackColor = Color.Lavender;
            textBoxPassword.BackColor = SystemColors.Control;
            panelPassword.BackColor = SystemColors.Control;
            labelUsername.BackColor = Color.Lavender;
            labelPassword.BackColor = SystemColors.Control;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
            textBoxPassword.BackColor = Color.Lavender;
            panelPassword.BackColor = Color.Lavender;
            labelPassword.BackColor = Color.Lavender;
            labelUsername.BackColor = SystemColors.Control;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Admin")
            {
                if (textBoxPassword.Text == "Fudge")
                {
                    Save_Data();
                    Form Form4 = new Form4();
                    Form4.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                }
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void textBoxUsername_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void panelUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAMS_Click(object sender, EventArgs e)
        {

        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.RememberMe == "yes")
                {
                    textBoxUsername.Text = Properties.Settings.Default.Username;
                    textBoxPassword.Text = Properties.Settings.Default.Password;
                    cbRememberMe.Checked = true;
                }
                else
                {
                    textBoxUsername.Text = Properties.Settings.Default.Username;
                }
            }
        }

        private void Save_Data()
        {
            if (cbRememberMe.Checked)
            {
                Properties.Settings.Default.Username = textBoxUsername.Text;
                Properties.Settings.Default.Password = textBoxPassword.Text;
                Properties.Settings.Default.RememberMe = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = textBoxUsername.Text;
                Properties.Settings.Default.Password = textBoxPassword.Text;
                Properties.Settings.Default.RememberMe = "no";
                Properties.Settings.Default.Save();
            }
        }
    }
}
