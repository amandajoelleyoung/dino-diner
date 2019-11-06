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
            combo = new CretaceousCombo();
        }

        private void SelectBrontowurstCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo.Entree = new Brontowurst();
                order.Add(combo);
                NavigationService.Navigate(new BrontowurstCustomization(combo));
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectDinoNuggetsCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectPterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void SelectVelociwrapCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }


    }
}
