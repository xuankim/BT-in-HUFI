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
        double Val2;
        double val1;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtinput.Text == "0")
            {
                txtinput.Text = "1";
            }
            else {
                txtinput.AppendText  ("1");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "0";
            }
            else
            {
                txtinput.AppendText("0");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "2";
            }
            else
            {
                txtinput.AppendText("2");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "3";
            }
            else
            {
                txtinput.AppendText("3");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "4";
            }
            else
            {
                txtinput.AppendText("4");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "5";
            }
            else
            {
                txtinput.AppendText("5");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "6";
            }
            else
            {
                txtinput.AppendText("6");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "7";
            }
            else
            {
                txtinput.AppendText("7");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "8";
            }
            else
            {
                txtinput.AppendText("8");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (txtinput.Text == "0")
            {
                txtinput.Text = "9";
            }
            else
            {
                txtinput.AppendText("9");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtinput.Text = "0";
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
             Val2 = double.Parse(txtinput.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + Val2;
                txtinput.Text = result.ToString();
            }
            else if(sign=="-") {
                result = val1 - Val2;
                txtinput.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * Val2;
                txtinput.Text = result.ToString();
            }
            else {
                result = val1 / Val2;
                txtinput.Text = result.ToString();
            }
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtinput.Text);
            txtinput.Text = "";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtinput.Text);
            txtinput.Text = "";
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtinput.Text);
            txtinput.Text = "";
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtinput.Text);
            txtinput.Text = "";
        }
    }
}
