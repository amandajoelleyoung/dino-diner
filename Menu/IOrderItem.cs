/* CIS 400
 * Amanda Young
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Returns the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Returns the description of the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Returns the special preparation instructions of the item.
        /// </summary>
        string[] Special { get; }
    }
}
