using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mang2chieu
    {
        public void Nhapmang2chieu(int[][] B, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                //for (int j = 0; j < m; j++) {
                //    Console.Write("Nhap phan tu A[{0}][{1}]=", i, j);
                //    A[i][j]
                B[i] = Mang1chieu.Nhapmang(B[i], m);
            }
        }
        public void xuatmang2chieu(int[][] B)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B[i].Length; j++)
                {
                    Console.Write("{0} ", B[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void Mang2Chieu(){
            int n, m;
            int[][] B;
            Console.Write("Moi ban nhap so dong: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap so cot: ");
            m = int.Parse(Console.ReadLine());
            B = new int[n][];
            for (int i = 0; i < n; i++) {
                B[i] = new int[m];
            }
            Nhapmang2chieu(B, n, m);
            xuatmang2chieu(B);
            Console.Write("Tong phan tu mang 2 chieu:{0} ",Tongsoduong2chieu(B));
            Console.Write("\nTong phan tu chan mang 2 chieu:{0} ", TongPtchan2chieu(B));
            Console.Write("Nhap dong:");
            int x =int.Parse(Console.ReadLine());
             Console.Write("\nTong phan tu I:{0} ", TongdongthuI(B,x));
        }
        Mang1chieu ar = new Mang1chieu();
        public int Tongsoduong2chieu(int [][]B) {
            int tong = 0;
            
            for (int i = 0; i < B.GetLength(0); i++) {
                tong = tong + ar.TongPTmang(B[i]);
            }
            return tong;
        }
        public int TongPtchan2chieu(int[][] B)
        {
            int tong = 0;
            
            for (int i = 0; i < B.GetLength(0); i++)
            {
                tong = tong + ar.TongPTchanmang(B[i]);
            }
            return tong;
        }
        public int TongdongthuI(int[][] B, int x){ 
           
            //Console.Write("Nhap dong:");
            //int x=int.Parse(Console.ReadLine());
            return ar.TongPTmang(B[x]);                          
            
        }
    }
}
