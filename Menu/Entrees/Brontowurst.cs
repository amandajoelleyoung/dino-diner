using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A brautwurst wih a whole wheat bun, onions, and peppers.
    /// </summary>
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// The price of the Brontowurst.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories in the Brontowurst.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A list of ingredients included in the Brontowurst. 
        /// If an ingredient is held, it is not included.
        /// </summary>
        public List<string> Ingredients
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
        /// Initializes the price and calories in the Brontowurst.
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
