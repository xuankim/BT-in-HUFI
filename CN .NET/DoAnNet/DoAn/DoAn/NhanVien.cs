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
    public partial class NhanVien : Form
    {
        
        xuly xl = new xuly();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void load()
        {
            dGV_CT_NV.DataSource = xl.LoadTable("NHANVIEN");

        }
        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            foreach (Control txt in tlpThemNV.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Text = string.Empty;
                }

            }
        }

        private void btn_Save_NV_Click(object sender, EventArgs e)
        {
            xl.luunhanvien(txtC_MaNV, txtC_TenNV, txtC_Email_NV, txtC_SDT_NV, txtC_DiaChi_NV, dTP_NgSinh_NV, dTP_NVL_NV,txtC_HSL,txtC_GioLV);
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            string masv = (txtC_MaNV.Text != null) ? txtC_MaNV.Text.ToString() : "";

            if (xl.xoanhanvien(masv))
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dGV_CT_NV_MouseClick(object sender, MouseEventArgs e)
        {
            if (dGV_CT_NV.SelectedRows.Count > 0)
            {
                txtC_MaNV.Text = dGV_CT_NV.SelectedRows[0].Cells[0].Value.ToString();
                txtC_TenNV.Text = dGV_CT_NV.SelectedRows[0].Cells[1].Value.ToString();
                txtC_Email_NV.Text = dGV_CT_NV.SelectedRows[0].Cells[2].Value.ToString();
                txtC_SDT_NV.Text = dGV_CT_NV.SelectedRows[0].Cells[4].Value.ToString();
                txtC_DiaChi_NV.Text = dGV_CT_NV.SelectedRows[0].Cells[3].Value.ToString();
                dTP_NgSinh_NV.Value = Convert.ToDateTime(dGV_CT_NV.SelectedRows[0].Cells[5].Value.ToString());
                dTP_NVL_NV.Value = Convert.ToDateTime(dGV_CT_NV.SelectedRows[0].Cells[6].Value.ToString());
                txtC_HSL.Text = dGV_CT_NV.SelectedRows[0].Cells[7].Value.ToString();
                txtC_GioLV.Text = dGV_CT_NV.SelectedRows[0].Cells[8].Value.ToString();
            }
        }
       

    }
    }

