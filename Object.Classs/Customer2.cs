using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object.Classs
{
    public class Customer2
    {
        private string _City;
        private string _Country;
        private string _CustomerID;
        private string _CustomerName;
        private string _PostalCode;
        private string _Region;

        /// <param name="CustomerID">ID for the new customer</param>
        public Customer2(string CustomerID)
        {
            throw new System.NotImplementedException();
        }

        public string CustomerID
        {
            get => default;
            set
            {
            }
        }

        public string CustomerName
        {
            get => default;
            set
            {
            }
        }

        public string City
        {
            get => default;
            set
            {
            }
        }

        public string Region
        {
            get => default;
            set
            {
            }
        }

        public string Country
        {
            get => default;
            set
            {
            }
        }

        public string PostalCode
        {
            get => default;
            set
            {
            }
        }

        public void UpdateLocation(string NewCity, string NewRegion, string NewPostalCode)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLocation(string NewCity, string NewRegion, string NewPostalCode, string NewCountry)
        {
            throw new System.NotImplementedException();
        }
    }
}