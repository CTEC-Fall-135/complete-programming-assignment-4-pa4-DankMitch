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
    public abstract class Entity
    {
        #region Properties
        // Create 2 auto properties - Address of type address and PhoneNumber of type string
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        #endregion

        #region Constructor
        // Create constructor with 5 params of address and phonenumber
        public Entity(string address, string city, string state, string zip, string phoneNumber)
        {
            Address = new Address(address, city, state, zip);
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region Methods
        // create abstract method named Print Entity()
        public abstract void PrintEntity();
        
        #endregion
    }

    public class Business : Entity
    {
        #region Properties
        // Create auto property for buiness name
        public string BusinessName { get; set; }

        #endregion

        #region Constructor
        // Create constructor with 5 params of address and phonenumber plus businessName
        public Business(string address, string city, string state, string zip, string phoneNumber, string businessName)
            : base(address, city, state, zip, phoneNumber) 
        {
            BusinessName = businessName;
        }

        #endregion

        #region Methods
        // create business class override the PrintAddress so business name is printed above
        public override void PrintEntity()
        {
            Console.WriteLine(BusinessName);
            Address.PrintAddress();
            
        }

        #endregion
    }

    public class Person : Entity
    {
        #region Properties
        // Create 2 auto properties for first and last names
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region Constructor
        // Create a constructor with 7 params, 5 for entity plus first and last name
        public Person(string address, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
            : base(address, city, state, zip, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        #endregion

        #region
        // Override the PrintAddress() method to print person first and last names above address
        public override void PrintEntity()
        { 
            Console.WriteLine($"{FirstName} {LastName}");
            Address.PrintAddress();
        }
        #endregion

        }
}