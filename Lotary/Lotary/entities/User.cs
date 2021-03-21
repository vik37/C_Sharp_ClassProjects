using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.entities
{
    public class User
    {
        public string FullName { get; set; }
        private int Age { get; set; }

        public void CreateTicket()
        {
            Console.WriteLine("You got new ticket");
        }


        public void SetAge(int age)
        {
            if (age < 18)
                Console.WriteLine("Not allow for users under  age of 18");
            else Age = age;
        }
    }
}
