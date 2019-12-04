/* CIS 400
 * Amanda Young
 */
 using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        private List<IMenuItem> menu = new List<IMenuItem>();
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return menu;
            }
        }

        private List<IMenuItem> entrees = new List<IMenuItem>();
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                return entrees;
            }
        }

        private List<IMenuItem> sides = new List<IMenuItem>();
        public List<IMenuItem> AvailableSides
        {
            get
            {
                return sides;
            }
        }

        private List<IMenuItem> drinks = new List<IMenuItem>();
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                return drinks;
            }
        }

        private List<IMenuItem> combos = new List<IMenuItem>();
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                return combos;
            }
        }

        public Menu()
        {
            AddAllMenuItems();
        }

        public override string ToString()
        {
            string menuList = "";
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                menuList += menuItem.ToString() + "\n";
            }
            return menuList;     
        }

        public void AddAllMenuItems()
        {
            //Combos
            combos.Clear();
            combos.Add(new CretaceousCombo(new Brontowurst()));
            combos.Add(new CretaceousCombo(new DinoNuggets()));
            combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
            combos.Add(new CretaceousCombo(new PterodactylWings()));
            combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
            combos.Add(new CretaceousCombo(new TRexKingBurger()));
            combos.Add(new CretaceousCombo(new VelociWrap()));
            //Entrees
            entrees.Clear();
            entrees.Add(new Brontowurst());
            entrees.Add(new DinoNuggets());
            entrees.Add(new PrehistoricPBJ());
            entrees.Add(new PterodactylWings());
            entrees.Add(new SteakosaurusBurger());
            entrees.Add(new TRexKingBurger());
            entrees.Add(new VelociWrap());
            //Drinks
            drinks.Clear();
            drinks.Add(new Sodasaurus());
            drinks.Add(new JurassicJava());
            drinks.Add(new Tyrannotea());
            drinks.Add(new Water());
            //Sides
            sides.Clear();
            sides.Add(new Fryceritops());
            sides.Add(new MeteorMacAndCheese());
            sides.Add(new MezzorellaSticks());
            sides.Add(new Triceritots());

            //All menu
            menu.Clear();
            menu.AddRange(AvailableEntrees);
            menu.AddRange(AvailableSides);
            menu.AddRange(AvailableDrinks);
            menu.AddRange(AvailableCombos);
        }

        public void SearchByName(string search)
        {
            List<IMenuItem> tempMenu = new List<IMenuItem>();
            if (search != null)
            {
                //combos
                tempMenu.AddRange(combos);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!item.ToString().ToUpper().Contains(search.ToUpper()))
                    {
                        combos.Remove(item);
                    }
                }
                tempMenu.Clear();
                //entrees
                tempMenu.AddRange(entrees);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!item.ToString().ToUpper().Contains(search.ToUpper()))
                    {
                        entrees.Remove(item);
                    }
                }
                tempMenu.Clear();
                //sides
                tempMenu.AddRange(sides);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!item.ToString().ToUpper().Contains(search.ToUpper()))
                        {
                        sides.Remove(item);
                    }
                }
                tempMenu.Clear();
                //drinks
                tempMenu.AddRange(drinks);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!item.ToString().ToUpper().Contains(search.ToUpper()))
                    {
                        drinks.Remove(item);
                    }
                }
                tempMenu.Clear();
            }
        }

        public void SearchByType(List<string> type)
        {
            if (type != null)
            {
                if (!type.Contains("combo"))
                {
                    combos.Clear();
                }
                if (!type.Contains("entree"))
                {
                    entrees.Clear();
                }
                if (!type.Contains("side"))
                {
                    sides.Clear();
                }
                if (!type.Contains("drink"))
                {
                    drinks.Clear(); 
                }
            }
        }

        public void SearchByMinPrice(float? minprice)
        {
            List<IMenuItem> tempMenu = new List<IMenuItem>();
            if (minprice != null)
            {
                //combos
                tempMenu.AddRange(combos);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price >= minprice))
                    {
                        combos.Remove(item);
                    }
                }
                tempMenu.Clear();
                //entrees
                tempMenu.AddRange(entrees);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price >= minprice))
                    {
                        entrees.Remove(item);
                    }
                }
                tempMenu.Clear();
                //sides
                tempMenu.AddRange(sides);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price >= minprice))
                    {
                        sides.Remove(item);
                    }
                }
                tempMenu.Clear();
                //drinks
                tempMenu.AddRange(drinks);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price >= minprice))
                    {
                        drinks.Remove(item);
                    }
                }
                tempMenu.Clear();
            }
        }

        public void SearchByMaxPrice(float? maxprice)
        {
            List<IMenuItem> tempMenu = new List<IMenuItem>();
            if (maxprice != null)
            {
                //combos
                tempMenu.AddRange(combos);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price <= maxprice))
                    {
                        combos.Remove(item);
                    }
                }
                tempMenu.Clear();
                //entrees
                tempMenu.AddRange(entrees);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price <= maxprice))
                    {
                        entrees.Remove(item);
                    }
                }
                tempMenu.Clear();
                //sides
                tempMenu.AddRange(sides);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price <= maxprice))
                    {
                        sides.Remove(item);
                    }
                }
                tempMenu.Clear();
                //drinks
                tempMenu.AddRange(drinks);
                foreach (IMenuItem item in tempMenu)
                {
                    if (!(item.Price <= maxprice))
                    {
                        drinks.Remove(item);
                    }
                }
                tempMenu.Clear();
            }
        }

        public void ExcludeIngredients(List<string> ingredients)
        {
            List<IMenuItem> tempMenu = new List<IMenuItem>();
            if (ingredients != null)
            {
                //combos
                tempMenu.AddRange(combos);
                foreach (IMenuItem item in tempMenu)
                {
                    foreach (string ingred in item.Ingredients)
                    {
                        if (ingredients.Contains("bun") 
                            && ingred.ToUpper().Contains("BUN") 
                            || ingred.ToUpper().Contains("Bread"))
                        {
                            combos.Remove(item);
                        }
                        if (ingredients.Contains("meat") 
                            && ingred.Contains("Brautwurst") 
                            || ingred.Contains("Chicken")
                            || ingred.Contains("Steak")
                            || ingred.Contains("Pork"))
                        {
                            combos.Remove(item);
                        }
                        foreach (string i in ingredients)
                        {
                            if (ingred.ToString().ToUpper().Contains(i.ToUpper()))
                            {
                                combos.Remove(item);
                            }
                        }
                    }
                }
                tempMenu.Clear();
                //entrees
                tempMenu.AddRange(entrees);
                foreach (IMenuItem item in tempMenu)
                {
                    if (ingredients.Contains("bun") && item.ToString().ToUpper().Contains("BUN"))
                    {
                        entrees.Remove(item);
                    }
                    if (ingredients.Contains("meat") && item.ToString().ToUpper().Contains("MEAT"))
                    {
                        entrees.Remove(item);
                    }
                    foreach (string i in ingredients)
                    {
                        if (item.ToString().ToUpper().Contains(i.ToUpper()))
                        {
                            entrees.Remove(item);
                        }
                    }
                }
                tempMenu.Clear();
                //sides
                tempMenu.AddRange(sides);
                foreach (IMenuItem item in tempMenu)
                {
                    if (ingredients.Contains("bun") && item.ToString().ToUpper().Contains("BUN"))
                    {
                        sides.Remove(item);
                    }
                    if (ingredients.Contains("meat") && item.ToString().ToUpper().Contains("MEAT"))
                    {
                        sides.Remove(item);
                    }
                    foreach (string i in ingredients)
                    {
                        if (item.ToString().ToUpper().Contains(i.ToUpper()))
                        {
                            sides.Remove(item);
                        }
                    }
                }
                tempMenu.Clear();
                //drinks
                tempMenu.AddRange(drinks);
                foreach (IMenuItem item in tempMenu)
                {
                    foreach (string i in ingredients)
                    {
                        if (item.ToString().ToUpper().Contains(i.ToUpper()))
                        {
                            drinks.Remove(item);
                        }
                    }
                }
                tempMenu.Clear();
            }
        }
    }
}
