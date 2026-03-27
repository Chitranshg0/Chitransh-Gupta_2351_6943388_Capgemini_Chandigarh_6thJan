using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile_2
{
    internal abstract class Vehicle :IVehicleInfo   , IVehicleOperation
    {
        protected string name, fuel, model;
        protected int speed, capacity;

        public abstract void GetName();
        public abstract void GetSpeed();
        public abstract void GetFuelType();
        public abstract void GetCapacity();
        public abstract void GetModel();

        public abstract void Start();
        public abstract void Stop();
        public abstract void Accelerate();
        public abstract void Brake();
        public abstract void Service();
    }
}
