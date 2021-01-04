using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            
        }
       

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern= @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
       @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if(Regex.IsMatch(txtemail.Text,pattern)){
            errorProvider2.Clear();
            }
            else{
            errorProvider2.SetError(this.txtemail,"Nhập đúng định dang email!!!");
            }

            if (txtemail.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtemail, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {

            if (txtmatkhau.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtmatkhau, "Ban khong duoc de trong!");
              
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtxnhanmk_TextChanged(object sender, EventArgs e)
        {
           
            txtxnhanmk.PasswordChar = '\u25CF';
            if (txtxnhanmk.Text != txtmatkhau.Text)
            {
                errorProvider3.SetError(txtxnhanmk, "Nhap maatk khẩu giống với mật khẩu đã nhập !!!");
               
            }
            else {
                errorProvider3.Clear();
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            txtmatkhau.PasswordChar = '\u25CF';
            if (txtmatkhau.Text.Length < 8)
            {
                errorProvider4.SetError(txtmatkhau, "Mat khau dai it nhất 8 kí tự");
            }
            else {
                errorProvider4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TenDN: "+txtendnhap.Text+"\n"+"Email: "+txtemail.Text+"\n"+"Mật Khẩu: "+txtmatkhau.Text);
        }

        private void txtendnhap_Leave(object sender, EventArgs e)
        {

            if (txtendnhap.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtendnhap, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }                       
        }
    }

