using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_BTVNTuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txthovaten_Leave(object sender, EventArgs e)
        {

            if (txthovaten.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txthovaten, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtdiachi_Leave(object sender, EventArgs e)
        {

            if (txtdiachi.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtdiachi, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void songayo_Leave(object sender, EventArgs e)
        {

            if (songayo.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(songayo, "Ban khong duoc de trong!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void songayo_TextChanged(object sender, EventArgs e)
        {
            char kytucuoi = songayo.Text[songayo.Text.Length - 1];
            if (!char.IsDigit(kytucuoi))
            {
                errorProvider1.SetError(songayo, "Ban nhap khong phai so");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txthovaten_Click(object sender, EventArgs e)
        {
         
            //rdphongdon.Checked = false;
            //foreach (RadioButton rd in groupBoxLPhong.Controls.OfType<RadioButton>())
            //{
            //    if (rd.Checked==false)
            //    {
            //        btnthanhtoan.Enabled = false;
            //        btntongket.Enabled = false;
            //        btnnhapmoi.Enabled = false;
                    
            //    }
            //    else if (rd.Checked == true)
            //    {
            //        btnthanhtoan.Enabled = true;
            //        btntongket.Enabled = true;
            //        btnnhapmoi.Enabled = true;
            //    }
            //}
        }

       
        public int count;       
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            
            float tiendv = 0;

            if (ckansang.Checked == true)
            { tiendv = 15 * int.Parse(songayo.Text); }
            else if(ckkara.Checked==true)
            { tiendv = 50; }
            
           
                float tien = 0;
                if (rdphong3.Checked||rdphongdon.Checked||rdphongdoi.Checked)
                {
                    if (rdphongdon.Checked == true)
                    { tien = int.Parse(songayo.Text) * 300; }

                    else if (rdphongdoi.Checked == true)

                    { tien = int.Parse(songayo.Text) * 350; }

                    else if (rdphong3.Checked == true)

                    { tien = int.Parse(songayo.Text) * 400; }
                }
                else {
                    MessageBox.Show("Bạn chưa chọn loại phòng!!!");
                }
            

            float tientnghi = 0;
            foreach (CheckBox box in groupBoxTnghi.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    count++;
                }
                tientnghi = count * 10;
            }
           
           
           txtthanhtien.Text = (tientnghi+tien+tiendv).ToString();
             
    }

        public void en(Control item) {
            if (item.GetType() == typeof(RadioButton)) {
                RadioButton rd = (RadioButton)item;
                rd.Checked = false;
                return;
            }
            if (item.GetType() == typeof(CheckBox))
            {
                CheckBox ck = (CheckBox)item;
                ck.Checked = false;
                return;
            }
            foreach (Control it in item.Controls) {
                en(it);
            }
        }

        private void btnnhapmoi_Click(object sender, EventArgs e)
        {
            en(this);
            txthovaten.Text = " ";
            txtdiachi.Text = " ";
            songayo.Text = " ";
            txthovaten.Focus();
            btnnhapmoi.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
            
                                       
    }
}
