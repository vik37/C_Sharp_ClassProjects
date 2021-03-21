using Directory.Models;
using System;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            phonebook.Directory.Add(new User() { Name = "Miodrag", Adress = "Aerodrom" }, "077-655-555");
            phonebook.Directory.Add(new User() { Name = "Viktor", Adress = "Cento" }, "072-234-555");
            phonebook.Directory.Add(new User() { Name = "Jovan", Adress = "Gorce" }, "072-184-555");
            var user = new User()  { Name = "Miodrag", Adress = "Aerodrom" };
            Console.WriteLine(phonebook.SearchContact(user));

            Console.ReadLine();
        }
    }
}
