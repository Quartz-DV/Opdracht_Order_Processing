using OrderBL.Interfaces;
using OrderBL.Domein;


namespace OrderDL {
    public class LidRepository : ILidRepository {


        private Dictionary<string, Lid> ledenLijst = new();
     
        

        private int teller = 1;

        public LidRepository() {

            Lid Lid1 = new Lid();
            Lid1.Naam = "Sarah Peeters";
            Lid1.Status = "Gold";
            Lid1.Email = "SarahPeeters@gmail.com";
            Lid1.Admin = false;
            Lid1.Adres = "Stationsplein 12, Lokeren 9160";
            ledenLijst.Add(Lid1.Email,Lid1);



           

            Lid lid2 = new Lid();
            lid2.Naam = "John Doe";
            lid2.Status = "Brons";
            lid2.Email = "JohnDoe@gmail.com";
            lid2.Admin = true;
            lid2.Adres = "Groendreef 78, Lokeren 9160";
            ledenLijst.Add(lid2.Email, lid2);


        }

        public void VoegLidToe(Lid nieuwLid) {


            if (nieuwLid.Id == 0) {

                nieuwLid.Id = teller;
                teller++;
            }

            ledenLijst.Add(nieuwLid.Email, nieuwLid);


        }

        public Lid HaalLidOp(string email) {
            if (ledenLijst.ContainsKey(email)) {
                return ledenLijst[email];
            }
            return null;
        }

        public List<Lid> HaalAlleLedenOp() {
            return ledenLijst.Values.ToList();
        }

        
    }


}