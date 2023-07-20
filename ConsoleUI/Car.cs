using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    /* 
         * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
         * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
         * Provide the implementations for the abstract methods
         * Only in the Motorcycle class will you override the virtual drive method
        */
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This is a 4 door vehicle!");
        }
        public bool HasTrunk { get; set; }
    }
    /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
}
