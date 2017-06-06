using System;

namespace EventSourcing
{
    public abstract class Event
    {
        DateTime recorded, occured;

        internal Event (DateTime occured )
        {
            this.occured = occured;
            this.recorded = DateTime.Now;
        }
        abstract public void Process();
    }
}