using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public double SubtotalCost
        {
            get
            {
                double total = 0;
                if (Items.Count > 0)
                {
                    foreach (IOrderItem item in Items)
                    {
                        total += item.Price;
                    }
                }
                if (total >= 0) return total;
                else return 0;
            }
        }

        public double SalesTaxRate { get; protected set; } = .0895;

        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
