using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Tuan4
{
   public class Xuly
    {
        float _a,_b,_c;
        public float b
        {
            get { return _b; }
            set { _b = value; }
        }
        public float a
        {
            get { return _a; }
            set { _a = value; }
        }
       public Xuly(){a=b=0;}
       public Xuly(float a,float b,float c) {
           _a = a;
           _b = b;
           _c = c;
       }
        public float Cong()
        {   
         return a + b;
    }
        public float Tru() {
            return a - b;
        }
        public float Nhan() {
            return a * b;
        }
        public float Chia() {
            return a / b;
        }
        public float Giaibacnhat() {
            return -b / a;
        }
        public void GiaiBacHai() {
            double x1,x2;
            double denta =_b*_b - _a * _c * 4;
            if (denta > 0)
            {
                x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine("{0}", x1);
                Console.WriteLine("{1}", x2);
            }
            else if (denta == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("{0}", x1);
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }                           

        }
    }
}
