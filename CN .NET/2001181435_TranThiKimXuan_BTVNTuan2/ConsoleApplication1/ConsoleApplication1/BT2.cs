using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class BT2
    {

        public void Nhapmang2chieu(int[][] B, int n)
        {
            for (int i = 0; i < n; i++)
            {
                //for (int j = 0; j < m; j++) {
                //    Console.Write("Nhap phan tu A[{0}][{1}]=", i, j);
                //    A[i][j]
                B[i] = BT1.Nhapmang(B[i], n);
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
        public void Mang2Chieu()
        {
            int n;
            int[][] B;
            Console.Write("Moi ban nhap so dong: ");
            n = int.Parse(Console.ReadLine());
           
            B = new int[n][];
            for (int i = 0; i < n; i++)
            {
                B[i] = new int[n];
            }
            Nhapmang2chieu(B, n);
            xuatmang2chieu(B);
            InCheoChinh(B, n);
            InCheoPhu(B, n);
            TongCheoChinh(B, n);
            TongCheoPhu(B, n);
            TamGiacDuoi(B, n);
            TamGiacTren(B, n);
            TongTamGiacDuoi(B, n);
            TongTamGiacTren(B, n);
        }

        void InCheoChinh(int [][]B,int n)
        {
            Console.Write(" cac phan tu cheo chinh :\n");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                    if (i==j)
                         Console.Write("{0}\t",B[i][j]);
            }

        }
        void InCheoPhu(int [][]B,int n)
        {
            Console.Write("\n-cheo phu:\n");
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    if(i+j==n-1)
                        Console.Write("{0}\t", B[i][j]);
        }

        void TongCheoChinh(int[][] B, int n)
        {
            int tong = 0;
            Console.Write("\nTong cac phan tu cheo chinh :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i == j)
                        tong = tong + B[i][j];
                        
            }
            Console.Write("{0}", tong);
        }

        void TongCheoPhu(int[][] B, int n)
        {
            int tong = 0;
            Console.Write("\n-Tong cac phan tu cheo phu:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i + j == n - 1)
                        tong=tong+B[i][j];
                        Console.Write("{0}",tong );
        }

        void TamGiacDuoi(int [][]B,int n) {
            Console.Write("\n-Xuat cac phan tu Tam giac duoi:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                    if (i >= j)
                        Console.Write("{0}  ", B[i][j]);
                    else
                        Console.Write("{0}  ", 0);
            }
            Console.Write("\n\n");    

        }
        void TamGiacTren(int[][] B, int n)
        {
            Console.Write("\n-Xuat cac phan tu Tam giac tren:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                    if (i <= j)
                        Console.Write("{0}  ", B[i][j]);
                    else
                        Console.Write("{0}  ", 0);
            }
            Console.Write("\n\n");

        }
        void TongTamGiacDuoi(int[][] B, int n)
        {
            int tong = 0;
            Console.Write("\n-Tong cac phan tu Tam giac duoi:");
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n; j++)
                    if (i >= j)
                        tong=tong+B[i][j];
                        
                   
            }
            Console.Write("{0} ", tong);

        }

        void TongTamGiacTren(int[][] B, int n)
        {
            int tong = 0;
            Console.Write("\n-Tong cac phan tu Tam giac tren:");
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                    if (i <= j)
                        tong=tong+B[i][j];
                       
            }
            Console.Write("{0}",tong);

        }
    }
}
