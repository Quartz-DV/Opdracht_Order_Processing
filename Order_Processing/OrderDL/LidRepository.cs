using OrderBL.Interfaces;
using OrderBL.Domein;


namespace OrderDL {
    public class LidRepository : ILidRepository {


        private Dictionary<string, Lid> ledenLijst = new();
        private List<Event> events = new();
        

        private int teller = 1;

        public LidRepository() {

            Lid Lid1 = new Lid();
            Lid1.Naam = "Sarah Peeters";
            Lid1.Status = "Gold";
            Lid1.Email = "SarahPeeters@gmail.com";
<<<<<<< HEAD
            Lid1.Adres = "Stationsplein 12, Lokeren 9160";
            ledenLijst.Add(Lid1.Email,Lid1);


=======
            Lid1.Adres = "Stationsplein 12 Lokeren 9160";
            ledenLijst.Add(Lid1.Email,Lid1);

            Lid lid2 = new Lid();
            lid2.Naam = "John Doe";
            lid2.Status = "Brons";
            lid2.Email = "JohnDoe@gmail.com";
            lid2.Adres = "Groendreef 78, Lokeren 9160";
            ledenLijst.Add(lid2.Email, lid2);
>>>>>>> 2cb6b7f82d0e4ecef732ab1451aa212c2af097c0

            Event event1 = new Event();
            event1.Naam = "Tech Conferentie 2026";
            event1.KostPrijs = 75.0m;
            event1.Datum = new DateTime(2026, 6, 15);
            event1.Adres = "Expo Gent";

            Event event2 = new Event();
            event2.Naam = "VIP Zomerfestival";
            event2.KostPrijs = 150.0m;
            event2.Datum = new DateTime(2026, 8, 20);
            event2.Adres = "Sportpaleis Antwerpen";

            events.Add(event1);
            events.Add(event2);
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