using System;

namespace Patterns
{
    public class CarAssembler
    {
        public Car AssembleCar(CarFactory brmbrm)
        {
            var car = brmbrm.MakeACar();
            Console.WriteLine("made a car with topspeed " + car.TopSpeed);
            return car;
        }
    }
}