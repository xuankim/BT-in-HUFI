using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT8
    {
        int n;
        public void nhap()
        {
            try
            {
                Console.Write("Nhap vao n: ");
                n = int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.Write("Bạn nhập không phải số!!!!");
                return;
            }
           
        }

        public void ktsonguyento() {
            if (n < 2)
            {
                Console.WriteLine("\n{0} khong phai la so nguyen tố:", n);
            }

            int count = 0;
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\n{0} la so nguyen to", n);
            }
            else
            {
                Console.WriteLine("\n{0} khong phai so nguyen to", n);
            }
        }
    }
}
