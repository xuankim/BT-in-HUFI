using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        xuly xl = new xuly();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) > -1)
            {
                dataGridView1.DataSource = xl.filterLop(treeView1.SelectedNode.Tag.ToString());
            }
            else
            {
                if (treeView1.Nodes.IndexOf(treeView1.SelectedNode.Parent) > -1)
                {
                    dataGridView1.DataSource = xl.filterSV(treeView1.SelectedNode.Tag.ToString());
                }
              
                
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.IndexOf(treeView1.SelectedNode.Parent) > -1)
            {
                TreeNode select = treeView1.SelectedNode;
                TreeNode selectParent = treeView1.SelectedNode.Parent;
                string maLop = treeView1.SelectedNode.Tag.ToString();
                string maSV = txtmasinhvien.Text;
                string hoTen = txthoten.Text;
                DateTime ngaysinh = dateTimePicker1.Value.Date;

                xl.Themsv(maSV, hoTen, ngaysinh, maLop);
                UpdateData();
            }
        }

        private void UpdateData()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(xl.loadData());
        }
    }
}
