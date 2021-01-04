using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        xuly dt = new xuly(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.loadKhoa();
        }

        private void btnthem_Click(object sender, EventArgs e)

        {

            if (dt.ktrong(txtmakhoa.Text,txttenkhoa.Text)==false)
            {
                if (dt.Themkhoa(txtmakhoa.Text, txttenkhoa.Text))
                {
                    MessageBox.Show("Them thanh cong!!");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
            else {
                MessageBox.Show(" that bai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
 
            if (dt.delete(txtmakhoa.Text))
            {
                MessageBox.Show("Thanh cong");
            }
            else {
                MessageBox.Show("That bai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dt.sua(txtmakhoa.Text, txttenkhoa.Text))
            {
                MessageBox.Show("Thanh cong");
            }
            else {
                MessageBox.Show("That bai");
            }
        }

        private void btndong_Click(object sender, EventArgs e)
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
            else {
                dt.luu();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtmakhoa.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenkhoa.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

       
       
    }
}
