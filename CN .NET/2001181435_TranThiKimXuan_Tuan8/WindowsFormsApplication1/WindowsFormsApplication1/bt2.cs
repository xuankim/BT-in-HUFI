﻿using System;
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
    public partial class bt2 : Form
    {
        xuly dt = new xuly();
        public bt2()
        {
            InitializeComponent();
        }

        private void bt2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(dt.loadlop());
        }
    }
}
