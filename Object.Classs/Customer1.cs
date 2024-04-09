using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasss
{
    internal class Customer1
    {
        public string CustomerID = null;//Unique identifier for this customer

        /// <summary>
        /// display the customerID field to the console window
        /// </summary>
        public void DisplayID(string v)//public method to return nothing
        {
            Console.WriteLine(this.CustomerID);  //the This keyword displays the current instance of the class
        }
        /// <summary>
        /// Display supplied text and the customerID field to the console window
        /// </summary>
        /// <param name="Text"> Text to prefix the customer ID</param>
        public void Display(string Text)
        {
            Console.WriteLine(Text + ": " + CustomerID);
        }

        internal void DisplayID()
        {
            throw new NotImplementedException();
        }
    }
}
