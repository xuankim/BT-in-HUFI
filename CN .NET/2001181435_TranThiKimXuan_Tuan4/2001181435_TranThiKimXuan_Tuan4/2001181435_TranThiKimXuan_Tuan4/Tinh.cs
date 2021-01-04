using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan4
{
    public partial class Tinh : Form
    {
        public Tinh()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string s = "Ket qua la: ";
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                Xuly dt = new Xuly(a, b,0);
                if (rdcong.Checked || rdtru.Checked || rdnhan.Checked || rdchia.Checked)
                {
                    if (rdcong.Checked)
                    {
                        MessageBox.Show(s + a + "+" + b + "=" + dt.Cong());
                    }
                    else if (rdtru.Checked)
                    {
                        MessageBox.Show(s + a + "-" + b + "=" + dt.Tru());
                    }
                    else if (rdnhan.Checked)
                    {
                        MessageBox.Show(s + a + "*" + b + "=" + dt.Nhan());
                    }
                    else if (b != 0)
                    {
                        MessageBox.Show(s + a + "/" + b + "=" + dt.Chia());
                    }
                    else
                    {
                        MessageBox.Show("Phep chia bi loi!!");
                    }
                }
                else
                {
                    MessageBox.Show("Chua chon phep tinh!!!");
                }
            }
            catch
            {
                MessageBox.Show("Phai nhap so!!!");

            }

        }

        private void Tinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

       
    }
}
