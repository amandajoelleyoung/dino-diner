/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Meteor Mac And Cheese class.
    /// </summary>
    public class MeteorMacAndCheese : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Returns description of entree item.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Returns list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }

        private Size size;
        /// <summary>
        /// sets price, calories, size, and returns size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Sets size to small and adds ingredients.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            
        }

        /// <summary>
        /// Returns a string of the class name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.size} Meteor Mac and Cheese";
        }

    }
}
