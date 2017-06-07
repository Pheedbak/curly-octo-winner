using System;
using Xunit;

namespace EventSourcing.Tests
{
    public class EventSourcingTests
    {
        private static Ship ship = new Ship { Port = new Port()};
        private static Ship shipToDepart = new Ship { Port = Port.AT_SEA};
        private Port port = new Port();
        private EventProcessor eventProcessor =  new EventProcessor();

        [Theory]
        [InlineData(20)]
        public void DockTheShip (int beer)
        {
            var ev = new ArrivalEvent(DateTime.Now,ship, port);
            eventProcessor.Process(ev);
            Assert.Equal(port, ship.Port);
        }

        [Theory]
        [ClassData(typeof(Ship))]
        public void SetSail(Ship shipToDepart)
        {
            shipToDepart = new Ship { Port = Port.AT_SEA };
            var ev = new DepartureEvent(DateTime.Now, shipToDepart, port);

        }
    }
}
