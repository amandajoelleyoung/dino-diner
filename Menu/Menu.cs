/* CIS 400
 * Amanda Young
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.AddRange(AvailableEntrees);
                menu.AddRange(AvailableSides);
                menu.AddRange(AvailableDrinks);
                menu.AddRange(AvailableCombos);
                return menu;
            }
        }

        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(new Brontowurst());
                entrees.Add(new DinoNuggets());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new VelociWrap());
                return entrees;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
                return sides;
            }
        }

        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(new Sodasaurus());
                drinks.Add(new JurassicJava());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
                return drinks;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                combos.Add(new CretaceousCombo(new Brontowurst()));
                combos.Add(new CretaceousCombo(new DinoNuggets()));
                combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                combos.Add(new CretaceousCombo(new PterodactylWings()));
                combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                combos.Add(new CretaceousCombo(new TRexKingBurger()));
                combos.Add(new CretaceousCombo(new VelociWrap()));
                return combos;
            }
        }

        public Menu() { }

        public override string ToString()
        {
            string menuList = "";
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                menuList += menuItem.ToString() + "\n";
            }
            return menuList;     
        }
    }
}
