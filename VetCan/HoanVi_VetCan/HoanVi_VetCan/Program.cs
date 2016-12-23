using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanVi_VetCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] phanTu = new int[n];

            Console.WriteLine("\r\n\r\nNhap vao mang: ");
            for(int i=0;i<n;i++)
            {
                phanTu[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("=============================================");
            Console.WriteLine("\r\n\r\nCac phan tu cua Hoan Vi: ");
            Solution s = new Solution(n, phanTu);
            s.Try(0);

            Console.ReadKey();
        }
    }
}
