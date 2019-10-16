/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

        public abstract class Entree : IMenuItem
        {
            /// <summary>
            /// Gets and sets the price
            /// </summary>
            public virtual double Price { get; set; }

            /// <summary>
            /// Gets and sets the calories
            /// </summary>
            public virtual uint Calories { get; set; }

            /// <summary>
            /// Gets the ingredients list
            /// </summary>
            public abstract List<string> Ingredients { get; }

            public virtual string[] Special { get; }
        }
    }

