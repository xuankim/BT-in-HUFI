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
    public partial class bt2 : Form
    {
        public bt2()
        {
            InitializeComponent();
        }
        Dssinhvien ds = new Dssinhvien();
        public void loaddata() {
            txtmaso.Clear();
            txthoten.Clear();
            if (radionam.Checked)
            {
                radionam.Checked = false;
            }
            else {
                radionu.Checked = false;
            }
            ckanh.Checked = chkhoa.Checked = checkBoxphap.Checked = false;
           
            listView1.Items.Clear();
            listView1.Items.AddRange(ds.DSSV1());
        }
        private void bt2_Load(object sender, EventArgs e)
        {
            listView1.Items.AddRange(ds.DSSV1());
            ds.DSSVCB(comboBox1);
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            if (ds.kttrung(txtmaso.Text))
            {
                MessageBox.Show("Trung");
            }
            else
            {
                List<string> lstLanguage = new List<string>();
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = (CheckBox)c;
                        if (cb.Checked == true)
                            lstLanguage.Add(cb.Text.Trim());

                    }
                }
                string strLanguage = string.Join(",", lstLanguage);
                ds.themSv(txthoten.Text, txtmaso.Text, gioitinh, strLanguage, dantoc);
                loaddata();
            }
        }
        string gioitinh;
        private void radionam_CheckedChanged(object sender, EventArgs e)
        {
            if (radionam.Checked) {
                gioitinh = "Nam";
            }            
        }
        string ngoaingu;
        private void ckanh_CheckedChanged(object sender, EventArgs e)
        {

            if (ckanh.Checked) {
                ngoaingu = "Anh";
            }
           
        }
        string dantoc;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dantoc = comboBox1.SelectedItem.ToString();
        }

        private void radionu_CheckedChanged(object sender, EventArgs e)
        {
            if (radionu.Checked)
            {
                gioitinh = "Nữ";
            }
        }

        private void checkBoxphap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxphap.Checked)
            {
                ngoaingu += "Pháp";
            }
        }

        private void chkhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhoa.Checked)
            {
                ngoaingu += "Hoa";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
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
                MessageBox.Show("Chua chon!!!");
            }
            }
            catch{
           
                MessageBox.Show("Chua chon!!!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                ListViewItem itemdangchon = listView1.FocusedItem;
                txtmaso.Text = itemdangchon.SubItems[1].Text.ToString();
                txthoten.Text = itemdangchon.SubItems[0].Text.ToString();
                // Check Gender
                string Gender = itemdangchon.SubItems[2].Text;
                if (Gender == "Nam")
                    radionam.Checked = true;
                else radionu.Checked = true;
                // Check Language
                List<string> Language = itemdangchon.SubItems[3].Text.Trim().Split(',').ToList<string>();
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = (CheckBox)c;
                        if (Language.IndexOf(cb.Text.Trim()) != -1)
                            cb.Checked = true;
                        else
                            cb.Checked = false;
                    }
                }
                comboBox1.Text = itemdangchon.SubItems[4].Text;
            }
            
            }

        private void button3_Click(object sender, EventArgs e)
        {
        if (ds.Update(txthoten.Text, txtmaso.Text, gioitinh, ngoaingu, dantoc))
            {
                loaddata();
                MessageBox.Show("Update thanh công");
               
            }
            else {
                MessageBox.Show("Sửa thất bại");
            }
        }       

        
              

    }
}
