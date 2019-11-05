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
    /// Interaction logic for DinonuggetsCustomization.xaml
    /// </summary>
    public partial class DinonuggetsCustomization : Page
    {
        private DinoNuggets nuggets;
        public DinonuggetsCustomization()
        {
            InitializeComponent();
        }

        public DinonuggetsCustomization(DinoNuggets dn)
        {
            InitializeComponent();
            nuggets = dn;
        }

        private void SelectAddNugget(object sender, RoutedEventArgs e)
        {
            nuggets.AddNugget();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
