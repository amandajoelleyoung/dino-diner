using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// DinoNuggets class.
    /// </summary>
    public class DinoNuggets : Entree
    {

        /// <summary>
        /// list of ingredients.
        /// </summary>
        private List<string> ingredients;

        /// <summary>
        /// returns list of Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
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
            ingredients = new List<string>();
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
        }


        /// <summary>
        /// Adds one chicken nugget and increases price and calories
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            this.Calories += 59;
            this.Price += .25;
        }
    }
}
