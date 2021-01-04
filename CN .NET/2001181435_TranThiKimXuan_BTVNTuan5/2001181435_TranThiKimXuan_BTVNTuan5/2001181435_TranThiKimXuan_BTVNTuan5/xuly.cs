using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_BTVNTuan5
{
    class xuly
    {
        //ListBox listbox = new ListBox();
        public bool KT(ListBox pcontrol, int value) {
            if (pcontrol.Items.IndexOf(value) != -1)
            {
                return true;
            }
            else {
                return false;
            }


        }

        public int Tong(ListBox pcontrol) {
            int tong = 0;
            for (int i = 0; i < pcontrol.Items.Count; i++)
            {              
                
                tong = tong + Convert.ToInt32(pcontrol.Items[i]);
               
            }
            return tong;
        }
        public void XoaPTdauCuoi(ListBox pcontrol)
        {
            if (pcontrol.Items.Count < 2)
            {
                pcontrol.Items.RemoveAt(0);
            }
            else {
                pcontrol.Items.RemoveAt(0);
                pcontrol.Items.RemoveAt(pcontrol.Items.Count - 1);
            }
        }
        public void XpaPTdangchon(ListBox pcontrol) {            
                pcontrol.Items.Remove(pcontrol.SelectedItems[0]);                        
            
            }
        public void TangPtlen2(ListBox pcontrol) {
            for (int i = pcontrol.Items.Count - 1; i >= 0; i--) {
                //if (!String.IsNullOrEmpty(pcontrol.Items[i] as String)) {
                    double tmp = double.Parse((pcontrol.Items[i].ToString()));
                    tmp = tmp + 2;
                    pcontrol.Items[i] = tmp.ToString();
               // }
            }
        }
        public void thaybangbinhphuong(ListBox pcontrol)
        {
            for (int i = pcontrol.Items.Count - 1; i >= 0; i--)
            {
                //if (!String.IsNullOrEmpty(pcontrol.Items[i] as String)) {
                double tmp = double.Parse((pcontrol.Items[i].ToString()));
                tmp = Math.Pow(tmp, 2);
                pcontrol.Items[i] = tmp.ToString();
                // }
            }
        }
        public void Chonsochan(ListBox pcontrol)
        {
            for (int i = pcontrol.Items.Count - 1; i >= 0; i--)
            {
                //if (!String.IsNullOrEmpty(pcontrol.Items[i] as String)) {
                int tmp = int.Parse((pcontrol.Items[i].ToString()));
                if (tmp % 2 == 0)
                    pcontrol.SetSelected(1, true);
                 //}
            }
        }
        public void Chonsole(ListBox pcontrol)
        {
            for (int i = pcontrol.Items.Count - 1; i >= 0; i--)
            {
                //if (!String.IsNullOrEmpty(pcontrol.Items[i] as String)) {
                int tmp = int.Parse((pcontrol.Items[i].ToString()));
                if (tmp % 2 == 1)
                    pcontrol.SetSelected(1, true);
                //}
            }
        }
    }
}
