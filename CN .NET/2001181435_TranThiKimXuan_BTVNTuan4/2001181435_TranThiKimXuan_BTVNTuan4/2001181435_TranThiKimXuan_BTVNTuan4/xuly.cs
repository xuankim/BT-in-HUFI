using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_BTVNTuan4
{
    public class xuly
    {
        string Loaiphong, tienngi, dichvu;
        float songay;
        public float Tien(string Loaiphong)
        {

            float tienphong = 0;
            if (Loaiphong == "Phòng đơn")
            {
                tienphong = songay * 300;
            }
            else if (Loaiphong == "Phòng đôi")
            {
                tienphong = songay * 350;
            }
            else
            {
                tienphong = songay * 400;
            }
            return tienphong;



        }
    }
}
