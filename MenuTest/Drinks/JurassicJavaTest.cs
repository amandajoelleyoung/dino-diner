using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.49, java.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveDefaultCaffination()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Decaf);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.Equal<double>(.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
            Assert.Equal<double>(1.49, java.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
            Assert.Equal<uint>(8, java.Calories);

        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact] 
        public void ShouldMakeDecaf()
        {
            JurrasicJava java = new JurrasicJava();
            java.MakeDecaf();
            Assert.True(java.Decaf);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredientsWithSugar()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

    }
}
