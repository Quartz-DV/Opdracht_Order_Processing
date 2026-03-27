using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Interfaces {
    public interface IBestellingRepository {

        public void voegBestellingToe(Bestelling nieuwBestelling);

        public Bestelling HaalOpBestelling(int id);

        public List<Bestelling> HaalAlleBestellingenOp();
    }
}
