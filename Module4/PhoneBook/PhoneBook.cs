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
    public class PhoneBook
    {
        #region Field
        // Create a field that is an array of an entity
        private Entity[] entity;
        #endregion

        #region Constructor
        // Create Default constructor that initializes the array to size 10
        public PhoneBook()
        {
            entity = new Entity[10];
        }
        #endregion

        #region Methods
        // Create AddEntity() method that takes Entity Object as param
        public void AddEntity(Entity entities)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                if (entity[i] == null)
                {
                    entity[i] = entities;
                    return;
                }
            }
        }

        // Create AddBusinessEntity() method that takes all parameters to create a business entity
        public void AddBusinessEntity(string address, string city, string state, string zip, string phoneNumber, string businessName)
        {
            var newBusiness = new Business(address, city, state, zip, phoneNumber, businessName);
            AddEntity(newBusiness);
        }

        // Create AddPersonEntity() method that takes params needed for person entity
        public void AddPersonEntity(string address, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
        {
            var newPerson = new Person(address, city, state, zip, phoneNumber, firstName, lastName);
            AddEntity(newPerson);
        }

        // Create PrintPhonebook() method that travers the phone book and prints all the non-null entities
        public void PrintPhoneBook()
        {
            Console.WriteLine();
            foreach (var entities in entity)
            {
                if (entities != null)
                {
                    entities.PrintEntity();
                    Console.WriteLine();
                }
            }
        }
        #endregion


    }
}