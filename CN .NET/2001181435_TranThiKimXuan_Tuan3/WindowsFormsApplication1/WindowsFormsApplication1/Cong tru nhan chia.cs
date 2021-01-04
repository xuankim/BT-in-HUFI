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
    public partial class Co : Form
    {
        public Co()
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

        private void Co_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        

        private void btncong_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            txtketqua.Text = dt.cong(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            txtketqua.Text = dt.tru(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            txtketqua.Text = dt.chia(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            txtketqua.Text = dt.nhan(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
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

       

       
    }
}
