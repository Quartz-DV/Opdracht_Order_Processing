using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.StatusKlassen
{
    public class Zilver
    {
        private int _zilverPrijs;
        public int ZilverPrijs
        {
            get { return _zilverPrijs; }
            set { _zilverPrijs = 120 * 2 ; }
        }
    }
}
