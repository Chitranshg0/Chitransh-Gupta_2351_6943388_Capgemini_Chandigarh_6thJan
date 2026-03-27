using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Automobile_Project
{
    internal class Car:Vehicle
    {
        public override void GetInput()
        {
            Console.Write("Enter Car Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Car Speed: ");
            speed = int.Parse(Console.ReadLine());
        }

        public override void ShowOutput()
        {
            Console.WriteLine("Car Name: " + name);
            Console.WriteLine("Car Speed: " + speed + " km/h");
        }
    }
}
