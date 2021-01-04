using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UocBoiSo : Form
    {
        public UocBoiSo()
        {
            InitializeComponent();
        }

       
        private void txta_TextChanged(object sender, EventArgs e)
        {
            char kytucuoi = txta.Text[txta.Text.Length - 1];
            if (!char.IsDigit(kytucuoi))
            {
                errorProvider1.SetError(txta, "Ban nhap khong phai so");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            char kytucuoi = txtb.Text[txtb.Text.Length - 1];
            if (!char.IsDigit(kytucuoi))
            {
                errorProvider1.SetError(txtb, "Ban nhap khong phai so");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txta_Leave(object sender, EventArgs e)
        {

            if (txta.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txta, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtb_Leave(object sender, EventArgs e)
        {
            if (txtb.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtb, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            txtuoc.Text = dt.GCD(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
            txtboi.Text = dt.LCM(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txta.Text = " ";
            txtb.Text = " ";
            txtboi.Text = " ";
            txtuoc.Text = " ";
        }

        private void UocBoiSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
