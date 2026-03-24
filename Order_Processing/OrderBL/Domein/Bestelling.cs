using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Domein
{
    public class Bestelling
    {
        public bool HasWelcomePacket { get; set; }
        public bool HasNamePlate {  get; set; }

        public Bestelling(bool hasWelcomePacket, bool hasNamePlate)
        {
            HasWelcomePacket = hasWelcomePacket;
            HasNamePlate = hasNamePlate;
        }
    }
}
