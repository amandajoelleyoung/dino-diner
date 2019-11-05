/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Returns description of entree item.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special preparation instructions.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!this.Ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Returns whether lemon is present or not.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon; 
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
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

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
                        Price = .10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .10;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = .10;
                        Calories = 0;
                        break;
                }
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Initializes Sodasaurus class and sets size to small.
        /// </summary>
        public Water()
        {
            this.Size = Size.Small;

            this.Ice = true;
        }

        /// <summary>
        /// Returns a string of the class name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.size} Water";
        }

        /// <summary>
        /// Holds ice.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Holds Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }
    }
}
