using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Patterns;

namespace Patterns.Tests
{
    public class FactoryTester
    {

        [Theory]
        [InlineData(500)]
        public void MakeAFezza(int topspeed)
        {

            var brmbrm = new FerrariCarFactory();
            new CarAssembler().AssembleCar(brmbrm);
            var whatCar = brmbrm.MakeACar();
            Assert.Equal(topspeed, whatCar.TopSpeed);

        }

        [Theory]
        [InlineData(2)]
        public void MakeAPunto(int topspeed)
        {
            var brmbrm = new PuntoCarFactory();
            new CarAssembler().AssembleCar(brmbrm);
            var whatCar = brmbrm.MakeACar();
            Assert.Equal(topspeed, whatCar.TopSpeed);
        }
    }
}
