using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        xuly dt = new xuly();
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgrviewbangdiem.DataSource = dt.loadTable("ThongTin");


            cbmonhoc.DataSource = dt.loadTable("MonHoc");
            cbmonhoc.DisplayMember = "TenMonHoc";
            cbmonhoc.ValueMember = "MaMonHoc";

            cbtensinhvien.DataSource = dt.loadTable("SINHVIEN");
            cbtensinhvien.DisplayMember = "HoTen";
            cbtensinhvien.ValueMember = "MaSinhVien";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (LoadDiem().Length == 0)
            {

                dt.themdiem(cbtensinhvien, cbmonhoc, txtdiem);
               

            }

        }
        
        private void cbtensinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtdiem.Text = LoadDiem();

        }
        
        private void cbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdiem.Text = LoadDiem();
        }

        private string LoadDiem()
        {
            string masv = (cbtensinhvien.SelectedValue != null)?cbtensinhvien.SelectedValue.ToString():"";
            string mamonhoc = (cbmonhoc.SelectedValue != null) ? cbmonhoc.SelectedValue.ToString() : "";
            return dt.layDiem(masv,mamonhoc);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string masv = (cbtensinhvien.SelectedValue != null)?cbtensinhvien.SelectedValue.ToString():"";
            string mamonhoc = (cbmonhoc.SelectedValue != null) ? cbmonhoc.SelectedValue.ToString() : "";
            float diem=float.Parse(txtdiem.Text);
            if (dt.sua(masv, mamonhoc, diem))
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                dt.luu();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string masv = (cbtensinhvien.SelectedValue != null) ? cbtensinhvien.SelectedValue.ToString() : "";
            string mamonhoc = (cbmonhoc.SelectedValue != null) ? cbmonhoc.SelectedValue.ToString() : "";
            
            if (dt.Xoa(masv, mamonhoc))
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dtgrviewbangdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
               cbtensinhvien.Text = dtgrviewbangdiem.Rows[e.RowIndex].Cells[1].Value.ToString();
               cbmonhoc.Text = dtgrviewbangdiem.Rows[e.RowIndex].Cells[4].Value.ToString();

               string masv = dtgrviewbangdiem.Rows[e.RowIndex].Cells[0].Value.ToString();
               string mamh = dtgrviewbangdiem.Rows[e.RowIndex].Cells[3].Value.ToString();
               txtdiem.Text = dt.layDiem(masv,mamh);
            }

        }


    }
}
