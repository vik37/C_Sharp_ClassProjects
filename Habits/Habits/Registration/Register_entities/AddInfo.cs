using System;
using System.Collections.Generic;
using System.Text;
using FirstIsNum;
using LogicalContext;
using MustHaveNumber;

namespace Habits.Registration.Register_entities
{
    public class AddInfo : Register
    {


        
        public bool Successt = false;
        public AddInfo()
        {
            
        }
        public AddInfo(bool successt, string userName, string password, string firstName, string lastName, DateTime dateOfBirth) 
            : base(userName, password, firstName, lastName, dateOfBirth)
        {
            Successt = successt;
           
        }

        

        public bool IfUser()
        {
            if (IsNumIndexOne.CheckFirstIndex(UserName))
            {
                for (int i = 0; i < UserName.Length; i++)
                {
                    if (UserName.Length >= 6)
                    {
                        
                        return Successt = true;

                    }
                }
            }
            
            return Successt = false;
        }

        public bool IfPass()
        {
            if (HaveOneNumChar.CheckTherIsNum(Password))
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Password.Length >= 6)
                    {
                        return Successt = true;

                    }
                }
            }
            
            return Successt = false;
        }
        public bool IfFName()
        {
            for (int i = 0; i < FirstName.Length; i++)
            {
                if (!HaveOneNumChar.CheckTherIsNum(FirstName))
                {
                    if (FirstName.Length > 2)
                    {
                        return Successt = true;

                    }
                }
                
            }
            return Successt = false;
        }
        public bool IfLastName()
        {
            if(!HaveOneNumChar.CheckTherIsNum(LastName))
            for (int i = 0; i < LastName.Length; i++)
            {
                if (LastName.Length > 2)
                {
                    return Successt = true;
                    
                }
            }
            return Successt = false;
        }

        public void succesfuly()
        {
            var ifUserName = IfUser();
            var ifPassword = IfPass();
            var ifFirstName = IfFName();
            var ifLastName = IfLastName();
            
            string a = ifUserName ? "USERNAME: SUCCESSFULLY" : "User Must have at least 6 characters and must not start with a number";
            string b = ifPassword ? "PASSWORD: SUCCESSFULLY" : "Must have at least 6 characters and at least 1 number";
            string c = ifFirstName ? "FIRST NAME: SUCCESSFULLY" : "Must have at least 2 characters and must not contain any number";
            string d = ifLastName ? "LAST NAME: SUCCESSFULLY" : "Must have at least 2 characters and must not contain any number";
            
            
            
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
        
            

        }
        public void ShowFallPass()
        {
            
            int count = 0;
            
            while(count <= Password.Length)
            {
                Console.Write(SomeContext.HidePass(Password.Length));
                count++;
            }
               
            
        }
    }
}
