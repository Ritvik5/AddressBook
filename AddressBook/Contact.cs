using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public static Contact[] ContactList = new Contact[10];
        public static int ContactCount = 0;

        public void GetContactInfoFromUser()
        {
            Console.WriteLine("Enter Contact Information :");

            Console.WriteLine("FirstName :");
            FirstName = Console.ReadLine();

            Console.WriteLine("LastName :");
            LastName = Console.ReadLine();

            Console.WriteLine("Address :");
            Address = Console.ReadLine();

            Console.WriteLine("City :");
            City = Console.ReadLine();

            Console.WriteLine("State :");
            State = Console.ReadLine();

            Console.WriteLine("PostalCode :");
            PostalCode = Console.ReadLine();

            Console.WriteLine("PhoneNumber :");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Email :");
            Email = Console.ReadLine();
        }

        public static void AddContactToList(Contact newcontact)
        {
            ContactList[ContactCount] = newcontact;
            ContactCount++;
        }

        public static void PrintContactList() 
        {
            Console.WriteLine("Contact Details :");

            for (int i = 0; i < ContactCount; i++)
            {
                Console.WriteLine($"Name        = {ContactList[i].FirstName} {ContactList[i].LastName} ");
                Console.WriteLine($"Address     = {ContactList[i].Address} ");
                Console.WriteLine($"City        = {ContactList[i].City} ");
                Console.WriteLine($"State       = {ContactList[i].State} ");
                Console.WriteLine($"PostalCode  = {ContactList[i].PostalCode} ");
                Console.WriteLine($"PhoneNumber = {ContactList[i].PhoneNumber} ");
                Console.WriteLine($"Email       = {ContactList[i].Email} ");
                Console.ReadKey();
            }
                
        }
    }
}
