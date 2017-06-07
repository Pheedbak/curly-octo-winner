using System;

namespace EventSourcing
{
    public class DepartureEvent : Event
    {
        private DateTime now;
        private Ship ship;
        private Port port;

        public DepartureEvent(DateTime now, Ship ship, Port port) : base(now)
        {
            this.now = now;
            this.ship = ship;
            this.port = port;
        }

        public override void Process()
        {
            ship.HandleDepartue(this);
        }
    }
}