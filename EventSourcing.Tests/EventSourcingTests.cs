using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EventSourcing;

namespace EventSourcing.Tests
{
    public class EventSourcingTests
    {
        private Ship ship;
        private Port port;
        private EventProcessor eventProcessor;

        [Theory]
        [InlineData(20)]
        public void CanIBuySomeShit(int dollars)
        {
            ArrivalEvent ev = new ArrivalEvent(DateTime.Now,ship, port);
            eventProcessor.Process(ev);
            Assert.Equal(port, ship.Port.ToList().First());
        }
    }
}
