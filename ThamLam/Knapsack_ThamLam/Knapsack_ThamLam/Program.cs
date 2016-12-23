using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Knapsack_ThamLam
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag(27);  //khối lượng max 

            //tên - trọng lượng - giá trị
            Item A = new Item("A", 15, 30);
            Item B = new Item("B", 10, 25);
            Item C = new Item("C", 1, 25);
            Item D = new Item("D", 2, 25);
            Item E = new Item("E", 3, 4);

            Item F = new Item("F", 15, 30);
            Item G = new Item("G", 10, 25);
            Item H = new Item("H", 1, 25);
            Item U = new Item("U", 2, 25);
            Item I = new Item("I", 3, 4);

            List<Item> listItem = new List<Item>();
            listItem.Add(A);
            listItem.Add(B);
            listItem.Add(C);
            listItem.Add(D);
            listItem.Add(E);

            listItem.Add(F);
            listItem.Add(G);
            listItem.Add(H);
            listItem.Add(U);
            listItem.Add(I);

            Console.WriteLine("BALO");
            Console.WriteLine("Ten - Trong Luong - Gia Tri\r\n\r\n\r\n");
            Console.WriteLine("\r\n\r\n\r\n===========CAI TUI DUNG THUAT TOAN THAM LAM===========\r\n\r\n");
            
            Solution solution = new Solution(listItem, bag);
            solution.ThamLam();

            Console.ReadKey();
        }
    }
}
