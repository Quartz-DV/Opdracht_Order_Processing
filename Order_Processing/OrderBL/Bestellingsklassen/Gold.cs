using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.StatusKlassen
{
    public class Gold
    {
        private int _goldPrijs;
        public int GoldPrijs
        {
            get { return _goldPrijs; }
            set { _goldPrijs = 120 * 3; }
        }
    }
}
