using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181078_NguyenTranPhuongDuy_Buoi3
{
    public partial class myInfomation : Form
    {
        public myInfomation()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Handle hd = new Handle();
            if (errorProvider1.GetError(txtName).Trim().Length == 0 && errorProvider2.GetError(txtYear).Trim().Length == 0 && txtYear.Text.Length != 0)
                MessageBox.Show(hd.showInfomation(txtName.Text,txtYear.Text), "Thông Báo");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtYear.Text = "";
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
                errorProvider1.SetError(txtName, "Vui long nhap Ten");
            else errorProvider1.Clear();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtYear.Text.Length != 0)
            {
                int countNotDigit = 0;

                foreach (char charTxtYear in txtYear.Text)
                    if (!char.IsDigit(charTxtYear))
                        countNotDigit++;

                if (countNotDigit > 0)
                        errorProvider2.SetError(txtYear, "Ban nhap khong phai so");
                else
                    if (txtYear.Text[0] == '0')
                        errorProvider2.SetError(txtYear, "Ban nhap khong dung dinh dang");
                    else
                        errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(txtYear, "Vui long nhap Nam Sinh");
            }
                

        }

        private void myInfomation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.No) 
                e.Cancel = true;
        }

    }
}
