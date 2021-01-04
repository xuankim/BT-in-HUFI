using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        xuly xl = new xuly();
        public void load()
        {
            dataGridView1.DataSource = xl.LoadTable("CTPHIEUNHAP");

            cbnhacc.DataSource = xl.LoadTable("NHACC");
            cbnhacc.DisplayMember = "TENNCC";
            cbnhacc.ValueMember = "IDNCC";

            cbmapn.DataSource = xl.LoadTable("PHIEUNHAP");
            cbmapn.DisplayMember = "IDPHIEUNHAP";
            cbmapn.ValueMember = "IDPHIEUNHAP";

            cbmasp.DataSource = xl.LoadTable("SANPHAM");
            cbmasp.DisplayMember = "TENSP";
            cbmasp.ValueMember = "MASP";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime ngaylappn = dateTimePicker1.Value.Date;
            string manhcc = cbnhacc.SelectedValue.ToString();
            xl.themphieunhap(txtmapn.Text, ngaylappn, manhcc);
            load();
            txtmapn.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            xl.luuPhieunhap();
            load();
            if (xl.luuPhieunhap() == true)
            {
                MessageBox.Show("Đã lưu phiếu nhập");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mapn = cbmapn.SelectedValue.ToString();
            string msp = cbmasp.SelectedValue.ToString();
            int slnhap = int.Parse(txtslnhap.Text);
            float dongianhap = float.Parse(txtdongianhap.Text);
            xl.themCTphieunhap(mapn, msp, dongianhap, slnhap);
            load();
        }

        private void btnluuphiuenhap_Click(object sender, EventArgs e)
        {
            xl.luuPhieunhap();
            load();
            if (xl.luuPhieunhap() == true)
            {
                MessageBox.Show("Đã lưu chi tiết phiếu nhập");
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string mapn = (cbmapn.SelectedValue != null) ? cbmapn.SelectedValue.ToString() : "";
            string masp = (cbmasp.SelectedValue != null) ? cbmasp.SelectedValue.ToString() : "";
           
            if (xl.sua(mapn,masp,float.Parse( txtdongianhap.Text),int.Parse( txtslnhap.Text)))
            {
                
                xl.luuPhieunhap();
                load();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                cbmapn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmasp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdongianhap.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtslnhap.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapn = (cbmapn.SelectedValue != null) ? cbmapn.SelectedValue.ToString() : "";
            string masp = (cbmasp.SelectedValue != null) ? cbmasp.SelectedValue.ToString() : "";

            if (xl.xoa(mapn, masp))
            {
                MessageBox.Show("Thanh cong");
                xl.luuPhieunhap();
                load();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
       
        
      
        

       

       
    }
}
