using Object.Classs;
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
            //Customer1 custA = new Customer1();
            //Customer1 custB = new Customer1();

            //custA.CustomerID = "AAA";
            //custB.CustomerID = "BBB";

            //Console.WriteLine("custA's customer ID = " + custA.CustomerID);
            //Console.WriteLine("custB's customer ID = " + custB.CustomerID);

            //custA.DisplayID();
            //custB.DisplayID();

           


            
            {
                Customer2 custA = new Customer2("Appa");
                Customer2 custB = new Customer2("Bppb");

                custA.CustomerName = "Ella Jonas";
                custA.UpdateLocation("Lagos", "Lag", "10000");

                Console.WriteLine(custA.GetLocation());
                Console.WriteLine(custA.Country);

                custB.CustomerName = "James Peter";
                custB.UpdateLocation("New York", "Ny", "10022", "America");

                Console.WriteLine(custB.GetLocation());
                Console.WriteLine(custB.Country);

            }
        }
    }
}