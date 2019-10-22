/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.IOrderItem
{
    public class SideSpecialTest
    {
        [Theory]
        [InlineData(typeof(Fryceritops))]
        [InlineData(typeof(Triceritots))]
        [InlineData(typeof(MeteorMacAndCheese))]
        [InlineData(typeof(MezzorellaSticks))]
        public void SideSpecialShouldBeEmpty(Type type)
        {
            Side item = (Side)Activator.CreateInstance(type);
            Assert.Empty(item.Special);
        }
    }
}
