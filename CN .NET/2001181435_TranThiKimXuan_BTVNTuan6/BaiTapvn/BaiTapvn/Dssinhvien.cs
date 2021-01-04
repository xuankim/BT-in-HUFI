using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapvn
{
    class Dssinhvien
    {
         List<sinhvien> dssv = new List<sinhvien>();
         public Dssinhvien()
         {
             sinhvien sv1 = new sinhvien();
             sv1.Masv = "123";
             sv1.Hoten = "Tran Thi Kim Xuan";           
             sv1.Gioitinh = "Nữ";
             sv1.Ngoaingu = "Anh";
             sv1.Dantoc = "Kinh";
             sinhvien sv2 = new sinhvien();
             sv2.Masv = "456";
             sv2.Hoten = "Nguyen Van A";
             sv2.Gioitinh = "Nam";
             sv2.Ngoaingu = "Pháp";
             sv2.Dantoc = "Kinh";
             dssv.Add(sv1);
             dssv.Add(sv2);
         }

         public List<sinhvien> DSSV()
         {

             return dssv;

         }

         public void DSSVCB(ComboBox cb) {
             string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };
             foreach (string i in dt) {
                 cb.Items.Add(i);
             }          
         }
         public ListViewItem[] DSSV1()
         {

             ListViewItem[] kq = new ListViewItem[dssv.Count];
             for (int i = 0; i < dssv.Count; i++)
             {
                 ListViewItem itm = new ListViewItem(new[] {dssv[i].Hoten,dssv[i].Masv, dssv[i].Gioitinh,dssv[i].Ngoaingu,dssv[i].Dantoc });
                 kq[i] = itm;
             }
             return kq;
         }
         public bool kttrung(string pmaso)
         {
             for (int i = 0; i < dssv.Count; i++)
             {
                 if (dssv[i].Masv == pmaso)
                 {
                     return true;
                 }
             }
             return false;
         }
         public void themSv(string photen,string pmasv,string pgioitinh,string pngoaingu,string pdantoc)
         {
             if (kttrung(pmasv) == false)
             {
                 if (pmasv.Count() > 0 && photen.Count() > 0)
                 {
                     sinhvien sv = new sinhvien();
                     
                     sv.Hoten = photen;
                     sv.Masv = pmasv;
                     sv.Gioitinh = pgioitinh;
                     sv.Ngoaingu = pngoaingu;
                     sv.Dantoc = pdantoc;
                     dssv.Add(sv);
                 }

             }

         }
         public void themSv(sinhvien psv)
         {
             dssv.Add(psv);
         }

         public bool xoa(string pm)
         {
             dssv = dssv.Where(t => t.Masv != pm).ToList<sinhvien>();
             return true;
         }

         
         public int findIndexOfStudent(string pID)
         {
             for (int i = 0; i < dssv.Count; i++)
                 if (dssv[i].Masv == pID)
                     return i;
             return -1;
         }
         public bool Update(string photen,string pmasv, string pgioitinh, string pngoaingu, string pdantoc)
         {
             try
             {
                 int i = findIndexOfStudent(pmasv);
                 if (i != -1)
                 {
                     sinhvien stu = new sinhvien(photen,pmasv,pgioitinh, pngoaingu,pdantoc);
                     dssv[i] = stu;
                     
                     return true;
                 }
                 return false;
             }
             catch
             {
                 return false;
             }
         }
        
    }
}
