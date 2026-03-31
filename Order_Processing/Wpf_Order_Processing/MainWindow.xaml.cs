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

namespace Wpf_Order_Processing {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private static string opslagType = "COLLECTIONS";

        ILidRepository Lidrepo = RepositoryFactory.GeefLidRepository(opslagType);
        IEventRepository Eventrepo = RepositoryFactory.GeefEventRepository(opslagType);
        IBestellingRepository Bestellingrepo = RepositoryFactory.GeefBestellingRepository(opslagType);

        OrderBeheerder Beheerder;

        public MainWindow() 
        {
            InitializeComponent();

            Beheerder = new OrderBeheerder(Lidrepo, Eventrepo, Bestellingrepo);
        }


        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {


            InfoWindow infoWindow = new InfoWindow(txtBoxEmail.Text);

            AdminWindow adminWindow = new AdminWindow();
            

           

            try
            {
                Lid lid = Beheerder.HaalLidOp(txtBoxEmail.Text);


                if (lid == null)
                {
                    MessageBox.Show("Ongeldige email");
                    
                    return;
                }
                else if (lid.Email == txtBoxEmail.Text && (bool)adminBox.IsChecked && lid.Admin == true)
                {
                    adminWindow.Show();
                }
                else {

                    infoWindow.Show();
                }
                
            }
            catch (Exception ex)
            {

                throw new ArgumentNullException($"Failed to get Lid with as reason: {ex}");
            }   
        }
    }
}
