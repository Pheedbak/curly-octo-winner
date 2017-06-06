using CheckMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CheckMeTests
{
    public class CheckoutTests
    {
        [Theory]
        [InlineData(20)]
        public void CanIBuySomeShit (int dollars)
        {
            Checkout checkout = new Checkout();
            checkout.AddToCart(123,2);

            Assert.Equal(checkout.Total(), dollars);

        }
    }
}
