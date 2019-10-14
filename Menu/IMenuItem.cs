/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Returns the menu item price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Returns the menu item calorie number.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Returns the list of ingredients.
        /// </summary>
        List<string> Ingredients { get; }

    }
}
