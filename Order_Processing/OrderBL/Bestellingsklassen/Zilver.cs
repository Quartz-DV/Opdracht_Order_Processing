using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Bestellingsklassen
{
    public class Zilver : BasisPrijs
    {
        public override decimal Kost
        {
            get { return base.Kost * 2; }
        }
    }
}
