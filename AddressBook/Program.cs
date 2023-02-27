using System.Text.Json;
using System;

namespace AddressBook
{
     class Program
    {

        public static void Main(string[] args)
        {
            Contact newContact = new Contact();

            newContact.FirstName = "Ritvik";
            newContact.LastName = "Sharma";
            newContact.Address = "123 Xyz";
            newContact.City = "Banglore";
            newContact.State = "Karnataka";
            newContact.PostalCode = "12345";
            newContact.PhoneNumber = "1234567890";
            newContact.Email = "xyz@gmail.com";

            Console.WriteLine("Contact Deatils :\n");
            Console.WriteLine($"Name : {newContact.FirstName} {newContact.LastName}");
            Console.WriteLine("Address : " + newContact.Address);
            Console.WriteLine("City : " +newContact.City);
            Console.WriteLine("State : " +newContact.State);
            Console.WriteLine("PostalCode : " +newContact.PostalCode);
            Console.WriteLine("PhoneNumber : " +newContact.PhoneNumber);
            Console.WriteLine("Email : " + newContact.Email);

        }
    }
}