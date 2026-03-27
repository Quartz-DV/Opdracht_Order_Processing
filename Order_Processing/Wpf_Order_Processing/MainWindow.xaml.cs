using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OrderBL.Interfaces;
using OrderUtil;
using OrderBL.Beheerder;
using OrderBL.Domein;
using System.Net.Mail;

namespace Wpf_Order_Processing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string opslagType = "COLLECTIONS";




       


        public MainWindow() 
        {
            InitializeComponent();

            ILidRepository Lidrepo = RepositoryFactory.GeefLidRepository(opslagType);
            IEventRepository Eventrepo = RepositoryFactory.GeefEventRepository(opslagType);
            IBestellingRepository Bestellingrepo = RepositoryFactory.GeefBestellingRepository(opslagType);

            OrderBeheerder Beheerder = new OrderBeheerder(Lidrepo, Eventrepo, Bestellingrepo);



            Lid Lid1 = new Lid();
            Lid1.Naam = "Sarah Peeters";
            Lid1.Status = "Gold";
            Lid1.Email = "SarahPeeters@gmail.com";
            Beheerder.RegistreerLid(Lid1);







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
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();

            Beheerder.

            

            foreach(Lid lid in leden) {


            
            if (txtBoxEmail.Text == "" )
            { 
                infoWindow.Show();
            }
                
        }
    }
}