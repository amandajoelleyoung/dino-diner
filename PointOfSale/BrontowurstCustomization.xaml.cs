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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private Brontowurst brontowurst;
        private CretaceousCombo Combo { get; set; }
        private BrontowurstCustomization()
        {
            InitializeComponent();
        }

        public BrontowurstCustomization(Brontowurst bw)
        {
            InitializeComponent();
            brontowurst = bw;
        }

        public BrontowurstCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            if (combo.Entree is Brontowurst brontow)
            {
                brontowurst = brontow;
            }
        }

        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                if (Combo.Entree is Brontowurst bw)
                {
                    bw.HoldBun();
                }
            }
            brontowurst.HoldBun();
        }

        private void SelectHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }

        private void SelectHoldOnion(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(Combo));
            }
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
