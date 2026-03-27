using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Automobile_2
{
    internal class Airplane : Vehicle
    {
        public override void GetName() { name = "Airplane"; }
        public override void GetSpeed() { speed = 900; }
        public override void GetFuelType() { fuel = "Aviation Fuel"; }
        public override void GetCapacity() { capacity = 180; }
        public override void GetModel() { model = "Commercial"; }

        public override void Start() { Console.WriteLine("Airplane Takeoff"); }
        public override void Stop() { Console.WriteLine("Airplane Landed"); }
        public override void Accelerate() { Console.WriteLine("Airplane Speed Increased"); }
        public override void Brake() { Console.WriteLine("Airplane Slowing Down"); }
        public override void Service() { Console.WriteLine("Airplane Serviced"); }
    }
}
