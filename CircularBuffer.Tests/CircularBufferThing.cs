using System;

namespace CircularBuffer.Tests
{
    internal class CircularBufferThing <T>
    {
        private int _nextAvailableSlot;

        public CircularBufferThing()
        {
            CircularBuffer = new T[10];
        }

        public T[] CircularBuffer { get; set; }

        internal void Push(T message)
        {
            //add it in the slot
            CircularBuffer[_nextAvailableSlot % 10] = message;
            _nextAvailableSlot++;
            //what is the next available spot


        }
    }
}