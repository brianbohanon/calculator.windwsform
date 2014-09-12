using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, val2;
            val1 = double.Parse(textBox1.Text);
            val2 = double.Parse(textBox2.Text);
            textBox3.Text = (val1 + val2).ToString();
        }
    }
}
