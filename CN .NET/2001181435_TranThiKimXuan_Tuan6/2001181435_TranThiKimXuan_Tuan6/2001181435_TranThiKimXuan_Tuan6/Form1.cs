using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan6
{
    public partial class btnxoaphongban : Form
    {
        xuly dt = new xuly();
        public btnxoaphongban()
        {
            InitializeComponent();
        }
        public void Loaddt()
        {
            treeView1.Nodes.Clear();
            comboBox1.Items.Clear();
            // dt.Them2(comboBox1);
            treeView1.Nodes.AddRange(dt.Loadtree());
            foreach (TreeNode item in treeView1.Nodes)
            {
                item.Nodes.AddRange(dt.LoadDSNV(item.Tag.ToString()));
                comboBox1.Items.Add(item.Text.ToString());
            }


        }
        private void btnthemphongban_Click(object sender, EventArgs e)
        {
            if (txtnhapphongban.Text != "")
            {
                if (!dt.Kt(txtnhapphongban.Text))
                {
                    dt.Themroot(txtnhapphongban.Text);
                    Loaddt();
                    txtnhapphongban.Clear();
                }
                else
                {
                    MessageBox.Show("Trùng phòng ban!!!");
                    txtnhapphongban.Clear();

                }

            }
            else
            {
                MessageBox.Show("Chưa nhập phòng ban!!!");
            }


        }

        private void btnxoaphongban_Load(object sender, EventArgs e)
        {
            dt.init();
            Loaddt();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoaphongban_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MaNV = txtmaso.Text;
            string HoTen = txthoten.Text;
            string DiaChi = txtdiachi.Text;
            string TenPB = comboBox1.Text;
            if (!dt.isIssetNV(MaNV))
            {
                dt.AddNhanVien(MaNV, HoTen, DiaChi, TenPB);
                Loaddt();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {



            TreeNode selectNode = treeView1.SelectedNode;
            if (treeView1.Nodes.IndexOf(selectNode) != -1)
            {
                dt.DeletePhongBan(selectNode.Tag.ToString());
                Loaddt();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //TreeNode selectNode = treeView1.SelectedNode;
            //if (treeView1.Nodes.IndexOf(selectNode) == -1)
            //{
            //    NhanVien nv = dt.findNhanVien(selectNode.Tag.ToString());
            //    txtmaso.Text = nv.Mnv;
            //    txthoten.Text = nv.Tennv;
            //    txtdiachi.Text = nv.Diachi;
            //    comboBox1.Text = .Where(t => t.MaPB == nv.MaPB).Select(x => x.TenPB.ToString()).ToArray<string>()[0];
            //}

        }

    }
    
}
