using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBL.Interfaces;
using OrderBL.Bestellingsklassen;
using System.Runtime.CompilerServices;

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
            Bestelling nieuweBestelling = new();
            BasisPrijs standaardPrijs = new();
            Gold goud = new();



            if (koper.Status.ToLower() == "Gold") {

                nieuweBestelling.HasWelcomePacket = true;
                nieuweBestelling.HasNamePlate = true;
                nieuweBestelling.HasDinner = true;

                standaardPrijs.Kost = gekozenEvent.KostPrijs;

                nieuweBestelling.TotalePrijs = standaardPrijs.Kost;


            }

            else if (koper.Status.ToLower() == "Zilver") {

                nieuweBestelling.HasWelcomePacket = true;
                nieuweBestelling.HasNamePlate = true;
                nieuweBestelling.HasDinner = false;

                standaardPrijs.Kost = gekozenEvent.KostPrijs;

                nieuweBestelling.TotalePrijs = standaardPrijs.Kost;
            }

            else if (koper.Status.ToLower() == "Brons") {

                nieuweBestelling.HasWelcomePacket = false;
                nieuweBestelling.HasNamePlate = true;
                nieuweBestelling.HasDinner = false;

                standaardPrijs.Kost = gekozenEvent.KostPrijs;

                nieuweBestelling.TotalePrijs = standaardPrijs.Kost;
            }

            else if (koper.Status.ToLower() == "Standaard") {

                nieuweBestelling.HasWelcomePacket = false;
                nieuweBestelling.HasNamePlate = false;
                nieuweBestelling.HasDinner = false;

                standaardPrijs.Kost = gekozenEvent.KostPrijs;

                nieuweBestelling.TotalePrijs = standaardPrijs.Kost;

            }


            Bestellingrepo.voegBestellingToe(nieuweBestelling);

        }


            //        if (koper == null || gekozenEvent == null) {
            //            throw new Exception("Lid of Event is niet gevonden");
            //        }

            //        switch (koper.Status)
            //{
            //            case "Gold":

            //                nieuweBestelling.HasWelcomePacket = true;
            //                nieuweBestelling.HasNamePlate = true;
            //                decimal kost = standaardPrijs.Kost;


            //                return new Bestelling();

            //            default: return null;


            //            case "Zilver":

            //                nieuweBestelling.HasWelcomePacket = true;
            //                nieuweBestelling.HasNamePlate = true;
            //                decimal kost = standaardPrijs.Kost;














        
    }
}
