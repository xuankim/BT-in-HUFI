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
    public partial class bt1 : Form
    {
        private System.Windows.Forms.Timer aTimer;
        public bt1()
        {
            InitializeComponent();
        }
        private int counter = 30;
        private void bt1_Load(object sender, EventArgs e)
        {
            label2.Text = counter.ToString()+":00";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(aTimer_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();
            label1.Text = counter.ToString();
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {

            counter--;

            if (counter == 0)

                aTimer.Stop();

            label1.Text = counter.ToString();

        }
    }
}
