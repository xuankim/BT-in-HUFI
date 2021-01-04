using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181078_NguyenTranPhuongDuy_Buoi3
{
    public partial class Calculator : Form
    {
        Handle hd = new Handle();
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkTxtNoError())
                txtResult.Text = hd.Add(txtA.Text, txtB.Text).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (checkTxtNoError())
                txtResult.Text = hd.Sub(txtA.Text, txtB.Text).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (checkTxtNoError())
                txtResult.Text = hd.Mul(txtA.Text, txtB.Text).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (checkTxtNoError())
                if (txtB.Text != "0")
                    txtResult.Text = hd.Div(txtA.Text, txtB.Text).ToString();
                else
                    MessageBox.Show("Khong chia mot so cho 0 duoc!!","Thong Bao");
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text.Length > 0)
            {
                if (!hd.checkFloatString(txtA.Text))
                    errorProvider1.SetError(txtA, "Ban nhap khong phai so");
                else
                    errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtA, "Vui Long nhap so");
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text.Length > 0)
            {
                if (!hd.checkFloatString(txtB.Text))
                    errorProvider2.SetError(txtB, "Ban nhap khong phai so");
                else
                    errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(txtB, "Vui Long nhap so");
            }
        }

        private bool checkTxtNoError()
        {
            return (errorProvider1.GetError(txtA).Trim().Length == 0 && errorProvider2.GetError(txtB).Trim().Length == 0 && txtA.Text.Length != 0 && txtB.Text.Length != 0);
        }


    }
}
