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
    public partial class BanVeRapChieuPhim : Form
    {
        public BanVeRapChieuPhim()
        {
            InitializeComponent();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            Button[] Tombol1 = new Button[] { button1, button2, button3, button4, button5};
            Button[] Tombol2 = new Button[] { button6, button7, button8, button9, button10 };
            Button[] Tombol3 = new Button[] { button11, button12, button13, button14, button15 };
            int counterbutton= 0;
            int tien1,tien2,tien3 = 0;
            foreach (Button btn in Tombol1)
            {
                if (btn.BackColor == Color.Blue)
                    counterbutton++;
                
            }
            tien1 = counterbutton * 1000;
            foreach (Button btn in Tombol2)
            {
                if (btn.BackColor == Color.Blue)
                    counterbutton++;                
            }
            tien2 = counterbutton * 1500;
            foreach (Button btn in Tombol3)
            {
                if (btn.BackColor == Color.Blue)
                    counterbutton++;
                tien3 = counterbutton * 2000;
            }
            
           //int tien=0;
           // tien= tien1+tien2+tien3;
           // txtthanhtien.Text = tien.ToString();
            MessageBox.Show(counterbutton.ToString());
        }


    }
}
