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
        ResultForm result = new ResultForm();


        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.Show();
            Hide();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            result.Show();
            Hide();
            int a = int.Parse(input.textBox1.Text);
            int b = int.Parse(input.textBox2.Text);
            int c = int.Parse(input.textBox3.Text);
            int p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (!double.IsNaN(area)) 
            {
                if (input.checkBox1.Checked & input.checkBox2.Checked)
                {
                    result.label2.Text = $"Периметр равен {a + b + c}";
                    result.label3.Text = $"Площадь равна {area}";
                }
                else if (input.checkBox1.Checked)
                {
                    result.label2.Text = $"Периметр равен {a + b + c}";
                }
                else
                {
                    result.label3.Text = $"Площадь равна {area}";

                }
            } else
            {
                result.label2.Text = $"Периметр равен {a + b + c}";
                result.label3.Text = $"Такого треугольника не существует";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
