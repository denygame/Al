using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToHop_VetCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("=============SINH TO HOP=============");

            Solution solution = new Solution(n, k);
            solution.Try(1);


            Console.ReadKey();
        }
    }
}
