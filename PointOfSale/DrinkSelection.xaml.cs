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
        private Drink Drink { get; set; }
        private CretaceousCombo Combo { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
            ConfigureButtons();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            ConfigureButtons();
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            Drink = combo.Drink;
            ConfigureButtons();
        }
        
        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            if (Drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        private void SelectDrink(Drink drink)
        {
            if(Combo != null)
            {
                Combo.Drink = drink;
                Drink = drink;
            }
            else if (DataContext is Order order)
            {
                order.Add(drink);
                Drink = drink;
            }
            ConfigureButtons();
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Combo != null)
            {
                Combo.Drink.Size = size;
                Drink.Size = size;
            }
            if (Drink != null)
            {
                Drink.Size = size;
            }
            ConfigureButtons();
            BtnSelectJurassicJava.IsEnabled = true;
            BtnSelectSodaSaurus.IsEnabled = true;
            BtnSelectTyrannotea.IsEnabled = true;
            BtnSelectWater.IsEnabled = true;
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
            Sodasaurus soda = new Sodasaurus();
            SelectDrink(soda);
            NavigationService.Navigate(new FlavorSelection(soda));
        }

        protected void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());
        }

        protected void AddDecaf(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                if (Combo.Drink is JurassicJava java)
                {
                    java.MakeDecaf();
                }
            }
            if (Drink is JurassicJava j)
            {
                j.MakeDecaf();
            }
        }

        protected void AddSweet(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                if (Combo.Drink is Tyrannotea tea)
                {
                    tea.AddSugar();
                }
            }
            if (Drink is Tyrannotea t)
            {
                t.AddSugar();
            }
        }

        protected void AddLemon(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                if (Combo.Drink is Water w)
                {
                    w.AddLemon();
                }
                if (Combo.Drink is Tyrannotea t)
                {
                    t.AddLemon();
                }
            }
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

        private void ConfigureButtons()
        {
            if (Drink != null && Combo == null) {
                BtnSelectJurassicJava.IsEnabled = false;
                BtnSelectSodaSaurus.IsEnabled = false;
                BtnSelectTyrannotea.IsEnabled = false;
                BtnSelectWater.IsEnabled = false;
            }
            else
            {
                BtnSelectJurassicJava.IsEnabled = true;
                BtnSelectSodaSaurus.IsEnabled = true;
                BtnSelectTyrannotea.IsEnabled = true;
                BtnSelectWater.IsEnabled = true;
            }

            if(Drink is Sodasaurus)
            {
                BtnSelectFlavor.IsEnabled = true;
            }
            else
            {
                BtnSelectFlavor.IsEnabled = false;
            }

            if (Drink is JurassicJava)
            {
                BtnSelectDecaf.IsEnabled = true;
            }
            else
            {
                BtnSelectDecaf.IsEnabled = false;
            }

            if(Drink is Tyrannotea)
            {
                BtnSelectSweet.IsEnabled = true;
            }
            else
            {
                BtnSelectSweet.IsEnabled = false;
            }

            if(Drink is Water || Drink is Tyrannotea)
            {
                BtnSelectLemon.IsEnabled = true;
            }
            else
            { 
                BtnSelectLemon.IsEnabled = false;
            }
            
            if (Drink != null)
            {
                BtnPickSmall.IsEnabled = true;
                BtnPickMedium.IsEnabled = true;
                BtnPickLarge.IsEnabled = true;
            }
            else
            {
                BtnPickSmall.IsEnabled = false;
                BtnPickMedium.IsEnabled = false;
                BtnPickLarge.IsEnabled = false;
            }
        }
    }
}
