using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Tuan7
{
    class sinhvien
    {
        string masv;
        string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public sinhvien(){}
        public sinhvien(string pma,string photen) {
            hoten = photen;
            masv = pma;
        }
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
    }
}
