using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan14
{
    public partial class Form2 : Form
    {
        xuly XL = new xuly();
        public Form2()
        {
            InitializeComponent();
        }

        private void cbcoso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }      
        private void Form2_Load(object sender, EventArgs e)
        {
            cbcoso.DataSource = XL.loadTable("COSO");
            cbcoso.DisplayMember = "TENCOSO";
            cbcoso.ValueMember = "MACOSO";
        }
    }
}
