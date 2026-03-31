using OrderBL.Beheerder;
using OrderBL.Domein;
using OrderBL.Interfaces;
using OrderUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_Order_Processing
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        private static string opslagType = "COLLECTIONS";

        ILidRepository Lidrepo = RepositoryFactory.GeefLidRepository(opslagType);
        IEventRepository Eventrepo = RepositoryFactory.GeefEventRepository(opslagType);
        IBestellingRepository Bestellingrepo = RepositoryFactory.GeefBestellingRepository(opslagType);

        OrderBeheerder Beheerder;

        Bestelling bestelling = new Bestelling();
        

        public InfoWindow(string txtBoxEmail)
        {
            InitializeComponent();

            Beheerder = new OrderBeheerder(Lidrepo, Eventrepo, Bestellingrepo);

            MainWindow main = new MainWindow();
            
            Lid lid = Beheerder.HaalLidOp(txtBoxEmail);
            List<Event> eventN = Beheerder.GeefBeschikbareEvents();
            Event eventB = Beheerder.HaalEventOp(1);



            if (this.IsActive == false)
            {

            }

            

            DateTime Vandaag = DateTime.Now.Date;



            NaamOverzicht.Text = lid.Naam;
            AdresOverzicht.Text = lid.Adres;
            EmailOverzicht.Text = lid.Email;
            StatusOverzicht.Text = lid.Status;

            GeleverdOp.Text = "Wordt geleverd op ";

            LeveringsDatum.Text = Vandaag.AddDays(2).ToString();


            Beheerder.PlaatsBestelling(lid.Email, eventN.Id);

        }

        private void VerzendButton_Click(object sender, RoutedEventArgs e)
        {

            
            MessageBox.Show("Bestelling is verzonden.");
        }

    }
}
