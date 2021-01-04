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
    public partial class Hoadon : Form
    {
        xuly xl = new xuly();
        public Hoadon()
        {
            InitializeComponent();
        }
        public void load() {
            dataGridView1.DataSource = xl.LoadTable("CTHD");

            cbmahoadoncitiet.DataSource = xl.LoadTable("HOADON");
            cbmahoadoncitiet.DisplayMember = "SOHD";
            cbmahoadoncitiet.ValueMember = "SOHD";

            cbsanpham.DataSource = xl.LoadTable("SANPHAM");
            cbsanpham.DisplayMember = "TENSP";
            cbsanpham.ValueMember = "MASP";

            cbnhanvien.DataSource = xl.LoadTable("NHANVIEN");
            cbnhanvien.DisplayMember = "HOTEN";
            cbnhanvien.ValueMember = "MANV";

            cbkhachhang.DataSource = xl.LoadTable("KHACHHANG");
            cbkhachhang.DisplayMember = "HOTEN";
            cbkhachhang.ValueMember = "MAKH";
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
            load();
        }      
        private void btntaohoadon_Click(object sender, EventArgs e)
        {
        
            DateTime ngaylaphd = dateTimePicker1.Value.Date;
            string manv=cbnhanvien.SelectedValue.ToString();
             string makh=cbkhachhang.SelectedValue.ToString();
            xl.themhoadon(txthoadon.Text,ngaylaphd,makh,manv);
            load();
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            xl.luuHoaDon();
            load();
            if (xl.luuHoaDon() == true)
            {
                MessageBox.Show("Đã lưu chi tiết phiếu nhập");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahd = (cbmahoadoncitiet.SelectedValue != null) ? cbmahoadoncitiet.SelectedValue.ToString() : "";
           string masp = (cbsanpham.SelectedValue != null) ? cbsanpham.SelectedValue.ToString() : "";
            xl.themcthoadon(mahd,masp,int.Parse(txtsoluong.Text),txtdongia.Text);
        }
        private string LoadDongia()
        {
            string masp = (cbsanpham.SelectedValue != null) ? cbsanpham.SelectedValue.ToString() : "";
           
            return xl.laydongia(masp);
        }

        private void cbsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdongia.Text = LoadDongia();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xl.luuHoaDon();
            if (xl.luuHoaDon() == true)
            {
                MessageBox.Show("Đã lưu chi tiết phiếu nhập");
            }
            else {
                MessageBox.Show("Thất bại");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            int row_index = dataGridView1.CurrentRow.Index;
            cbmahoadoncitiet.SelectedValue = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            cbsanpham.SelectedValue = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            txtsoluong.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            txtdongia.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
        }

        private void cbmahoadoncitiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahd = cbmahoadoncitiet.SelectedValue.ToString();
            if (mahd != "System.Data.DataRowView")
            {
                txtthanhtien.Text = xl.TinhThanhTienhd(mahd).ToString();
            }
        }
     

        
    }
}
