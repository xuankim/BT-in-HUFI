using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class BT1
    {
        static Random rd = new Random();
        public static int[] Nhapmang(int[] A, int n)
        {
            A[0] = rd.Next(5);

            for (int i = 1; i < n; i++)
            {
                A[i] = A[i - 1] + rd.Next(-100, 100);
            }

            return A;
        }
        public static void xuatmang(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("\t{0}", A[i]);
            }
        }

        public void Mang1Chieu()
        {
            int[] A;
            Console.Write("Moi ban nhap vao so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];
            A = Nhapmang(A, n);
            xuatmang(A);
            TongPTCucDai(A, n);
           

        }

        public void TongPTCucDai(int[] A, int n)
        {

            int i, tong = 0;
            if (A[0] > A[1])
                tong = tong + A[0];
            if (A[n - 1] > A[n - 2])
                tong = tong + A[n - 1];
            for (i = 1; i < n - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    tong = tong + A[i];
            }
            Console.WriteLine("Tong phan tu cuc dai la :{0}", tong);
        }


    }
}
