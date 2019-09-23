using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// returns list of Ingredients.
        /// </summary>
        public override List<string> Ingredients { 
            get
            {
                return this.Ingredients;
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
                return this.Size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets and returns price.
        /// </summary>
        public override double Price
        {
            get
            {
                return Price;
            }
            set
            {
                this.Price = value;
            }
        }

        /// <summary>
        /// Sets and returns calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                this.Calories = value;
            }
        }

        /// <summary>
        /// Sets size to small and adds ingredients.
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }
    }
}
