using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            if (kt())
            {
                KNCSDL k = new KNCSDL(txttenmay.Text, txttencsdl.Text, txtuser.Text, txtpass.Text);
                bool dt = k.ktkn();
                if (dt)
                {
                   
                    
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else
                {
                    MessageBox.Show("That bại");
                }
            }
            else {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }

        }
        public bool kt() {

            foreach (Control c in this.Controls) {
                
                if (c is TextBox && c.Text.Trim().Length == 0)
                {
                   return false;
                   
                }
            }
            return true;
        }
    }
}
