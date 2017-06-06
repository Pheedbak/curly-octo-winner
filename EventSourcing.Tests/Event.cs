using System;

namespace EventSourcing.Tests
{
    abstract class Event
    {
        DateTime recorded, occured;

        internal Event (DateTime occured )
        {
            this.occured = occured;
            this.recorded = DateTime.Now;
        }
        abstract internal void Process();
    }
}