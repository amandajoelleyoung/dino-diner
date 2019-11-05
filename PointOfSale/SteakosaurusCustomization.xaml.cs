/* CIS 400
 * Amanda Young
 */
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SteakosaurusCustomization.xaml
    /// </summary>
    public partial class SteakosaurusCustomization : Page
    {
        private SteakosaurusBurger steakosaurus;
        private SteakosaurusCustomization()
        {
            InitializeComponent();
        }

        public SteakosaurusCustomization(SteakosaurusBurger sb)
        {
            InitializeComponent();
            steakosaurus = sb;
        }

        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            steakosaurus.HoldBun();
        }

        private void SelectHoldKetchup(object sender, RoutedEventArgs args)
        {
            steakosaurus.HoldKetchup();
        }

        private void SelectHoldMustard(object sender, RoutedEventArgs args)
        {
            steakosaurus.HoldMustard();
        }

        private void SelectHoldPickle(object sender, RoutedEventArgs args)
        {
            steakosaurus.HoldPickle();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
