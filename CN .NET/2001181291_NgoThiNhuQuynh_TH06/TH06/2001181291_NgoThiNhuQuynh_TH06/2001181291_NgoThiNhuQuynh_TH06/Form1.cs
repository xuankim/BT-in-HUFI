using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181291_NgoThiNhuQuynh_TH06
{
    public partial class Form1 : Form
    {
        Handles.NhanVienHandle nvHandle = new Handles.NhanVienHandle();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnThemPb_Click(object sender, EventArgs e)
        {
            if (!nvHandle.findIndexPB(txtPhongBan.Text))
            {
                nvHandle.addRoot(txtPhongBan.Text);
                loadData();
            }
        }

        public void loadData()
        {
            treeView1.Nodes.Clear();
            cboPB.Items.Clear();
            treeView1.Nodes.AddRange(nvHandle.Load());
            foreach (TreeNode item in treeView1.Nodes)
            {
                item.Nodes.AddRange(nvHandle.loadDSNV(item.Tag.ToString()));
                
                cboPB.Items.Add(item.Text.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            nvHandle.init();
            loadData();         
        }
    }
}
