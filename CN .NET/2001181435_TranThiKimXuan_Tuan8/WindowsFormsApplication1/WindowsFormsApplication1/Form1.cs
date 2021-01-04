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
        xuly dt = new xuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dt.kttrung(txtmakhoa.Text)&& txtmakhoa.Text!=null)
            {

                if (dt.Them(txtmakhoa.Text, txttenkhoa.Text))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
                txtmakhoa.Clear();
                txttenkhoa.Clear();
            }
            else {
                MessageBox.Show("Trung ma khoa!!!");
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dt.xoa(txtmakhoa.Text) && txtmakhoa.Text!=null)
            {
               
                MessageBox.Show("Xoa thanh cong");

            }
            else {
                MessageBox.Show("Xoa that bai");
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dt.sua(txtmakhoa.Text,txttenkhoa.Text)&& txtmakhoa.Text!=null)
            {
                MessageBox.Show("Update thanh cong ");
            }
            else {
                MessageBox.Show("Update that bai ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(dt.loadkhoa());
        }
    }
}
