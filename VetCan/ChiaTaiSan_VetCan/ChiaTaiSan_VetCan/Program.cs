using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiaTaiSan_VetCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Toys A = new Toys("A", 15);
            Toys B = new Toys("B", 10);
            Toys C = new Toys("C", 1);
            Toys D = new Toys("D", 5);
            Toys E = new Toys("E", 3);

            Toys F = new Toys("F", 30);
            Toys G = new Toys("G", 8);
            Toys H = new Toys("H", 34);
            Toys J = new Toys("J", 100);
            Toys K = new Toys("K", 17);
            Toys L = new Toys("L", 9);

            List<Toys> listToys = new List<Toys>();
            listToys.Add(A);
            listToys.Add(B);
            listToys.Add(C);
            listToys.Add(D);
            listToys.Add(E);

            listToys.Add(F);
            listToys.Add(G);
            listToys.Add(H);
            listToys.Add(J);
            listToys.Add(K);
            listToys.Add(L);

            Solution so = new Solution(listToys);

            Console.ReadKey();
        }
    }
}
