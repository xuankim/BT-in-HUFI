using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan4
{
    public partial class CheckDH : Form
    {
        public CheckDH()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void rdAuto_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void rdgreen_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void rdblue_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Font = new Font(label1.Font, FontStyle.Regular);
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {

                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }      

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label1.Font = new Font(label1.Font, FontStyle.Bold);
            }
            else { label1.Font = new Font(label1.Font, FontStyle.Regular); }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, (FontStyle)(FontStyle.Bold | FontStyle.Italic));
        }

        
    }
}
