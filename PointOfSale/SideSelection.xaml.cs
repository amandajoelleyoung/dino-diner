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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public Side Side { get; set; }

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                Side = side;
                BtnAddFryceritops.IsEnabled = false;
                BtnAddMeteorMacAndCheese.IsEnabled = false;
                BtnAddMezzorellaSticks.IsEnabled = false;
                BtnAddTriceritots.IsEnabled = false;
                BtnPickSmall.IsEnabled = true;
                BtnPickMedium.IsEnabled = true;
                BtnPickLarge.IsEnabled = true;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                Side.Size = size;
                BtnAddFryceritops.IsEnabled = true;
                BtnAddMeteorMacAndCheese.IsEnabled = true;
                BtnAddMezzorellaSticks.IsEnabled = true;
                BtnAddTriceritots.IsEnabled = true;
                BtnPickSmall.IsEnabled = false;
                BtnPickMedium.IsEnabled = false;
                BtnPickLarge.IsEnabled = false;
            }
        }

        protected void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        protected void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());   
        }

        protected void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        protected void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
