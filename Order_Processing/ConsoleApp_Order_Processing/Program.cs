using OrderBL.Beheerder;
using OrderBL.Domein;
using OrderBL.Interfaces;
using OrderBL.Lidklassen;
using System.Security.Cryptography;
using OrderUtil;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string opslagType = "Collections";


ILidRepository Lidrepo = RepositoryFactory.GeefLidRepository(opslagType);
IEventRepository Eventrepo = RepositoryFactory.GeefEventRepository(opslagType);
IBestellingRepository Bestellingrepo = RepositoryFactory.GeefBestellingRepository(opslagType);

OrderBeheerder Beheerder = new OrderBeheerder(Lidrepo,Eventrepo,Bestellingrepo);


// 1. Eerst maak je de beheerder aan (Dit hadden we al)
OrderBeheerder beheerder = new OrderBeheerder(lidRepo, eventRepo, bestellingRepo);

// --- TESTDATA AANMAKEN (DATA SEEDING) ---

// 2. Je verzint zelf een event en vult de prijs in
Event event1 = new Event();
event1.Naam = "Tech Conferentie 2026";
event1.KostPrijs = 75.0m; // Hier stel je de basisprijs in!
event1.Datum = new DateTime(2026, 6, 15);
event1.Adres = "Expo Gent";

Event event2 = new Event();
event2.Naam = "VIP Zomerfestival";
event2.KostPrijs = 150.0m; // Dit event is duurder!
event2.Datum = new DateTime(2026, 8, 20);
event2.Adres = "Sportpaleis Antwerpen";

// 3. Je bewaart ze in jouw database (collectie) via de beheerder
beheerder.MaakEventAan(event1);
beheerder.MaakEventAan(event2);

// Ook handig: Maak alvast een test-lid aan
Lid testLid = new Lid();
testLid.Naam = "Sarah Peeters";
testLid.Status = "Gold";
beheerder.(testLid);

// --- EINDE TESTDATA ---

// Vanaf hier begint je echte programma (UI tonen, menuutje printen, etc.)