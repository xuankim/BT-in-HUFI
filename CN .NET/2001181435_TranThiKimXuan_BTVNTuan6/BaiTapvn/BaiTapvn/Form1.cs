using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt2 bt2 = new bt2();
            bt2.MdiParent = this;
            bt2.Show();
            
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt1 bt1 = new bt1();
            bt1.MdiParent = this;
            bt1.Show();
        }
    }
}
