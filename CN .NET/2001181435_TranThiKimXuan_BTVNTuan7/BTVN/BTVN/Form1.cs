using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dt.sua(txtmalop.Text, txttenlop.Text,txtmakhoa.Text) && txtmalop.Text != null)
            {
                MessageBox.Show("Update thanh cong ");
                txtmalop.Clear();
                txtmakhoa.Clear();
                txttenlop.Clear();
            }
            else
            {
                MessageBox.Show("Update that bai ");
            }
        }
        xuly dt =new xuly();
        private void btnthem_Click(object sender, EventArgs e)
        {

            if (dt.kttrung(txtmalop.Text) && txtmakhoa.Text != null && txtmalop.Text!=null && txttenlop.Text!=null)
            {

                if (dt.Them(txtmalop.Text, txttenlop.Text,txtmakhoa.Text))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
                txtmakhoa.Clear();
                txttenlop.Clear();
                txtmalop.Clear();
            }
            else
            {
                MessageBox.Show("Trung ma lop!!!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            if (dt.xoa(txtmalop.Text) && txtmalop.Text != null)
            {

                MessageBox.Show("Xoa thanh cong");

            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
    }
}
