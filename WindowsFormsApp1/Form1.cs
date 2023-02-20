using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        InputForm input = new InputForm();
        ResultForm calc = new ResultForm();


        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.Show();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            calc.Show();
            int a = Convert.ToInt32(input.textBox1.Text);
            int b = Convert.ToInt32(input.textBox2.Text);
            int c = Convert.ToInt32(input.textBox3.Text);

            if (input.checkBox1.Checked & input.checkBox2.Checked)
            {
                calc.
            } 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
