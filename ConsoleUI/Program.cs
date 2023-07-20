using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Done follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2020",
                Make = "Toyota",
                Model = "Corolla"
            };
            var motorcycle = new Motorcycle()
            {
                HasSideCart = true,
                Year = "2023",
                Make = "Ducati",
                Model = "Monster"
            };
            Vehicle car2 = new Car()
            {
                HasTrunk = true,
                Year = "2012",
                Make = "Toyota",
                Model = "Prius"
            };
            Vehicle motorcycle2 = new Motorcycle()
            {
                HasSideCart = true,
                Year = "2018",
                Make = "Ducati",
                Model = "Multistrada"
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and Vehione motorcycle
            var vehicles = new List<Vehicle>();
            vehicles.Add(car1);
            vehicles.Add(motorcycle);
            vehicles.Add(car2);
            vehicles.Add(motorcycle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
