using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin_ThamLam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNhap=new List<int>();
            listNhap.Add(10);
            listNhap.Add(9);
            listNhap.Add(15);
            listNhap.Add(13);
            listNhap.Add(299);
            listNhap.Add(300);
            listNhap.Add(301);

            for (int i = 0; i < listNhap.Count; i++)
                Console.Write(listNhap[i] + " ");
            Console.WriteLine("\r\n\r\n");

            Solution s=new Solution(7,3,listNhap);
            s.Xuly();

            Console.ReadKey();
        }
    }
}
