using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinhHopKhongLap_VetCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("=============CHINH HOP KHONG LAP=============");

            Solution solution = new Solution(n, k);
            solution.Try_CHKL(0);

            Console.ReadKey();
        }
    }
}
