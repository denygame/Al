using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ThamLam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] menhGia = { 10000, 20000, 50000, 100000 };
            long soTien = 0;
            nhan:
            Console.Write("\r\nNhap so tien <LA BOI SO CUA 10>: ");
            string a = Console.ReadLine();

            if (a == "")
            {
                Console.WriteLine("\t => Nhap so tien khong dung!");
                goto nhan;
            }
            else
                soTien = long.Parse(a);


            if(soTien%10!=0)
            {
                Console.WriteLine("\t => Nhap so tien khong dung!");
                goto nhan;
            }

            else
            {
                Solution s = new Solution(soTien, menhGia);
                s.XuLyThamLam();
            }

            Console.ReadKey();
        }
    }
}
