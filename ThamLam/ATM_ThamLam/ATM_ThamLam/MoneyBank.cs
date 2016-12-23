using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ThamLam
{
    class MoneyBank
    {
        private int[] menhGia;

        public MoneyBank(int[] menhGia)
        {
            this.menhGia = menhGia;
        }

        public void GiamDan()
        {
            for(int i=0;i<menhGia.Length;i++)
                for(int j=i;j<menhGia.Length;j++)
                    if(menhGia[i]<menhGia[j])
                    {
                        int temp = menhGia[i];
                        menhGia[i] = menhGia[j];
                        menhGia[j] = temp;
                    }
        }
    }
}
