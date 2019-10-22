/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

        public abstract class Entree : IMenuItem, IOrderItem
        {
            /// <summary>
            /// Gets and sets the price
            /// </summary>
            public virtual double Price { get; protected set; }

            /// <summary>
            /// Gets and sets the calories
            /// </summary>
            public virtual uint Calories { get; protected set; }

            /// <summary>
            /// Gets the ingredients list
            /// </summary>
            public abstract List<string> Ingredients { get; }
            
            /// <summary>
            /// Gets the description of the item
            /// </summary>
            public virtual string Description { get; }
            
            /// <summary>
            /// Gets the special preparation instructions
            /// </summary>
            public virtual string[] Special { get; }
        }
    }

