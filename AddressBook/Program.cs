using System.Text.Json;
using System;

namespace AddressBook
{
     class Program
    {

        public static void Main(string[] args)
        {
            Contact newContact = new Contact();
            newContact.GetContactInfoFromUser();
            Contact.AddContactToList(newContact);

            Contact.PrintContactList();
        }
    }
}