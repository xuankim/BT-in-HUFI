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
    public partial class Bt1 : Form
    {

        Dssinhvien ds = new Dssinhvien();
        public Bt1()
        {
            InitializeComponent();
        }

        private void Bt1_Load(object sender, EventArgs e)
        {
            listView1.Items.AddRange(ds.DSSV1());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null) {
                ListViewItem itemdangchon = listView1.FocusedItem;
                txtmaso.Text = itemdangchon.SubItems[1].Text.ToString();
                txthoten.Text = itemdangchon.SubItems[2].Text.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ds.kttrung(txtmaso.Text))
            {
                MessageBox.Show("Trung");
            }
            else
            {
                ds.themSv(txtmaso.Text, txthoten.Text);
                listView1.Items.Clear();
                listView1.Items.AddRange(ds.DSSV1());
            }
        }

        public void loaddata() {
            txtmaso.Clear();
              txthoten.Clear();
              listView1.Items.Clear();
              listView1.Items.AddRange(ds.DSSV1());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string mssv = listView1.FocusedItem.SubItems[1].Text.Trim();
            if (mssv.Count() > 0 && txtmaso.Text.Trim() == mssv && ds.kttrung(txtmaso.Text.Trim()))
            {
                ds.xoa(mssv);
                listView1.FocusedItem.Remove();
                txtmaso.Clear();
                txthoten.Clear();
            }
            else
            {
                MessageBox.Show("Chua chon!!");
            }


            //if (listView1.FocusedItem != null)
            //{
            //    ds.xoa(txtmaso.Text);
            //    loaddata();
            //}
            //else {
            //    MessageBox.Show("Chua chon!!!");
            //}
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ds.sua(txtmaso.Text, txthoten.Text);
            loaddata();
        }
    }
}
