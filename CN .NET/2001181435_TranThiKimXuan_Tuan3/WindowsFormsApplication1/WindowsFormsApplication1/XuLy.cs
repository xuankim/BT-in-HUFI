using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class XuLy
    {
        public string Bt(string photen, string pnamsinh) {
            return "My name is: "+photen.ToString() +"\n"+ "Age: "+ (DateTime.Now.Year - int.Parse(pnamsinh)).ToString();
        }
        public string Bt(string photen, int pnamsinh)
        {
            return "My name is: " + photen.ToString() + "\n" + "Age: " + (DateTime.Now.Year - pnamsinh).ToString();
        }
        public float cong(float a, float b) {
            return a + b;
        }
        public float tru(float a, float b) {
            return a - b;
        }
        public float chia(float a, float b)
        {
            return a / b;
        }
        public float nhan(float a, float b)
        {
            return a * b;
        }
        public long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Pull out remainders.
            for (; ; )
            {
                long remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }
        public long LCM(long a, long b)
        {
            return a * b / GCD(a, b);
        }        
    }
}
