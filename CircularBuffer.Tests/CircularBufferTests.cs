using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CircularBuffer.Tests
{
    public class CircularBufferTests
    {
        private readonly ClientMessage message;
        private int i;

        [Theory]
        [InlineData(20)]
        public void AddToMyBuffer(int data)
        {
            var buff = new CircularBufferThing<string>();
            while (i < 20)
            {
                buff.Push("hi" + i);
                i++;
            }
            
        }
    }
}
