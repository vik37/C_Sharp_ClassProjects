using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Directory.Models;

namespace Directory.Models
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Directory = new Dictionary<User, string>();
        }
        public Dictionary<User,string> Directory { get; set; }
        public object Dictionary { get; internal set; }

        public string SearchContact(User user)
        {

          
                foreach (var contact in Directory)
                {
                    if(contact.Key.Name == user.Name)
                    {
                        return contact.Value;
                    }
                }
            
            return "No such user!";
        }
        public void PrintContacts()
        {
            foreach (var contact in Directory)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
            }
        }
    }
}
