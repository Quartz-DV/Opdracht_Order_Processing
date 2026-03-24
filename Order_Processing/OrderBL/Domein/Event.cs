using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Domein
{
    internal class Event
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public string Adres { get; set; }
        public DateTime datum { get; set; }
        public double KostPrijs { get; set; } = 120;
    }
}
