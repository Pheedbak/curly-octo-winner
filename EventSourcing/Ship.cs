using System;
using System.Collections.Generic;

namespace EventSourcing
{
    public class Ship
    {
        public IEnumerable<Port> Port;

        internal static void HandleArrival(ArrivalEvent arrivalEvent)
        {
            throw new NotImplementedException();
        }
    }
}