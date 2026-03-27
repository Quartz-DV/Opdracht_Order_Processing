
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Bestellingsklassen
{
    public class Gold : BasisPrijs
    {
        public override decimal Kost
        {
            get { return base.Kost * 3; }
        }
        
    }
}
