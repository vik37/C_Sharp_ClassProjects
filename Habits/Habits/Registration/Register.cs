using System;
using System.Collections.Generic;
using System.Text;
using Habits.Registration.Register_entities;
using LogicalContext;

namespace Habits.Registration
{
    public class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Age { get; set; }
        private char[] Pass { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Register()
        {

        }
        public Register(string userName, string password, string firstName, string lastName,DateTime dateOfBirth)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            
            DateOfBirth = dateOfBirth;
        }
        public void Older()
        {
            HowOld(DateTime.Today);
            if (Age < 5 || Age > 122)
            {
                
                Console.WriteLine($"Age minimum 5, maximum 122");
            }
            
            
        }
        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            }
            else
            {
                Age = today.Year - DateOfBirth.Year;
            }
            
        }
        public void ShowPass()
        {
            RetHifhtPas(Password);
            Console.WriteLine(Pass);
        }
        private void RetHifhtPas(string Password)
        {
            Pass = SomeContext.HidePass(Password.Length);
        }
    }
    
}
