using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBL.Interfaces;

namespace OrderBL.Beheerder {
    public class OrderBeheerder {


        private ILidRepository Lidrepo;
        private IEventRepository Eventrepo;
        private IBestellingRepository Bestellingrepo;


        public OrderBeheerder(ILidRepository Lidrepo, IEventRepository Eventrepo, IBestellingRepository Bestellingrepo) {

            this.Lidrepo = Lidrepo;
            this.Eventrepo = Eventrepo;
            this.Bestellingrepo = Bestellingrepo;

        }

        public List<Event> GeefBeschikbareEvents() {

            return Eventrepo.HaalAlleEventenOp();
        }

        public  void RegistreerLid(Lid lid) {

             Lidrepo.VoegLidToe(lid);

        }

        public void VoegEventToe(Event nieuwEvent) {

             Eventrepo.VoegEventToe(nieuwEvent);
        }

        public void PlaatsBestelling(int lidId, int eventId) {
            
            Lid koper = Lidrepo.HaalLidOp(lidId);
            Event gekozenEvent = Eventrepo.HaalEventOp(eventId);

            if (koper == null || gekozenEvent == null) {
                throw new Exception("Lid of Event is niet gevonden");
            }







        }
    }
}
