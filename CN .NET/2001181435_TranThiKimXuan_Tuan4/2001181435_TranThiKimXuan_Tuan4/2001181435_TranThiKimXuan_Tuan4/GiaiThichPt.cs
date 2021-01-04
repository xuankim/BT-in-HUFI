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
    public partial class GiaiThichPt : Form
    {
        public GiaiThichPt()
        {
            InitializeComponent();
        }

        private void btgiai_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                float c = float.Parse(txtc.Text);
                Xuly dt = new Xuly(a, b,0);
                if (rdbacnhat.Checked)
                {

                    txtketqua.Text =(dt.Giaibacnhat()).ToString();
                }
                else if (rdbachai.Checked)
                {

                    float x1 = 0, x2 = 0, delta = 0;                   
                      
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                if (c == 0)
                                {
                                    txtketqua.Text= "Phương trình có vô số nghiệm !";

                                }
                                else
                                {
                                    txtketqua.Text= "Phương trình vô nghiệm !";

                                }
                            }
                            else
                            {
                                x1 = -c / b;
                                txtketqua.Text = "Phương trình có 1 nghiệm ! x= " + x1;

                            }
                        }
                        else
                        {
                            delta = (b * b) - 4 * a * c;
                            double dl = Convert.ToDouble(delta);

                            if (dl < 0)
                            {
                                txtketqua.Text = "Phương trình vô nghiệm !";
                            }
                            else
                            {
                                if (dl > 0)
                                {
                                    x1 = Convert.ToSingle((-Math.Sqrt(dl) - b) / (2 * a));
                                    x2 = Convert.ToSingle((Math.Sqrt(dl) - b) / (2 * a));
                                    txtketqua.Text = "PT có 2 nghiệm phân biệt ! x1= " + x1 + "  x2= " + x2;

                                }
                                else
                                {

                                    x1 = -b / a;
                                    txtketqua.Text = "Phương trình có nghiệm kép ! x1=x2= " + x1;
                                }
                            }
                        }
                    
                }
                else
                {
                    MessageBox.Show("Ban phai chon phuong thuc");
                }
            }
            catch {
                MessageBox.Show("Loi!!!");
            }
        }

        private void rdbacnhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbacnhat.Checked == true)
            {
                label4.Enabled = false;
                txtc.Enabled = false;
            }
            else {

                label4.Enabled = true;
                txtc.Enabled = true;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GiaiThichPt_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
