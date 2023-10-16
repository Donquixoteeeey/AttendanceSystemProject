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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }

        int startP = 0;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void labelAMS_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            MyprogressBar.Value = startP;
            labelPercentage.Text = startP + "%";
            if (MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 0;
                Form2 Obj = new Form2();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void labelPercentage_Click(object sender, EventArgs e)
        {

        }
    }
}
