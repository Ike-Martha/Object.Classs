using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object.Classs
{
    public class Customer2//fields
    {
        private string _City;
        private string _Country = "Nigeria";
        private string _CustomerID;
        private string _CustomerName;
        private string _PostalCode;
        private string _Region;

        /// <param name="CustomerID">ID for the new customer</param>
        public Customer2(string CustomerID)//Constructor
        {
            CustomerID = CustomerID;
        }

        public string CustomerID//properties
        {
            get
            {
                return _CustomerID;
            }
            
        }

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }

        public string City
        {
            get 
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }

        public string Region
        {
            get 
            {
                return _Region;
            }
            set
            {
                _Region = value;
            }
        }

        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                _PostalCode = value;
            }
        }
        public string Location
        {
            get
            {
                return string.Format($"{_City} {_Region} {_PostalCode}");
            }
        }

        //methods overloaded
        public void UpdateLocation(string NewCity, string NewRegion, string NewPostalCode)
        {
            _City = NewCity;
            _Region = NewRegion;
            _PostalCode = NewPostalCode;

        }

        public void UpdateLocation(string NewCity, string NewRegion,
            string NewPostalCode, string NewCountry)
        {
            _City = NewCity;
            _Region = NewRegion;
            _PostalCode = NewPostalCode;
            _Country = NewCountry;
        }
        public string GetLocation()
        {
            return string.Format($"{_City} {_Region} {_PostalCode}");
        }
    }
}