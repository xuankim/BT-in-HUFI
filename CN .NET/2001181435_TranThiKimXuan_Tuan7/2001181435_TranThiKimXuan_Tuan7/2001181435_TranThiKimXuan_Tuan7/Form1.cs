using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bt1 bt1 = new Bt1();
            bt1.MdiParent = this;
            bt1.Show();
            
        }

        private void bT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bt2kethua bt2 = new Bt2kethua();
            bt2.MdiParent = this;
            bt2.Show();
        }
    }
}
