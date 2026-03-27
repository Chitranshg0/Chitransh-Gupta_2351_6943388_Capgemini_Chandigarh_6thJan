using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Automobile_Project
{
    internal class Bike:Vehicle 
    {
        public override void GetInput()
        {
            Console.Write("Enter Bike Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Bike Speed: ");
            speed = int.Parse(Console.ReadLine());
        }

        public override void ShowOutput()
        {
            Console.WriteLine("Bike Name: " + name);
            Console.WriteLine("Bike Speed: " + speed + " km/h");
        }
    }
}
