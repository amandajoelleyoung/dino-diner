using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int nuggetNum;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public DinoNuggets()
        {
            this.nuggetNum = 6;
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                return ingredients;
            }
        }

        public void AddNugget(int x)
        {
            if (x > 0)
            {
                this.nuggetNum += x;
                this.Calories += (uint)(59 * x);
            }
        }
    }
}
