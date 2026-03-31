using System;
using System.Collections.Generic;
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
        public InfoWindow(string txtBoxName)
        {
            InitializeComponent();

            MainWindow main = new MainWindow();

            if (this.IsActive == false)
            {
                
                
                nameText.Text = txtBoxName;
            }

            NaamOverzicht.Text = $"placeholder";
            AdresOverzicht.Text = $"placeholder";
            EmailOverzicht.Text = $"placeholder";
            StatusOverzicht.Text = $"placeholder";
            LeveringsDatum.Text = $"placeholder";

        }

        private void VerzendButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bestelling is verzonden.");
        }
    }
}
