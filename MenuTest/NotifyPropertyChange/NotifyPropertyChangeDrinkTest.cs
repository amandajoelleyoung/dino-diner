/* CIS 400
 * Amanda Young
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.NotifyPropertyChange
{
    public class NotifyPropertyChangeDrinkTest
    {
        //JurassicJava

        [Fact]
        public void JurassicJavaNotifyPropertyChangeSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.PropertyChanged(java.PropertyChanged, "Special", java.LeaveRoomForCream);
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

        [Fact]
        public void SodasaurusSpecialContainsNoIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Contains("Hold Ice", soda.Special);
            Assert.Single(soda.Special);
        }

        //Water

        [Fact]
        public void WaterSpecialContainsJustLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains("Add Lemon", water.Special);
            Assert.Single(water.Special);
        }

        [Fact]
        public void WaterSpecialContainsNoIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Contains("Hold Ice", water.Special);
            Assert.Single(water.Special);
        }

        [Fact]
        public void WaterSpecialContainsAllTwo()
        {
            Water water = new Water();
            water.AddLemon();
            water.HoldIce();
            Assert.Contains("Hold Ice", water.Special);
            Assert.Contains("Add Lemon", water.Special);
            Assert.Equal<int>(2, water.Special.Length);
        }
    }
}
