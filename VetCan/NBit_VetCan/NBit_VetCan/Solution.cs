using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBit_VetCan
{
    class Solution
    {
        private int[] boBit;

        public int[] BoBit
        {
            get { return boBit; }
            set { boBit = value; }
        }
        private int soBit;

        public int SoBit
        {
            get { return soBit; }
            set { soBit = value; }
        }

        public Solution(int n)
        {
            this.soBit = n;
            this.boBit = new int[n];
        }

        public void VetCan_Try(int i)
        {
            for (int j = 0; j <= 1; j++)
            {
                boBit[i] = j;
                if (i == soBit - 1)
                    this.Print();
                else VetCan_Try(i + 1);
            }
        }

        private void Print()
        {
            for (int t = 0; t < soBit; t++)
                Console.Write(boBit[t]);
            Console.WriteLine("");
        }

    }
}
