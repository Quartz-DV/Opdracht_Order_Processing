using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Domein
{
    public class Bestelling
    {
        public bool HasDinner { get; set; }
        public bool HasWelcomePacket { get; set; }
        public bool HasNamePlate {  get; set; }
        public int Id { get; set; }
        public decimal TotalePrijs { get; set; }


        public Bestelling()
        {
          
        }
    }
}
