using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        xuly xl = new xuly();
        private void button1_Click(object sender, EventArgs e)
        {
            //if (xl.KTDN(tendn.Text, Password.Text) == false)
            //{

            //    MessageBox.Show("That bại");

            //}
            //else {
                Form1 frmain = new Form1();
                frmain.Show();
           // }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
