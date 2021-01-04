using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181291_NgoThiNhuQuynh_TH06.Models
{
    class NhanVien
    {
        string maNV;
        string tenNV;
        string maPB;
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    }
}
