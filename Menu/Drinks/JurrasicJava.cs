using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        private bool cream = false;
        /// <summary>
        /// Returns whether there is room for cream or not.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return cream;
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Returns whether it is decaf or not.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
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
                ingredients.Add("Coffee");
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = .49;
                        Calories = 2;
                        break;
                }
            }
        }

        private bool ice = false;
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
        /// Initializes JurassicJava class and sets size to small.
        /// </summary>
        public JurrasicJava()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Holds ice.
        /// </summary>
        public void AddIce()
        {
            this.ice = true;
        }

        /// <summary>
        /// Leaves room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.cream = true;
        }

        /// <summary>
        /// Makes decaf.
        /// </summary>
        public void MakeDecaf()
        {
            this.decaf = true;
        }
    }
}
