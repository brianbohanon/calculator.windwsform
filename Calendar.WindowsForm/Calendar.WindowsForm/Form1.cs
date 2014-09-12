using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Calculator Calc = new Calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox2.Text);
            textBox3.Text = Calc.AddNumbers(val1, val2).ToString();
            if (comboBox1.Text.Equals("Add"))
            {
                textBox3.Text = Calc.AddNumbers(val1, val2).ToString();
            }
            else
            {
                textBox3.Text = Calc.MultiplyNumbers(val1, val2).ToString();
            }
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox2.Text);
            textBox3.Text = Calc.MultiplyNumbers(val1, val2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2();
            NewForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
