using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2001181435_TranThiKimXuan_BTVNTuan1
{
    class BT1
    {
        int x; int n;int m;
       
        public void nhap()
        {
           
            try
            {
                Console.Write("Nhap vao x: ");
                x = int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.Write("Bạn nhập không phải số!!!!");
                return;
            }
        }

        public double TinhHamA(int x)
        {

            if (x > 0)
            {
                return 3 * x + Math.Sqrt(x);
            }
            return Math.Pow((Math.E), x) + 4;


        }

        public void xuatKQHamA()
        {
            Console.WriteLine("Ket qua ham la:{0}", TinhHamA(x));
        }
        public double TinhHamB(int x) {
            if (x >= 1)
            {
                return Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            else if (x > -1 && x < 1)
            {
                return 3 * x + 5;
            }
            else
                return Math.Pow(x, 2) + 2 * x - 1;
        }
        public void xuatKQHamB() {
            Console.WriteLine("Ket qua ham la:{0}", TinhHamB(x));
        }

        public void InSoLeNhoHonN(int n) {
            for (int i = 1; i <= n; i++) {
                if (i % 2 != 0)
                     Console.WriteLine("{0}\t ",i);
            }
        }

        public void Sochan(int n,int m) {
            int dem = 0;
            for (int i = n; i <= m; i++) {
                if (i % 2 == 0)
                
                    dem++;
                                              
            }
            Console.WriteLine("so chan {0}", dem);
                }
                 

    }
}
