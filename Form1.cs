using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string arg1;
        public string arg2;
        public int opr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-"  || textBox1.Text == "*"  )
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opr = 1;
            arg1 = textBox1.Text;
            textBox1.Text = "" + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (opr == 1)
            {
                arg2 = textBox1.Text;
                int arg1_int = Convert.ToInt32(arg1);
                int arg2_int = Convert.ToInt32(arg2);
                int sum;
                sum = arg1_int + arg2_int;
                string sum_str = Convert.ToString(sum);
                textBox1.Text = sum_str;
            }
            else if (opr == 2)
            {
                arg2 = textBox1.Text;
                int arg1_int = Convert.ToInt32(arg1);
                int arg2_int = Convert.ToInt32(arg2);
                int diff;
                diff = arg1_int - arg2_int;
                string diff_str = Convert.ToString(diff);
                textBox1.Text = diff_str;
            }
            else if (opr == 3)
            {
                arg2 = textBox1.Text;
                int arg1_int = Convert.ToInt32(arg1);
                int arg2_int = Convert.ToInt32(arg2);
                int mult;
                mult = arg1_int*arg2_int;
                string mult_str = Convert.ToString(mult);
                textBox1.Text = mult_str;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opr = 2;
            arg1 = textBox1.Text;
            textBox1.Text = ""+"-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            opr = 3;
            arg1 = textBox1.Text;
            textBox1.Text = ""+"*";
        }
    }
}
