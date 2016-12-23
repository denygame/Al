using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguoiDuLich_ThamLam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] d = new int[5, 5]{
                {-1,3,14,18,15},
                {3,-1,4,22,20},
                {17,9,-1,16,4},
                {6,2,7,-1,12},
                {9,15,11,5,-1}
            };



            Solution s = new Solution(n, d);
            s.runTL();

            Console.ReadKey();
        }
    }
}
