using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A brautwurst wih a whole wheat bun, onions, and peppers.
    /// </summary>
    public class Brontowurst : Entrees
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

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
        /// A list of ingredients included in the Brontowurst. 
        /// If an ingredient is held, it is not included.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (bun) ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Brautwurst");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Initializes the price and calories in the brontowurst.
        /// </summary>
        public Brontowurst(){
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Does not include the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Does not include the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Does not include the onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
