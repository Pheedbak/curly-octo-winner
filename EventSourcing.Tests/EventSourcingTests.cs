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
        private Ship ship = new Ship { Port = new Port()};
        private Port port = new Port();
        private EventProcessor eventProcessor =  new EventProcessor();

        [Theory]
        //[InlineData(20)]
        public void CanIBuySomeShit()
        {
            ArrivalEvent ev = new ArrivalEvent(DateTime.Now,ship, port);
            eventProcessor.Process(ev);
            Assert.Equal(port, ship.Port);
        }
    }
}
