using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mang1chieu
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
            Console.Write("\nsole la:");
            LKPhanTuLeOviTriChan(A);
            Console.Write("\nSNT la:");
            LietKeSNT(A, n);
            Console.Write("\nVi tri am dau tien la:");
            TimVTAmDT(A, n);
            Console.Write("\nMax:{0}\tMin:{1}", max(A, n), min(A, n));
            Console.Write("\nTong phan tu cua mang: {0}",TongPTmang(A));
            Console.Write("\nTong phan tu chan cua mang: {0}", TongPTchanmang(A));
        }

        public void LKPhanTuLeOviTriChan(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0 && i % 2 == 0)

                    Console.Write("{0}\t", A[i]);

            }
        }
        public bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void LietKeSNT(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(A[i]))
                {

                    Console.Write(" {0}\t", A[i]);
                }
            }
        }
        public void TimVTAmDT(int[] A, int n)
        {
            Console.Write(A.Where(t => t < 0).ToArray()[0]);

        }
        public int max(int[] A, int n)
        {
            int max = A[0];
            for (int i = 1; i < n; i++)
                if (max < A[i])
                    max = A[i];
            return max;
        }
        public int min(int[] A, int n)
        {
            int min = A[0];
            for (int i = 1; i < n; i++)
                if (min > A[i])
                    min = A[i];
            return min;
        }
        public int TongPTmang(int[] A) {
            int sum = 0;
            for (int i = 0; i < A.Length; i++) {
                sum = sum + A[i];
            }
            return sum;
        }

        public int TongPTchanmang(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]%2==0)
                sum = sum + A[i];
            }
            return sum;
        }

    }
}
