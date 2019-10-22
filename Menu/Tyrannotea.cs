/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {
        private bool lemon = false;
        private bool sugar = false;

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
                if (sugar) special.Add("Add Sweet");
                if (lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

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
        /// Returns whether tea is sweetened or not.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
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
                ingredients.Add("Tea");
                if (lemon) ingredients.Add("Lemon");
                if (sugar) ingredients.Add("Cane Sugar");
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
                        Price = 1.99;
                        Calories = 32;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
            }
        }


        /// <summary>
        /// Initializes Sodasaurus class and sets size to small.
        /// </summary>
        public Tyrannotea()
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
            if (sugar) return $"{this.size} Sweet Tyrannotea";
            else return $"{this.size} Tyrannotea";
        }

        /// <summary>
        /// Holds Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Adds sugar.
        /// </summary>
        public void AddSugar()
        {
            this.sugar = true;
            this.Calories *= 2;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Calories");
        }

        /// <summary>
        /// Holds Sugar.
        /// </summary>
        public void HoldSugar()
        {
            this.sugar = false;
            this.Calories /= 2;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Calories");
        }

        /// <summary>
        /// Holds ice.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChange("Ice");
        }
    }
}
