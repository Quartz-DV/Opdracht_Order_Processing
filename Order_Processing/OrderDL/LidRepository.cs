using OrderBL.Interfaces;
using OrderBL.Domein;


namespace OrderDL {
    public class LidRepository : ILidRepository {


        private Dictionary<int, Lid> ledenLijst = new Dictionary<int, Lid>();

        private int teller = 1;

        public void VoegLidToe(Lid nieuwLid) {


            if (nieuwLid.Id == 0) {

                nieuwLid.Id = teller;
                teller++;
            }

            ledenLijst.Add(nieuwLid.Id, nieuwLid);


        }

        public Lid HaalLidOp(int id) {
            if (ledenLijst.ContainsKey(id)) {
                return ledenLijst[id];
            }
            return null;
        }

        public List<Lid> HaalAlleLedenOp() {
            return ledenLijst.Values.ToList();
        }

        public List<string> HaalEmailOp() {

            return
        }
    }


}