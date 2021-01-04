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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void txthoten_Leave(object sender, EventArgs e)
        {
            if (txthoten.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txthoten, "Ban khong duoc de trong!");
            }
            else {
                errorProvider1.Clear();
            }
        }

        private void txtbirth_TextChanged(object sender, EventArgs e)
        {
            char kytucuoi = txtbirth.Text[txtbirth.Text.Length - 1];
            if (!char.IsDigit(kytucuoi))
            {
                errorProvider2.SetError(txtbirth, "Ban nhap khong phai so");
            }
            else {
                errorProvider2.Clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txthoten.Text=" ";
            txtbirth.Text = " ";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            XuLy dt = new XuLy();
            MessageBox.Show(dt.Bt(txthoten.Text, txtbirth.Text));
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        
    }
}
