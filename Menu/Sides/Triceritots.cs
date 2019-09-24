﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Triceritots side class.
    /// </summary>
    public class Triceritots : Side
    {
        private List<string> ingredients;

        /// <summary>
        /// Returns the list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }
        
        /// <summary>
        /// Temporary variable to set value of Size
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets Size, Price, and Calories of Triceritots side.
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
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                }
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
        /// Sets size to small and adds ingredients.
        /// </summary>
        public Triceritots()
        {
            this.Size = Size.Small;
            ingredients = new List<string>();
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}
