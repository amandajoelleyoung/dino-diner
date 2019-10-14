/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem
    {
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

        private double price;
        /// <summary>
        /// Sets and returns price.
        /// </summary>
        public override double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        private uint calories;
        /// <summary>
        /// Sets and returns calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
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
        public Water()
        {
            this.Size = Size.Small;
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
            this.ice = false;
        }

        /// <summary>
        /// Holds Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
        }
    }
}
