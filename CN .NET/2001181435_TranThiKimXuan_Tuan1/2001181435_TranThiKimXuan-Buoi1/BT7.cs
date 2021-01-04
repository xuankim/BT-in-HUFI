using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT7
    {
        int x;
       
        public void nhap()

        {
            Console.WriteLine("f(x)=3x + √x khi x>0 , f(x)= e^x +4 khi x<=0");
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
        public double TinhHamA(int x){
            
        if(x>0){
           return 3 * x + Math.Sqrt(x);
        }
        return Math.Pow((Math.E), x) + 4;

       
        }

        public void xuatKQHamA() {
            Console.WriteLine("Ket qua ham la:{0}", TinhHamA(x));
        }


    }
}
