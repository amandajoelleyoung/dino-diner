using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Mezzorella Sticks side class.
    /// </summary>
    public class MezzorellaSticks : Side
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
        /// Temporary variable to set Size.
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets the price, calories, size, and returns the size.
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
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
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");
        }
    }
}
