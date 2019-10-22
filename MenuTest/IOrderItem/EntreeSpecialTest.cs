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
    public class EntreeSpecialTest
    {

        [Theory]
        [InlineData(typeof(Brontowurst))]
        [InlineData(typeof(DinoNuggets))]
        [InlineData(typeof(PrehistoricPBJ))]
        [InlineData(typeof(PterodactylWings))]
        [InlineData(typeof(SteakosaurusBurger))]
        [InlineData(typeof(TRexKingBurger))]
        [InlineData(typeof(VelociWrap))]
        public void EntreeSpecialShouldBeEmpty(Type type)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            Assert.Empty(entree.Special);
        }
    }
}
