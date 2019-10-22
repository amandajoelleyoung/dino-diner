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
    public class NotifyPropertyChangeSideTest
    {
        //Fryceritops

        [Fact]
        public void FryceritopsNotifyPropertyChangePrice()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Price", () =>
            {
                fry.Size = Size.Large;
            });
        }

        //MeteorMacnCheese

        [Fact]
        public void MeteorMacnCheeseNotifyPropertyChangePrice()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, "Price", () =>
            {
                mac.Size = Size.Large;
            });
        }

        //MezzorellaSticks

        [Fact]
        public void MezzorellaSticksNotifyPropertyChangePrice()
        {
            MezzorellaSticks stix = new MezzorellaSticks();
            Assert.PropertyChanged(stix, "Price", () =>
            {
                stix.Size = Size.Large;
            });
        }

        //Triceritots

        [Fact]
        public void TriceritotsNotifyPropertyChangePrice()
        {
            Triceritots tots = new Triceritots();
            Assert.PropertyChanged(tots, "Price", () =>
            {
                tots.Size = Size.Large;
            });
        }
    }
}
