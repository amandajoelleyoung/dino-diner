using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Prehistoric PBJ class.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Keeps track of whether the ingredients include peanut butter or not.
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Keeps track whether the ingredients include jelly or not.
        /// </summary>
        private bool jelly = true;


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
        /// Returns list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets price and calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Does not include peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Does not include jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
