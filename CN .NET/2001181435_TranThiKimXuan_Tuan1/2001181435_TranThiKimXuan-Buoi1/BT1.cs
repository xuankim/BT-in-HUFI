using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT1
    {
         int dongia;
        int soluong;
        public void Nhapbt() {

                    
            try
            {
                Console.Write("Nhap vao đơn giá: ");
                dongia = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao số lượng: ");
                soluong = int.Parse(Console.ReadLine());
            }
            catch {
                Console.Write("Bạn nhập không phải số!!!!");
                return;
            }           
           
        }

       public double TongTien(int dongia, int soluong)
        {
            double tinhtien = dongia * soluong;
            if (tinhtien > 100)
            {
               tinhtien = tinhtien * 0.97;
                
            }
           
                return tinhtien;
          
        }
       public void xuat() {
           Console.WriteLine("Tong tien la:{0} ", TongTien(dongia, soluong));
       }
    
    }
}
