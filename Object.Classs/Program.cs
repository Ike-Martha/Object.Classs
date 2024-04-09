using ObjectClasss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
           Customer1 custA = new Customer1();
           Customer1 custB = new Customer1();

            custA.CustomerID = "AAA";
            custB.CustomerID = "BBB";

            Console.WriteLine("custA's customer ID = "  + custA.CustomerID);
            Console.WriteLine("custB's customer ID = "  + custB.CustomerID);

            custA.DisplayID();
            custB.DisplayID();

            

        }
    }
}