using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //4
            IDriveable[] Vehicles = new IDriveable[150];
            int Id = 1;

            for (int i = 0; i < 50; i++)
            {
                Vehicles[i] = new Car(Id++, "Porsche", i * 150);
            }

            for (int i = 50; i < 100; i++)
            {
                Vehicles[i] = new Motorcycle(Id++, "Harley", 1990 + (i - 50));
            }

            for (int i = 100; i < 150; i++)
            {
                Vehicles[i] = new Truck(Id++, "Tatra", 10 + (i * 10));
            }

            //6
            Console.WriteLine("ID list of 50 cars, 50 motorcycles and 50 trucks:");
            Console.WriteLine();
            foreach (var vehicle in Vehicles)
            {
                vehicle.Drive();
                Console.WriteLine();
            }

            //5
            Vehicle[] vehicles = new Vehicle[60];
            Id = 1;

            for (int i = 0; i < 30; i++)
            {
                vehicles[i] = new Car(Id++, "Porsche", i * 150);
            }

            for (int i = 30; i < 50; i++)
            {
                vehicles[i] = new Motorcycle(Id++, "Harley", 1990 + (i - 50));
            }

            for (int i = 50; i < 60; i++)
            {
                vehicles[i] = new Truck(Id++, "Tatra", 10 + (i * 10));
            }

            //7
            Console.WriteLine("Additional information for 30 cars, 20 motorcycles and 10 trucks:");
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                Console.WriteLine();
                vehicle.DisplayInfo();                
                Console.WriteLine();
            }
        }
    }
}


    
