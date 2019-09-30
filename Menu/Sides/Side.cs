using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{


    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public abstract double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public abstract uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
