/* CIS 400
 * Amanda Young
 */
 using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        List<IOrderItem> items = new List<IOrderItem>();

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        public double SubtotalCost
        {
            get
            {
                double total = 0;
                if (Items.Length > 0)
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

        private double salestaxrate = .0895;
        public double SalesTaxRate
        {
            get { return salestaxrate; }
            set
            {
                if (value >= 0) salestaxrate = value;
                else salestaxrate = 0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

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

        public Order()
        {
            //Items = new ObservableCollection<IOrderItem>();
            //items.CollectionChanged += OnCollectionChanged;
            items = new List<IOrderItem>();
        }



        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChange();
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChange();
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChange();
        }

        protected void NotifyAllPropertyChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

    }
}
