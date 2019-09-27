using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{

        public abstract class Entree
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


        }
    }

