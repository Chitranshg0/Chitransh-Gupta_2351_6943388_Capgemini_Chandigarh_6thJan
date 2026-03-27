using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Automobile_Project
{
    internal class Airplane:Vehicle
    {
        public override void GetInput()
        {
            Console.Write("Enter Airplane Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Airplane Speed: ");
            speed = int.Parse(Console.ReadLine());
        }

        public override void ShowOutput()
        {
            Console.WriteLine("Airplane Name: " + name);
            Console.WriteLine("Airplane Speed: " + speed + " km/h");
        }
    }
}
