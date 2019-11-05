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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void SelectBrontowurstCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectDinoNuggetsCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new DinoNuggets());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new PrehistoricPBJ());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectPterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new PterodactylWings());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new SteakosaurusBurger());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new TRexKingBurger());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectVelociwrapCombo(object sender, RoutedEventArgs e)
        {
            combo = new CretaceousCombo(new VelociWrap());
            NavigationService.Navigate(new CustomizeCombo(combo));
        }


    }
}
