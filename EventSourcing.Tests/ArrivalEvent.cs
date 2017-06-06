using System;

namespace EventSourcing.Tests
{
    internal class ArrivalEvent: Event
    {
        private object ship;
        private object port;

        internal ArrivalEvent(DateTime time, Ship ship, Port port) : base(time)
        {
            this.ship = ship;
            this.port = port;
        }

        internal override void Process()
        {
            throw new NotImplementedException();
        }
    }
}