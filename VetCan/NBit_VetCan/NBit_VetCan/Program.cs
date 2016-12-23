using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBit_VetCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Solution a = new Solution(n);
            a.VetCan_Try(0);

            Console.ReadKey();
        }
    }
}
