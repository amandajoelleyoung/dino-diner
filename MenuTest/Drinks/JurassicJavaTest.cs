/* CIS 400
 * Amanda Young
 */
 using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.49, java.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveDefaultCaffination()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Decaf);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.Equal<double>(.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
            Assert.Equal<double>(1.49, java.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
            Assert.Equal<uint>(8, java.Calories);

        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact] 
        public void ShouldMakeDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.MakeDecaf();
            Assert.True(java.Decaf);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredientsWithSugar()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

    }
}
