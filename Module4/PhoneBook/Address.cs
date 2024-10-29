/* 
Author: Dank Mitchell
Date: 25 Oct 2024
Assignment: PA4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public class Address
    {
        #region Properties
        // Auto Properties for street address (number, street name, apt #), city, state, zip
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        #endregion

        #region Constructor
        // Create primary constructor that initalizes StreetAddress, City, State, Zip
        public Address(string address, string city, string state, string zip)
        {
            StreetAddress = address;
            City = city;
            State = state;
            PostalCode = zip;

        }
        #endregion

        #region Methods
        // Create method that prints address on two lines
        public void PrintAddress()
        {
            Console.WriteLine($"{StreetAddress}\n{City}, {State}, {PostalCode}\n");
        }
        #endregion

    }
}