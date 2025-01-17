﻿/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        private bool cream = false;
        private bool decaf = false;
        

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
                if (cream) special.Add("Add Room for Cream");
                if (this.Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }

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
            set
            {
                ice = value;
                NotifyOfPropertyChange("Special");
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
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Initializes JurassicJava class and sets size to small.
        /// </summary>
        public JurassicJava()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Returns a string of the class name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (decaf) return $"{this.size} Decaf Jurassic Java";
            else return $"{this.size} Jurassic Java";
        }


        /// <summary>
        /// Leaves room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.cream = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes decaf.
        /// </summary>
        public void MakeDecaf()
        {
            this.decaf = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }

        public void AddIce()
        {
            this.ice = true;
            NotifyOfPropertyChange("Special");
        }
    }
}
