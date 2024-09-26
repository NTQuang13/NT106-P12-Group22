using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong_Trinh
{
    public partial class Form1 : Form
    {
        double fstNum, secNum;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(Display.Text == "0")
                Display.Text = "0";
            else
                Display.Text = Display.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "1";
            else
                Display.Text = Display.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "2";
            else
                Display.Text = Display.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "3";
            else
                Display.Text = Display.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "4";
            else
                Display.Text = Display.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "5";
            else
                Display.Text = Display.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "6";
            else
                Display.Text = Display.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "7";
            else
                Display.Text = Display.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "8";
            else
                Display.Text = Display.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "9";
            else
                Display.Text = Display.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == ".")
                if (!Display.Text.Contains("."))
                    Display.Text = Display.Text + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(Display.Text);
            oper = "+";
            Display.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(Display.Text);
            oper = "-";
            Display.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(Display.Text);
            oper = "*";
            Display.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(Display.Text);
            oper = "/";
            Display.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);
            f = "";
            s = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(Display.Text);
            switch(oper)
            {
                case "+":
                    Display.Text = (fstNum + secNum).ToString();
                    break;
                case "-":
                    Display.Text = (fstNum - secNum).ToString();
                    break;
                case "*":
                    Display.Text = (fstNum * secNum).ToString();
                    break;
                case "/":
                    Display.Text = (fstNum / secNum).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
