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

        public InfoWindow(string txtBoxEmail)
        {
            InitializeComponent();

            Beheerder = new OrderBeheerder(Lidrepo, Eventrepo, Bestellingrepo);

            MainWindow main = new MainWindow();
            
            Lid lid = Beheerder.HaalLidOp(txtBoxEmail);

            

            if (this.IsActive == false)
            {

            }

            DateTime Vandaag = DateTime.Now;

            NaamOverzicht.Text = lid.Naam;
            AdresOverzicht.Text = lid.Adres;
            EmailOverzicht.Text = lid.Email;
            StatusOverzicht.Text = lid.Status;
            LeveringsDatum.Text = Vandaag.AddDays(2).ToString();

        }

        private void VerzendButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bestelling is verzonden.");
        }

    }
}
