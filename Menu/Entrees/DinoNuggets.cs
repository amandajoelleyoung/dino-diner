using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int nuggetNum = 6;
        List<string> ingredients;

        public double Price { get; set; }
        public uint Calories { get; set; }

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

        public List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            this.Calories += 59;
            this.Price += .25;
        }
    }
}
