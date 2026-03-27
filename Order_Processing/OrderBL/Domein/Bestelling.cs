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
        public int Id { get; set; }
        public decimal TotalePrijs { get; set; }


        public Bestelling(int id, bool hasWelcomePacket, bool hasNamePlate)
        {
            Id = id;
            HasWelcomePacket = hasWelcomePacket;
            HasNamePlate = hasNamePlate;
           
        }
    }
}
