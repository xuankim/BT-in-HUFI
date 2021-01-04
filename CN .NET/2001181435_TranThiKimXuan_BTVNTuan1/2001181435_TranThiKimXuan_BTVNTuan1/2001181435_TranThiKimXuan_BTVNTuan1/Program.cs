using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2001181435_TranThiKimXuan_BTVNTuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon; int x; int n;int m;

            BT1 bt1 = new BT1();                                
            do
            {
                Console.WriteLine("*********************************HÀM********************************************");
                Console.WriteLine("1. f(x)=3x + √x khi x>0 , f(x)= e^x +4 khi x<=0");
                Console.WriteLine("2. f(x)=√(x^2+1) khi x>=1 , f(x)=3x + 5 khi -1<x<1, fx(x)=x^2 + 2x - 1 khi x<=-1");
                Console.WriteLine("3. Viet chuong trinh xuat so co 2 chu so sao cho đôi một khác nhau ");
                Console.WriteLine("4. In so le be hơn N ");
                Console.WriteLine("5. In ra số chan trong khoảng [n,m]");
                Console.WriteLine("6. Thoat!!!");
                Console.WriteLine("********************************************************************************");
                Console.Write("NHAP LUA CHON CUA BAN: ");

                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        bt1.nhap();
                        bt1.xuatKQHamA();
                        
                break;
                    case 2:
                bt1.nhap();
                bt1.xuatKQHamB();
                break;
                    case 3:

                break;
                    case 4:
                Console.WriteLine("Nhap vao n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("So le bé hơn {0} la:", n);
                bt1.InSoLeNhoHonN(n);
                break;
                    case 5:           
                Console.WriteLine("Nhap vao n: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao m: ");
                m = int.Parse(Console.ReadLine());
                if (n > m)
                {
                    Console.WriteLine("Nhap n<m!!! mời nhập lại");
                    Console.WriteLine("Nhap vao n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap vao m: ");
                    m = int.Parse(Console.ReadLine());
                }
                else
                {
                    bt1.Sochan(n, m);
                }

                break;
                    default:
                Console.WriteLine("Vui long chon lại.");
                break;
                }
            } while (chon != 6);
            Console.ReadLine();
        }
    }
}
