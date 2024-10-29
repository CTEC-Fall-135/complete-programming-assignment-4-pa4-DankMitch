/* 
Author: Dank Mitchell
Date: 25 Oct 2024
Assignment: PA4
*/

using System;
using System.Net;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Address object and PrintState
            var testAddress = new Address("37 Default Street", "Vancouver", "WA", "12345");
            Console.WriteLine($"Test Address Class");
            testAddress.PrintAddress();

            // Create a Business object and Printstate
            var testBusiness = new Business("37 Default Street", "Vancouver", "WA", "12345", "333-7777", "Tiger Designs Inc.");
            Console.WriteLine($"Test Business Class");
            testBusiness.PrintEntity();

            // Create a Person object and Printstate
            var testPerson = new Person("37 Default Street", "Vancouver", "WA", "12345", "333-7777", "William", "Thetiger");
            Console.WriteLine($"Test Person Class");
            testPerson.PrintEntity();

            // Create test adding entities to the phonebook and print it
            var testPhoneBook = new PhoneBook();

            testPhoneBook.AddBusinessEntity("37 Default Street", "Vancouver", "WA", "12345", "333-7777", "Tiger Designs Inc. II");
            testPhoneBook.AddPersonEntity("37 Default Street", "Vancouver", "WA", "12345", "333-7777", "William", "Thetiger");

            testPhoneBook.PrintPhoneBook();
        }
    }
}
