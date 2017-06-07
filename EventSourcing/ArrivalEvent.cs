using System;

namespace EventSourcing
{
    public class ArrivalEvent: Event
    {
        public Port Port { get; }
        public Ship Ship { get; }

        public ArrivalEvent(DateTime occured, Ship ship, Port port) : base(occured)
        {
            this.Ship = ship;
            this.Port = port;
        }

        public override void Process()
        {
            Ship.HandleArrival(this);
        }
    }
}