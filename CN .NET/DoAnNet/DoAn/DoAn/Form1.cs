using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void PNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Phieunhap themspt = new Phieunhap();
            themspt.MdiParent = this;
            themspt.Show();
        }

        private void taohoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon thd = new Hoadon();
            thd.MdiParent = this;
            thd.Show();
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang nv = new KhachHang();
            nv.MdiParent = this;
            nv.Show();
        }

      

        
    }
}
