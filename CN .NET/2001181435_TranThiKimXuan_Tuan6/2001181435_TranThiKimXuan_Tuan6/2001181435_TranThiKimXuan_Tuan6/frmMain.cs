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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnxoaphongban frm1 = new btnxoaphongban();
            frm1.MdiParent = this;
            frm1.Show();
        }

       
    }
}
