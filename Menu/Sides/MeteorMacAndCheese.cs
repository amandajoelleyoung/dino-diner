using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Meteor Mac And Cheese class.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Returns list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return this.Ingredients;
            }
        }

        /// <summary>
        /// temporary variable to set size.
        /// </summary>
        private Size size;

        /// <summary>
        /// sets price, calories, size, and returns size.
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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        break;
                }
            }
        }

        /// <summary>
        /// sets and returns price.
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
        /// sets and returns calories.
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
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
        }

    }
}
