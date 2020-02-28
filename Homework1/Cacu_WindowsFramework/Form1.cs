using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacu_WindowsFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            switch (textBox3.Text)
            {
                case "+":
                    nt.Text = $"{a + b}";
                    break;
                case "-":
                    nt.Text = $"{a - b}";
                    break;
                case "*":
                    nt.Text = $"{a * b}";
                    break;
                case "/":
                    if (b==0)
                        nt.Text = "除数不可为0";
                    else
                    nt.Text = $"{a / b}";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
