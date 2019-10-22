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

        //Brontowurst
        
        [Fact]
        public void BrontowurstShouldHaveNoBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Contains("Hold Bun", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void BrontowurstShouldHaveNoOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Contains("Hold Onion", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void BrontowurstShouldHaveNoPepper()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Contains("Hold Pepper", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void BrontowurstShouldHaveAllThree()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            bw.HoldPeppers();
            Assert.Contains("Hold Pepper", bw.Special);
            Assert.Contains("Hold Onion", bw.Special);
            Assert.Contains("Hold Bun", bw.Special);
            Assert.Equal(3, bw.Special.Length);
        }

        //Dinonuggets
        [Fact]
        public void DinoNuggetsShouldHaveOneExtraNugget()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Contains("1 Extra Nuggets", dn.Special);
            Assert.Single(dn.Special);
        }

        [Fact]
        public void DinoNuggetsShouldHaveThreeExtraNuggets()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            Assert.Contains("3 Extra Nuggets", dn.Special);
            Assert.Single(dn.Special);
        }

        //prehistoric pbj

        [Fact]
        public void PrehistoricPBJShouldHoldPeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.Contains("Hold Peanut Butter", pbj.Special);
            Assert.Single(pbj.Special);
        }

        [Fact]
        public void PrehistoricPBJShouldHoldJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Contains("Hold Jelly", pbj.Special);
            Assert.Single(pbj.Special);
        }

        [Fact]
        public void PrehistoricPBJShouldHoldJellyAndPeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            pbj.HoldPeanutButter();
            Assert.Contains("Hold Jelly", pbj.Special);
            Assert.Contains("Hold Peanut Butter", pbj.Special);
            Assert.Equal(2, pbj.Special.Length);
        }

        //steakosaurus burger

        [Fact]
        public void SteakosaurusShouldHoldBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.Contains("Hold Bun", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void SteakosaurusShouldHoldPickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Contains("Hold Pickle", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void SteakosaurusShouldHoldKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Contains("Hold Ketchup", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void SteakosaurusShouldHoldMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Contains("Hold Mustard", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void SteakosaurusShouldHoldAllFour()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldMustard();
            sb.HoldPickle();
            Assert.Contains("Hold Bun", sb.Special);
            Assert.Contains("Hold Pickle", sb.Special);
            Assert.Contains("Hold Ketchup", sb.Special);
            Assert.Contains("Hold Mustard", sb.Special);
            Assert.Equal(4, sb.Special.Length);
        }

        //trex king burger

        [Fact]
        public void TRexBurgerShouldHoldBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.Contains("Hold Bun", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Contains("Hold Tomato", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Contains("Hold Onion", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void TRexBurgerShouldHoldMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Contains("Hold Mayo", trex.Special);
            Assert.Single(trex.Special);
        }
        
        [Fact]
        public void TRexBurgerShouldHoldAllEight()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldKetchup();
            trex.HoldLettuce();
            trex.HoldMayo();
            trex.HoldMustard();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldTomato();
            Assert.Contains("Hold Bun", trex.Special);
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Contains("Hold Tomato", trex.Special);
            Assert.Contains("Hold Onion", trex.Special);
            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Contains("Hold Mayo", trex.Special);
            Assert.Equal(8, trex.Special.Length);
        }

        //veloci-wrap

        [Fact]
        public void VelociwrapShouldHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void VelociwrapShouldHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void VelociwrapShouldHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void VelociwrapShouldHoldAllThree()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            vw.HoldDressing();
            vw.HoldCheese();
            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Equal(3, vw.Special.Length);
        }
    }
}
