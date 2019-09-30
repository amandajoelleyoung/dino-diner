using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
        }

        private bool sugar = false;
        public bool Sugar
        {
            get
            {
                return sugar;
            }
        }

        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets and sets flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
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
        public Tyrannotea()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Holds Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
        }

        /// <summary>
        /// Adds sugar.
        /// </summary>
        public void AddSugar()
        {
            this.sugar = true;
            this.Calories *= 2;
        }

        public void HoldSugar()
        {
            this.sugar = false;
            this.Calories /= 2;
        }

        /// <summary>
        /// Holds ice.
        /// </summary>
        public void HoldIce()
        {
            this.ice = false;
        }
    }
}
