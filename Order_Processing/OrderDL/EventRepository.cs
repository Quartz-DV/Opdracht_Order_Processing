using OrderBL.Domein;
using OrderBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrderDL {
    public class EventRepository : IEventRepository {

        private Dictionary<int, Event> eventLijst = new();

        private List<Event> events = new();

        private int teller = 1;

        public EventRepository() {



            Event event1 = new Event();
            event1.Naam = "Tech Conferentie 2026";
            event1.KostPrijs = 75.0m;
            event1.Datum = new DateTime(2026, 6, 15);
            event1.Adres = "Expo Gent";
            event1.Id = 1;

            Event event2 = new Event();
            event2.Naam = "VIP Zomerfestival";
            event2.KostPrijs = 150.0m;
            event2.Datum = new DateTime(2026, 8, 20);
            event2.Adres = "Sportpaleis Antwerpen";
            event2.Id = 2;

            VoegEventToe(event1);
            VoegEventToe(event2);
            events.Add(event1);
            events.Add(event2);
        }

        public void VoegEventToe(Event nieuwEvent) {


            if (nieuwEvent.Id == 0) {

                nieuwEvent.Id = teller;
                teller++;
            }

            eventLijst.Add(nieuwEvent.Id, nieuwEvent);

            
        }
        

        public Event HaalEventOp(int id) {
            if (eventLijst.ContainsKey(id)) {
                return eventLijst[id];
            }
            return null;
        }

        public List<Event> HaalAlleEventenOp() {
            return eventLijst.Values.ToList();
        }
    }
}

