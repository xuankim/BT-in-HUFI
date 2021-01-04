using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan7
{
    class Dssinhvien
    {
        List<sinhvien> dssv = new List<sinhvien>();
        public Dssinhvien() {
            sinhvien sv1 = new sinhvien();
            sv1.Masv = "123";
            sv1.Hoten = "Tran Thi Kim Xuan";
            sinhvien sv2 = new sinhvien();
            sv2.Masv = "456";
            sv2.Hoten = "Nguyen Van A";
            dssv.Add(sv1);
            dssv.Add(sv2);

        }
        public List<sinhvien> DSSV() {          
            return dssv;            
        }

        public ListViewItem[] DSSV1() { 
        
            ListViewItem[] kq=new ListViewItem[dssv.Count];
            for (int i = 0; i < dssv.Count; i++) {
                ListViewItem itm = new ListViewItem(new[] { (i + 1).ToString(), dssv[i].Masv, dssv[i].Hoten });
                kq[i] = itm;
            }
            return kq;
        }
        public bool kttrung(string pmaso) {
            for (int i = 0; i < dssv.Count; i++) {
                if (dssv[i].Masv == pmaso)
                {
                    return true;
                }                                               
            }
                  return false;
        }
        public void themSv(string pmasv, string photen) {
            if (kttrung(pmasv)==false)
            {
                if (pmasv.Count() > 0 && photen.Count() > 0)
                {
                    sinhvien sv = new sinhvien();
                    sv.Masv = pmasv;
                    sv.Hoten = photen;

                    dssv.Add(sv);
                }
               
            }
            
        }
        public void themSv(sinhvien psv) {
            dssv.Add(psv);
        }

        public bool xoa(string pm) {
            dssv = dssv.Where(t => t.Masv != pm).ToList<sinhvien>();
            return true;
        }

        public bool sua(string p,string value) { 
            int i=find(p);
            if(i != -1){
                
                sinhvien sv = new sinhvien(p,value);
                dssv[i] = sv;
                return true;
            }
            return false;
         
        }
        public int find(string pma) {
            for (int i = 0; i < dssv.Count; i++) 
            {
                if (dssv[i].Masv == pma) 
                {
                    return i;
                }
            }
            return -1;
           
        }
    }
}
