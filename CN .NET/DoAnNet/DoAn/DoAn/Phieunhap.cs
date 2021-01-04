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
    public partial class Phieunhap : Form
    {
        xuly xl = new xuly();


        public Phieunhap()
        {
            InitializeComponent();
        }
        public void load() {
            dataGridView1.DataSource = xl.LoadTable("CTPHIEUNHAP");

            cbnhacc.DataSource = xl.LoadTable("NHACC");
            cbnhacc.DisplayMember = "TENNCC";
            cbnhacc.ValueMember = "IDNCC";

            cbmaphieunhap.DataSource = xl.LoadTable("PHIEUNHAP");
            cbmaphieunhap.DisplayMember = "IDPHIEUNHAP";
            cbmaphieunhap.ValueMember = "IDPHIEUNHAP";

            cbmasp.DataSource = xl.LoadTable("SANPHAM");
            cbmasp.DisplayMember = "TENSP";
            cbmasp.ValueMember = "MASP";

            txtsoluongnhap.Clear();
            txtdongianhap.Clear();
        }
        private void Phieunhap_Load(object sender, EventArgs e)
        {           
                load();            
        }
                
        private void btnluuphieunhap_Click(object sender, EventArgs e)
        {
            
                xl.luuPhieunhap();
                load();
                if (xl.luuPhieunhap() == true) {
                    MessageBox.Show("Đã lưu phiếu nhập");
                }            
        }

        private void btntaophieunhap_Click(object sender, EventArgs e)
        {
                        
            DateTime ngaylappn = dateTimePicker1.Value.Date;
            string manhcc = cbnhacc.SelectedValue.ToString();
            xl.themphieunhap(txtmapn.Text, ngaylappn, manhcc);
            load();
            txtmapn.Clear();
        }
                    
        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            
            string mapn = cbmaphieunhap.SelectedValue.ToString();
            string msp = cbmasp.SelectedValue.ToString();
            int slnhap = int.Parse(txtsoluongnhap.Text);
            float dongianhap = float.Parse(txtdongianhap.Text);
            

            
            xl.themCTphieunhap(mapn, msp, dongianhap, slnhap);
            load();
        }

        private void btnluuchitiet_Click(object sender, EventArgs e)
        {
            bool r=xl.luuPhieunhap();
           
            load();
            if (r == true)
            {
                MessageBox.Show("Đã lưu chi tiết phiếu nhập");
            }
        }

        private void Phieunhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                xl.luuPhieunhap();
            } 
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapn = cbmaphieunhap.SelectedValue.ToString();
            string masp = cbmasp.SelectedValue.ToString();
          bool r= xl.suaPN(mapn,masp,float.Parse(txtdongianhap.Text),int.Parse(txtsoluongnhap.Text));
            if( r)
                
            {
                load();
                MessageBox.Show("Thanh công");
               
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

       

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapn = cbmaphieunhap.SelectedValue.ToString();
            string masp = cbmasp.SelectedValue.ToString();
            bool result = xl.xoaPN(mapn, masp);
            
            if (result)
            {
                load();
                MessageBox.Show("Thanh công");
                
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentRow.Index;
            cbmaphieunhap.SelectedValue = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            cbmasp.SelectedValue = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            txtdongianhap.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            txtsoluongnhap.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
        }

        private void cbmaphieunhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string mapn = cbmaphieunhap.SelectedValue.ToString();
            if (mapn != "System.Data.DataRowView")
            {
                txtthanhtien.Text = xl.TinhThanhTien(mapn).ToString();
            }
           

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

       

       

       

       

       
    

        
    }
}
