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
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void JurassicJavaNotifyPropertyChangeDescription()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void JurassicJavaNotifyPropertyChangePrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            });
        }

        //TyrannoTea

        [Fact]
        public void TyrannoteaPropertyChangeSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => 
            {
                tea.AddSugar();
            });
        }

        [Fact]
        public void TyrannoteaPropertyChangeDescription()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.AddSugar();
            });

        }

        [Fact]
        public void TyrannoteaPropertyChangePrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });

        }

        //Sodasaurus

        [Fact]
        public void SodasaurusPropertyChangeSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });

        }

        [Fact]
        public void SodasaurusPropertyChangePrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large;
            });

        }

        //Water

        [Fact]
        public void WaterPropertyChangeSpecial()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Fact]
        public void WaterPropertyChangeDescription()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.AddLemon();
            });
        }
    }
}
