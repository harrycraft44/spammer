using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) {
                timer1.Stop();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int d = int.Parse(textBox2.Text);

            timer1.Interval = d ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            if (enter.Checked) {
                SendKeys.SendWait("{Enter}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = numericUpDown1.Value;
            if (i > 0){
                SendKeys.Send(textBox4.Text);
                label5.Text = "working ???";
                i -= 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
