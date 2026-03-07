using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile_2
{
    internal class Bike : Vehicle
    {
        public override void GetName() { name = "Bike"; }
        public override void GetSpeed() { speed = 120; }
        public override void GetFuelType() { fuel = "Petrol"; }
        public override void GetCapacity() { capacity = 2; }
        public override void GetModel() { model = "Sports"; }

        public override void Start() { Console.WriteLine("Bike Started"); }
        public override void Stop() { Console.WriteLine("Bike Stopped"); }
        public override void Accelerate() { Console.WriteLine("Bike Accelerating"); }
        public override void Brake() { Console.WriteLine("Bike Braking"); }
        public override void Service() { Console.WriteLine("Bike Serviced"); }
    }
}
