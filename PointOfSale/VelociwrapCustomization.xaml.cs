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
    /// Interaction logic for VelociwrapCustomization.xaml
    /// </summary>
    public partial class VelociwrapCustomization : Page
    {
        private VelociWrap wrap;
        private VelociwrapCustomization()
        {
            InitializeComponent();
        }

        public VelociwrapCustomization(VelociWrap vw)
        {
            InitializeComponent();
            wrap = vw;
        }

        private void SelectHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        private void SelectHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        private void SelectHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
