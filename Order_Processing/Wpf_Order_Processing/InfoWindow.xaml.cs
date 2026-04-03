using OrderBL.Beheerder;
using OrderBL.Domein;
using System;
using System.Collections.Generic;
using System.Windows;


namespace Wpf_Order_Processing {
    public partial class InfoWindow : Window {
     
        private OrderBeheerder _beheerder;
        private Lid _ingelogdLid;

        public InfoWindow(OrderBeheerder doorgegevenBeheerder, string txtBoxEmail) {
            InitializeComponent();

           
            _beheerder = doorgegevenBeheerder;
            _ingelogdLid = _beheerder.HaalLidOp(txtBoxEmail);

            lstEvents.ItemsSource = _beheerder.GeefBeschikbareEvents();


            //int aantalEvents = _beheerder.GeefBeschikbareEvents().Count;
            //MessageBox.Show($"TEST: De database heeft {aantalEvents} events gevonden.");


            NaamOverzicht.Text = _ingelogdLid.Naam;
                AdresOverzicht.Text = _ingelogdLid.Adres;
                EmailOverzicht.Text = _ingelogdLid.Email;
                StatusOverzicht.Text = _ingelogdLid.Status;

                GeleverdOp.Text = "Wordt geleverd op ";
                LeveringsDatum.Text = DateTime.Now.Date.AddDays(2).ToString("dd/MM/yyyy");
            
<<<<<<< HEAD
=======
            Lid lid = Beheerder.HaalLidOp(txtBoxEmail);
            List<Event> eventN = Beheerder.GeefBeschikbareEvents();
            Event eventB = Beheerder.HaalEventOp(1);



            if (this.IsActive == false)
            {

            }

>>>>>>> bb44c21f907e5ac20cca9e792866c76c57eb1328
            
        }

        
        
        private void VerzendButton_Click(object sender, RoutedEventArgs e) {

            Event gekozenEvent = (Event)lstEvents.SelectedItem;


            _beheerder.PlaatsBestelling(_ingelogdLid.Email, gekozenEvent.Id);

            MessageBox.Show("Bestelling is verzonden.");
        }
    }
}