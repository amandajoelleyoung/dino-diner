using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
       
        public abstract class Drinks
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
            
            /// <summary>
            /// States whether drink has ice or not.
            /// </summary>
            public abstract bool Ice { get; }
            
            /// <summary>
            /// Holds ice.
            /// </summary>
            public abstract void HoldIce();

        }
}
