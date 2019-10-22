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
    public class NotifyPropertyChangeEntreeTest
    {

        //Brontowurst

        [Fact]
        public void BrontowurstPropertyChangeSpecial()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
        }

        [Fact]
        public void BrontowurstPropertyChangeDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Description", () =>
            {
                bw.HoldBun();
            });
        }

        //Dinonuggets
        [Fact]
        public void DinoNuggetsPropertyChangedSpecial()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () =>
            {
                dn.AddNugget();
            });
        }

        [Fact]
        public void DinoNuggetsPropertyChangedDescription()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Description", () =>
            {
                dn.AddNugget();
            });
        }

        //prehistoric pbj

        [Fact]
        public void PrehistoricPBJPropertyChangedSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }

        [Fact]
        public void PrehistoricPBJPropertyChangedDescription()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Description", () =>
            {
                pbj.HoldJelly();
            });
        }

        //steakosaurus burger

        [Fact]
        public void SteakosaurusPropertyChangedSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
        }

        [Fact]
        public void SteakosaurusPropertyChangedDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Description", () =>
            {
                sb.HoldBun();
            });
        }

        //trex king burger

        [Fact]
        public void TRexKingBurgerPropertyChangedSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }

        [Fact]
        public void TRexKingBurgerPropertyChangedDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Description", () =>
            {
                trex.HoldBun();
            });
        }

        //veloci-wrap

        [Fact]
        public void VelociWrapPropertyChangedSpecial()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }

        [Fact]
        public void VelociWrapPropertyChangedDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Description", () =>
            {
                vw.HoldCheese();
            });
        }
    }
}
