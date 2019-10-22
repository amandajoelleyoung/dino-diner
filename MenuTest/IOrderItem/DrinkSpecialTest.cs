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
    public class DrinkSpecialTest
    {
        [Theory]
        [InlineData(typeof(Tyrannotea))]
        [InlineData(typeof(Sodasaurus))]
        [InlineData(typeof(JurassicJava))]
        [InlineData(typeof(Water))]
        public void IngredientsShouldBeImmutable(Type type)
        {
            Drink item = (Drink)Activator.CreateInstance(type);
            Assert.Empty(item.Special);
        }

        //JurassicJava

        [Fact]
        public void JurassicJavaSpecialContainsAddRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Contains("Add Room for Cream", java.Special);
        }

        //TyrannoTea

        [Fact]
        public void TyrannoteaSpecialContainsJustLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains("Add Lemon", tea.Special);
            Assert.Single(tea.Special);
        }

        [Fact]
        public void TyrannoteaSpecialContainsJustSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSugar();
            Assert.Contains("Add Sweet", tea.Special);
            Assert.Single(tea.Special);
        }

        [Fact]
        public void TyrannoteaSpecialContainsNoIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Contains("Hold Ice", tea.Special);
            Assert.Single(tea.Special);
        }

        [Fact]
        public void TyrannoteaSpecialContainsAllThree()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.AddSugar();
            tea.HoldIce();
            Assert.Contains("Hold Ice", tea.Special);
            Assert.Contains("Add Sweet", tea.Special);
            Assert.Contains("Add Lemon", tea.Special);
            Assert.Equal<int>(3, tea.Special.Length);
        }

        //Sodasaurus


    }
}
