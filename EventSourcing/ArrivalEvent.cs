using System;

namespace EventSourcing
{
    public class ArrivalEvent: Event
    {
        private Ship ship;
        private Port port;

        public ArrivalEvent(DateTime occured, Ship ship, Port port) : base(occured)
        {
            this.ship = ship;
            this.port = port;
        }

        public override void Process()
        {
            Ship.HandleArrival(this);
        }
    }
}