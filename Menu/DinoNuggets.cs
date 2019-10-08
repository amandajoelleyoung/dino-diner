/* CIS 500
 * Amanda Young
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets class.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {
        private int extraNuggets=0;
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
                for (int i = 1; i > extraNuggets; i++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
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
        }
    }
}
