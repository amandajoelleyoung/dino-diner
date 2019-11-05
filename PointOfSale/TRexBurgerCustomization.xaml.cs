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
    /// Interaction logic for TRexBurgerCustomization.xaml
    /// </summary>
    public partial class TRexBurgerCustomization : Page
    {
        private TRexKingBurger trex;
        public TRexBurgerCustomization()
        {
            InitializeComponent();
        }

        public TRexBurgerCustomization(TRexKingBurger burger)
        {
            InitializeComponent();
            trex = burger;
        }


        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }

        private void SelectHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }

        private void SelectHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }

        private void SelectHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }

        private void SelectHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }

        private void SelectHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
        }

        private void SelectHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }

        private void SelectHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
