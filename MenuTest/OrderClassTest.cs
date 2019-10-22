/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderClassTest
    {
        [Fact]
        public void OrderShouldBeCorrect()
        {
            Order order = new Order();
            order.Items.Add(new Fryceritops());
            order.Items.Add(new SteakosaurusBurger());
            order.Items.Add(new Water());
            Assert.Equal(6.80, order.TotalCost, 2);
        }
    }
}
