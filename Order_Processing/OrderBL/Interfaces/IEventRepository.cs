using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Interfaces {
    public interface IEventRepository {

        public void VoegEventToe(Event nieuwEvent);

        public Event HaalEventOp(int id);

        public List<Event> HaalAlleEventenOp();
    }
}
