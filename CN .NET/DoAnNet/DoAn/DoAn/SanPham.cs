using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        xuly xl = new xuly();
        public void load() {
            dataGridView1.DataSource = xl.LoadTable("SANPHAM");

            cbthuonghieu.DataSource = xl.LoadTable("THUONGHIEU");
            cbthuonghieu.DisplayMember = "IDTHUONGHIEU";
            cbthuonghieu.ValueMember = "IDTHUONGHIEU";

            txtmasp.Clear();
            txttensp.Clear();
            if (rdnam.Checked)
                rdnam.Checked = false;
            else rdnu.Checked = false;
            lblUploadResult.Clear();
            if (rd37.Checked)
                rd37.Checked = false;
            else if (rd38.Checked)
                rd38.Checked = false;
            else rd39.Checked = false;
            txtsoluongsp.Clear();
            txtdongiaban.Clear();
            txtmota.Clear();
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

        
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;

                string[] f = file.Split('\\');
                // to get the only file name
                string fn = f[(f.Length) - 1];
                string dest = @"C:\Users\Admin\Documents\DoAnNet\DoAn\DoAn\anh" + fn;

                //to copy the file to the destination folder
                File.Copy(file, dest, true);

                lblUploadResult.Text = fn;
            }

        }
      
       
        public string layloai() {
            string loai;
            if (rdnam.Checked == true)
            {
               return loai = rdnam.Text;
            }
            else if (rdnu.Checked == true)
            {
               return loai = rdnu.Text;
            }
            return "";
        }
        public int laysize() {
            int size;
            if (rd37.Checked == true)
            {
               return size = int.Parse(rd37.Text);
            }
            else if (rd38.Checked)
            {
                return size = int.Parse(rd38.Text);
            }
            else if (rd39.Checked)
            {
                return size = int.Parse(rd39.Text);
            }
            else {
                return 0;
            }
            
        }
        //thêm sản phẩm
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
            string loais=layloai();
            int sizes=laysize();
            string file = openFileDialog1.FileName;

            string[] f = file.Split('\\');
            // to get the only file name
            string fn = f[(f.Length) - 1];
            string idthuonghieu = cbthuonghieu.SelectedValue.ToString();
            if(laysize()==0||layloai()==""){
                MessageBox.Show("Chú ý nhập đủ thông tin");
            }else{
             xl.themsp(txtmasp.Text,idthuonghieu,txttensp.Text,sizes,loais,float.Parse(txtdongiaban.Text),int.Parse( txtsoluongsp.Text),fn,txtmota.Text);
            }
        }

       
        

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string loais;
            int sizes;
            if (rd37.Checked == true)
                sizes = 37;
            else if (rd38.Checked == true)
                sizes = 38;
            else sizes = 39;

            if (rdnam.Checked == true)
                loais = "Nam";
            else loais = "Nữ";
            string math = (cbthuonghieu.SelectedValue != null) ? cbthuonghieu.SelectedValue.ToString() : "";

          bool r=  xl.suaSP(txtmasp.Text, math, txttensp.Text, sizes, loais, float.Parse(txtdongiaban.Text), int.Parse(txtsoluongsp.Text), lblUploadResult.Text, txtmota.Text);
          load();
            if (r)
             {
               
                 MessageBox.Show("Thanh công");
             }
             else
             {
                 MessageBox.Show("That bai");
             }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
           
            string loais;
            int sizes;
            if (rd37.Checked == true)
                sizes = 37;
            else if (rd38.Checked == true)
                sizes = 38;
            else sizes = 39;

            if (rdnam.Checked == true)
                loais = "Nam";
            else loais = "Nữ";
            string math = (cbthuonghieu.SelectedValue != null) ? cbthuonghieu.SelectedValue.ToString() : "";


           bool r= xl.suaSP(txtmasp.Text, math, txttensp.Text, sizes, loais, float.Parse(txtdongiaban.Text), int.Parse(txtsoluongsp.Text), lblUploadResult.Text, txtmota.Text);
            if (r)
            {
                load();
                MessageBox.Show("Thanh công");
                
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            
            xl.luuSanPham();
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string math = (cbthuonghieu.SelectedValue != null) ? cbthuonghieu.SelectedValue.ToString() : "";
            if (txtmasp.Text == "") {
                MessageBox.Show("Bạn chưa chọn dòng muốn xóa");
            }
            else
            {
                xl.xoasp(txtmasp.Text, math);
                load();
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                xl.luuSanPham();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string math = (cbthuonghieu.SelectedValue != null) ? cbthuonghieu.SelectedValue.ToString() : "";
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dòng muốn xóa");
            }
            else
            {
                xl.xoasp(txtmasp.Text, math);
                load();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string file = openFileDialog1.FileName;

            string[] f = file.Split('\\');
            // to get the only file name
            string fn = f[(f.Length) - 1];
            string dest = @"C:\Users\Admin\Documents\DoAnNet\DoAn\DoAn\anh" + fn;

            pictureBox1.Image = Image.FromFile(dest);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentRow.Index;
            txtmasp.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            cbthuonghieu.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            txttensp.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            string size = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            if (size == "37")

                rd37.Checked = true;

            else if (size == "38")
                rd38.Checked = true;
            else if (size == "39")
                rd39.Checked = true;
            string loai = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            if (loai == "Nam")
                rdnam.Checked = true;
            else rdnu.Checked = true;
            txtdongiaban.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            txtsoluongsp.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
            lblUploadResult.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            txtmota.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();

            string file = openFileDialog1.FileName;

            string[] f = file.Split('\\');
            // to get the only file name
            string fn = f[(f.Length) - 1];
            string dest = @"C:\Users\Admin\Documents\DoAnNet\DoAn\DoAn\anh\" + dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            //pictureBox1.Load(dest);

            pictureBox1.Image = Image.FromFile(dest);
            //pictureBox1.Load(dataGridView1.Rows[row_index].Cells[7].Value.ToString());

        }

        private void toolStripLabel3_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

       

        
    }

                           
        
    }

