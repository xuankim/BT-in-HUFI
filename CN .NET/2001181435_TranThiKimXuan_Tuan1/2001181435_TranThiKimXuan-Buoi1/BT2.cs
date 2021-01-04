using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT2
    {
        int socu, somoi;
        public void nhapdien() {

            try
            {
                Console.Write("Nhap so dien cu: ");
                socu = int.Parse(Console.ReadLine());
                Console.Write("Nhap số điện mới: ");
                somoi = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Bạn nhập không phải số!!!!");
                return;
            }           
        }

        public void TienDien() { 
            int T=somoi-socu;
            float Tien = 0;
            if (T >= 1 && T <= 100)
            {
                Tien= T * 5;
            }
            else if (T >= 101 && T <= 150)
            {
                Tien = 100 * 5 + (T - 100) * 7;
            }
            else if (T >= 151 && T <= 200)
            {
                Tien = 150 * 7 + (T - 150) * 10;
            }
            else if (T >= 201 && T <= 300)
            {
                Tien = 200 * 10 + (T - 200) * 15;
            }
            else
                Tien = 300 * 15 + (T - 300) * 20;

            Console.WriteLine("Tien Dien là {0}: ", Tien);
        }

    }
}
