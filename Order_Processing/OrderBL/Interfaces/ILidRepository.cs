using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Interfaces {
    public interface ILidRepository {

        void VoegLidToe(Lid nieuwLid);
        Lid HaalLidOp(string email);
        List<Lid> HaalAlleLedenOp();
        
    }
}
