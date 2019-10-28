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
            order.Add(new Fryceritops());
            order.Add(new SteakosaurusBurger());
            order.Add(new Water());
            Assert.Equal(6.80, order.TotalCost, 2);
        }
    }
}
