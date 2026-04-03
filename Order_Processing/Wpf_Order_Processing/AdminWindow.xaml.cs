using OrderBL.Beheerder;
using OrderBL.Domein;
using OrderBL.Interfaces;
using OrderUtil;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {        
        OrderBeheerder Beheerder;
        

        public AdminWindow(OrderBeheerder beheerder)
        {
            InitializeComponent();           

            

            List<Bestelling> mijnBestellingen = beheerder.HaalAlleBestellingenOp();



            DataGridBestellingen.ItemsSource = beheerder.HaalAlleBestellingenOp();
        }





    }
}
