using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT5
    {
        int n, m;
        public void nhap()
        {

            try
            {
                Console.Write("Nhap vao chieu rộng: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhap vào chiều dài: ");
                m = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Bạn nhập không phải số!!!!");
                return;
            }


        }

        public void hinh()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= m; k++)
                {
                    
                        Console.Write("*");                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}
