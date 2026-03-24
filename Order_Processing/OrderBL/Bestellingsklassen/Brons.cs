using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.StatusKlassen
{
    public class Brons
    {
        private int _bronsPrijs;
        public int BronsPrijs
        {
            get { return _bronsPrijs; }
            set { _bronsPrijs = 120 + 100; }
        }
    }
}
