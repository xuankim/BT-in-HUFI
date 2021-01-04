using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapvn
{
    class sinhvien
    {
        string masv;
        string hoten;
        string gioitinh;
        string ngoaingu;
        string dantoc;

        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }
        public string Ngoaingu
        {
            get { return ngoaingu; }
            set { ngoaingu = value; }
        }
       
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
      

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public sinhvien(){}
        public sinhvien(string photen,string pma,string pgioitinh, string pngoaingu,string pdantoc) {
            hoten = photen;
            masv = pma;
            gioitinh = pgioitinh;
            ngoaingu = pngoaingu;
            dantoc = pdantoc;
        }
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
    
    }
}
