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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus sodasaurus;
        private FlavorSelection()
        {
            InitializeComponent();
        }

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.sodasaurus = soda;
        }

        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            this.sodasaurus.Flavor = flavor;
        }

        protected void SelectCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        protected void SelectChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        protected void SelectCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        protected void SelectLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        protected void SelectOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }

        protected void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }

        protected void SelectVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }
    }
}
