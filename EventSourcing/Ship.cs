using System;
using System.Collections.Generic;

namespace EventSourcing
{
    public class Ship
    {
        public Port Port { get; set; }

        internal void HandleArrival(ArrivalEvent arrivalEvent)
        {
            Port = arrivalEvent.Port;
        }

        public void HandleDepartue(DepartureEvent departureEvent)
        {
            Port = Port.AT_SEA;
        }
    }
}