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
    public partial class btndong : Form
    {

        xuly dt = new xuly(); 
        public btndong()
        {
            InitializeComponent();
        }

        private void btndong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.loadlopkhoa();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
