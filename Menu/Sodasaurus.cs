/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        
        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets and sets flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
                NotifyOfPropertyChange("Description");
            }
        }


        /// <summary>
        /// The list of ingredients included in Sodasaurus.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Temporary variable to set size.
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets price, calories, size, and returns size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
            }
        }

        private bool ice = true;
        /// <summary>
        /// Returns whether there is ice or not.
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
        }

        /// <summary>
        /// Initializes Sodasaurus class and sets size to small.
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Returns a string of the class name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.size} {this.flavor} Sodasaurus";
        }

        /// <summary>
        /// Holds ice.
        /// </summary>
        public void HoldIce()
        {
            this.ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
