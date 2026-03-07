using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile_Project
{
    internal abstract class Vehicle
    {
        protected string name;
        protected int speed;

        public abstract void GetInput();
        public abstract void ShowOutput();
    }
}
