using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile_2
{
    internal interface IVehicleOperation
    {
        void Start();
        void Stop();
        void Accelerate();
        void Brake();
        void Service();
    }
}
