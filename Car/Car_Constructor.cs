using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    internal class Car_Constructor
    {
        public int model_no, speed;
        public string brand_name, colour;
       Car_Constructor()
        {
            Console.WriteLine("***********KYA BOLTI PUBLIC SHOWROOM**********");
        }
        Car_Constructor(string c)
        {
            Console.WriteLine(c);
        }
        public void get_info()
        {

            Console.WriteLine("Car brand - ");
            brand_name = Console.ReadLine();
            Console.WriteLine("Car Model - ");
            model_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Car Color- ");
            colour = Console.ReadLine();
            Console.WriteLine("Car's Top speed");
            speed = int.Parse(Console.ReadLine());
        }
        public void put_info()
        {
            Console.WriteLine("Car brand - " + brand_name);
            Console.WriteLine("Car color " + colour);
            Console.WriteLine("Car top speed " + speed);
            Console.WriteLine("Car model no." + model_no);
        }

        public void put_info(string brand_name, string colour, int speed, int model_no)
        {
            Console.WriteLine("Car brand - " + brand_name);
            Console.WriteLine("Car color " + colour);
            Console.WriteLine("Car top speed " + speed);
            Console.WriteLine("Car model no." + model_no);
        }
        static void Main(string[] args)
        {
             Car_Constructor Maruti = new Car_Constructor();
            Car_Constructor lM = new Car_Constructor("WHICH CAR YOU WANT TO BUY");
       
        Maruti.get_info();
             Maruti.put_info("Toyota", "Silver", 150, 34234);
             Maruti.put_info();

         }
}
}

