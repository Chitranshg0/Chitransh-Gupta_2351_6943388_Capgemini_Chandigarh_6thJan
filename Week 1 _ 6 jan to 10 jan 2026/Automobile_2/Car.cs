using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Automobile_2
{
    internal class Car:Vehicle 
    {
        public override void GetName() { name = "Car"; }
        public override void GetSpeed() { speed = 180; }
        public override void GetFuelType() { fuel = "Petrol"; }
        public override void GetCapacity() { capacity = 5; }
        public override void GetModel() { model = "Sedan"; }

        public override void Start() { Console.WriteLine("Car Started"); }
        public override void Stop() { Console.WriteLine("Car Stopped"); }
        public override void Accelerate() { Console.WriteLine("Car Accelerating"); }
        public override void Brake() { Console.WriteLine("Car Braking"); }
        public override void Service() { Console.WriteLine("Car Serviced"); }
    }
}
