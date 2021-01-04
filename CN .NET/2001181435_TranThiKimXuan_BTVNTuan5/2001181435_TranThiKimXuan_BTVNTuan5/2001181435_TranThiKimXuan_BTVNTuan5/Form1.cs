using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_BTVNTuan5
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        xuly dt = new xuly();

        private void btnnhap_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtnhap.Text);
                
                if (dt.KT(listBox1, a) == false)
                {
                    listBox1.Items.Add(a);
                }
                else {
                    MessageBox.Show("Trùng!!!");
                }
               

                txtnhap.Clear();
                txtnhap.Focus();
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập hoặc nhập không phải số!!!");
            }
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tổng listbox: "+ dt.Tong(listBox1).ToString());
        }

        private void btnxoadaucuoi_Click(object sender, EventArgs e)
        {
            dt.XoaPTdauCuoi(listBox1);
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                dt.XpaPTdangchon(listBox1);
            }
            else {
                MessageBox.Show("Chưa chọn phần từ !!!");
            }
        }

        private void btntanglen2_Click(object sender, EventArgs e)
        {
            dt.TangPtlen2(listBox1);
        }

        private void btnthaybinhphuong_Click(object sender, EventArgs e)
        {
            dt.thaybangbinhphuong(listBox1);
        }

        private void btnchonsochan_Click(object sender, EventArgs e)
        {
            dt.Chonsochan(listBox1);
        }

        private void btnchonsole_Click(object sender, EventArgs e)
        {
            dt.Chonsole(listBox1);
        }

       
    }
}
