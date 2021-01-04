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
    public partial class KhachHang : Form
    {
        xuly xl = new xuly();
        public KhachHang()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.DataSource = xl.LoadTable("KHACHHANG");

        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtC_MaKH.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtC_TenKH.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtC_Email.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtC_SDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtC_DiaChi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dTP_NgSinh.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());

            }
        }

        private void btntaokhachhang_Click(object sender, EventArgs e)
        {
            foreach (Control txt in tlpThemKH.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Text = string.Empty;
                }

            }

        }

        private void btnluukhachhang_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string makh = (txtC_MaKH.Text != null) ? txtC_MaKH.Text.ToString() : "";

            if (xl.xoaKhachhang(makh))
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
