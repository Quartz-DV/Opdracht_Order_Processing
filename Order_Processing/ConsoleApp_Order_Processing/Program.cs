using OrderBL.Beheerder;
using OrderBL.Domein;
using OrderBL.Interfaces;
using System.Security.Cryptography;
using OrderUtil;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string opslagType = "COLLECTIONS";


ILidRepository Lidrepo = RepositoryFactory.GeefLidRepository(opslagType);
IEventRepository Eventrepo = RepositoryFactory.GeefEventRepository(opslagType);
IBestellingRepository Bestellingrepo = RepositoryFactory.GeefBestellingRepository(opslagType);

OrderBeheerder Beheerder = new OrderBeheerder(Lidrepo,Eventrepo,Bestellingrepo);




Lid Lid1 = new Lid();
Lid1.Naam = "Sarah Peeters";
Lid1.Status = "Gold";
Lid1.Email = "Sarah Peeters";




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

    Beheerder.VoegEventToe(event1);
    Beheerder.VoegEventToe(event2);





