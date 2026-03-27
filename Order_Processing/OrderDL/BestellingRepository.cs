using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBL.Domein;
using OrderBL.Interfaces;

namespace OrderDL {
    public class BestellingRepository : IBestellingRepository {

        private Dictionary<int, Bestelling> bestellingLijst = new();

        private int teller = 1;

        public void voegBestellingToe(Bestelling nieuwBestelling) {

            if(nieuwBestelling.Id == 0) {

                nieuwBestelling.Id = teller;
                teller++;
            }

            bestellingLijst.Add(nieuwBestelling.Id,nieuwBestelling);
        }

        public Bestelling HaalOpBestelling(int id) {

            if (bestellingLijst.ContainsKey(id)) {

                return bestellingLijst[id];
            }

            return null;
        }

        public List<Bestelling> HaalAlleBestellingenOp() {

           return bestellingLijst.Values.ToList();
        }
    }
}
