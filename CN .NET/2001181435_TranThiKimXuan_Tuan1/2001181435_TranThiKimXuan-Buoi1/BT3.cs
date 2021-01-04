using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Buoi1
{
    class BT3
    {

        public void Bangcuuchuongdoc()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n--------BANG NHAN {0}--------\n", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t{0} x {1} = {2}\n", i, j, i * j);
                }
                
            }

        }
        public void Bangcuuchuongngang()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n--------BANG NHAN {0}--------\n", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t{0} x {1} = {2}", i, j, i * j);
                }
               
            }

        }
    }
}
