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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                Drink = drink;
                BtnSelectJurassicJava.IsEnabled = false;
                BtnSelectSodaSaurus.IsEnabled = false;
                BtnSelectTyrannotea.IsEnabled = false;
                BtnSelectWater.IsEnabled = false;
                BtnSelectDecaf.IsEnabled = false;
                BtnSelectFlavor.IsEnabled = false;
                BtnSelectLemon.IsEnabled = false;
                BtnSelectSweet.IsEnabled = false;
                BtnPickSmall.IsEnabled = true;
                BtnPickMedium.IsEnabled = true;
                BtnPickLarge.IsEnabled = true;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                Drink.Size = size;
                BtnSelectJurassicJava.IsEnabled = true;
                BtnSelectSodaSaurus.IsEnabled = true;
                BtnSelectTyrannotea.IsEnabled = true;
                BtnSelectWater.IsEnabled = true;
                BtnSelectDecaf.IsEnabled = true;
                BtnSelectFlavor.IsEnabled = true;
                BtnSelectLemon.IsEnabled = true;
                BtnSelectSweet.IsEnabled = true;
            }
        }

        protected void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            SelectDrink(new JurassicJava());
        }

        protected void AddTyrannotea(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Tyrannotea());
        }

        protected void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Sodasaurus());
        }

        protected void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());
        }

        protected void AddDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.MakeDecaf();
            }
        }

        protected void AddSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddSugar();
            }
        }

        protected void AddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Water water)
            {
                water.AddLemon();
            }
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
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
