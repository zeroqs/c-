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
            Hide();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            calc.Show();
            int a = Convert.ToInt32(input.textBox1.Text);
            int b = Convert.ToInt32(input.textBox2.Text);
            int c = Convert.ToInt32(input.textBox3.Text);
            int p = (a + b + c) / 2;
            int area = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (input.checkBox1.Checked & input.checkBox2.Checked)
            {
                calc.label2.Text =  $"Периметр равен {a+b+c}";
                calc.label3.Text =  $"Площадь равна {area}";
            } else if (input.checkBox1.Checked)
            {
                calc.label2.Text = $"Периметр равен {a + b + c}";
            } else
            {
                calc.label3.Text = $"Площадь равна {area}";

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
