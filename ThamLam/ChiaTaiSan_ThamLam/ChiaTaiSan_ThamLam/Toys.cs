using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiaTaiSan_ThamLam
{
    class Toys
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int giaTri;

        public int GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }

        public Toys(string name, int giaTri)
        {
            this.name = name;
            this.giaTri = giaTri;
        }
    }
}
