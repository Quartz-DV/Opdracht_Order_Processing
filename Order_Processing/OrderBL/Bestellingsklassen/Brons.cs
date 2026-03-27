
﻿
using System;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderBL.Bestellingsklassen
{
    public class Brons : BasisPrijs
    {
        public override decimal Kost
        {
            get { return base.Kost + 100.0m; }
        }
    }
}
