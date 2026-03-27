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

        private int teller = 1;

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

