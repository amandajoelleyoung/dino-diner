/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Cretaceous Combo class, maintains entree, drink, and side in a combo
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree;
        /// <summary>
        /// Gets or sets any specified entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            }
        }

        private Drink drink;
        /// <summary>
        /// Gets or sets any specified drink
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                };
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private Side side;
        /// <summary>
        /// Gets or sets any specified side
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                };
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets or sets size of combo, initialized as small
        /// </summary>
        public Size Size {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            }
        }

        /// <summary>
        /// Edits total price to combo price
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - .25;
            }
        }

        /// <summary>
        /// Returns total calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }


        /// <summary>
        /// Returns description of all 3 items
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Returns all special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entree.Special);
                specials.Add(Side.ToString());
                //specials.AddRange(Side.Special);
                specials.Add(Drink.ToString());
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Returns all ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public override string ToString()
        {
            return $"{Entree.ToString()} Combo";
        }

        /// <summary>
        /// Does not allow user to input blank parameters
        /// </summary>
        public CretaceousCombo()
        {
            this.Entree = new Brontowurst();
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }

        /// <summary>
        /// Allows user to input entree only and defaults drink to Sodasaurus
        /// and side to Fryceritops
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }

        /// <summary>
        /// Allows user to input all 3 required fields
        /// </summary>
        /// <param name="entree"></param>
        /// <param name="side"></param>
        /// <param name="drink"></param>
        public CretaceousCombo(Entree entree, Side side, Drink drink)
        {
            this.Entree = entree;
            this.Side = side;
            this.Drink = drink;
        }

    }
}
