/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets class.
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        private int extraNuggets=0;


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
                if (extraNuggets > 0) special.Add(extraNuggets + " Extra Nuggets");
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns list of Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                int x = extraNuggets;
                while (x != 0)
                {
                    ingredients.Add("Chicken Nugget");
                    x--;
                }
                return ingredients;
            }
        }

        /// <summary>
        /// initializes price and calories and chicken nuggets in ingredients.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// Returns a string of the class name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Dino-Nuggets";
        }

        /// <summary>
        /// Adds one chicken nugget and increases price and calories
        /// </summary>
        public void AddNugget()
        {
            extraNuggets++;
            this.Calories += 59;
            this.Price += .25;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }
    }
}
