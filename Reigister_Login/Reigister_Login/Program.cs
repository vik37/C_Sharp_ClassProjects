using System;

namespace Reigister_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGIN or REGISTER \n If you want " +
                "Log in press 1, for register press 2");
           
            string logOrRegister = Console.ReadLine();
            string userName;
            string eMail;
            string pass;

            string trimmedUser;
            string trimmedMail;
            string trimmedPass;

            char[] userChar;
            char[] eMailChar;
            char[] passChar;
            


            string logUser;          
            string logPassword;

            char[] logUserChar;          
            char[] logPasswordChar;

            if (logOrRegister == "1")
            {
                Console.WriteLine("Enter the username");
                userName = Console.ReadLine();
                Console.WriteLine("----------------------");
                               
                trimmedUser = userName.Trim();
                                
                if(!String.IsNullOrEmpty(trimmedUser))
                {
                    userChar = trimmedUser.ToCharArray();
                    
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("you did not enter anything");
                   
                }

                Console.WriteLine("Enter your e-mail adress");
                eMail = Console.ReadLine();
                Console.WriteLine("----------------------");
                trimmedMail = eMail.Trim();
                
                if (!String.IsNullOrEmpty(trimmedMail))
                {
                    eMailChar = trimmedMail.ToCharArray();
                    int lastIndexEmail = eMailChar.Length - 1;
                    for (int i = 0;i < eMailChar.Length; i++)
                    {
                        if(eMailChar[i] == '@')
                        {
                            if(eMailChar[i] == '.')
                            {
                                if (Char.IsLetter(eMailChar[0]))
                                {
                                    if (Char.IsLetter(eMailChar[lastIndexEmail]))
                                    {
                                        if(eMail.Length < 30)
                                        {
                                            Console.WriteLine("Your email is successful");

                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your email is not successful. Please try aggain");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your email is not successful. Please try aggain");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Your email is not successful. Please try aggain");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Your email is not successful. Please try aggain");
                                break;
                            }
                                                       
                            
                        }
                        
                        
                    }
                    
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("you did not enter anything");
                }

                Console.WriteLine("Enter the password");
                pass = Console.ReadLine();
                Console.WriteLine("----------------------");
                trimmedPass = pass.Trim();

                

                if (!String.IsNullOrEmpty(trimmedPass))
                {
                    passChar = trimmedPass.ToCharArray();

                    for(int i = 0; i < passChar.Length; i++)
                    {
                        
                            if (passChar.Length < 10 && Char.IsUpper(passChar[i]) && Char.IsLower(passChar[i]) &&
                                passChar[i] == '%' || passChar[i] == '#' || passChar[i] == '!' || passChar[i] == '^' || passChar[i] == '&')
                            {
                                Console.WriteLine("Congratulations. Your LOGIN is successful");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your password is not successful. Please try aggain");
                            break;
                            }
                       
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("you did not enter anything");
                }

            }
            else if(logOrRegister == "2")
            {

                Console.WriteLine("Please Enter your User Name or eMail");

                logUser = Console.ReadLine();
                
                logUserChar = logUser.ToCharArray();
                

                Console.WriteLine("Please Enter your Password");
                logPassword = Console.ReadLine();
                logPasswordChar = logPassword.ToCharArray();

                

            }
            else
            {
                Console.WriteLine("ERROR YOU MUST ENTER 1 FOR REGISTER OR 2 FOR LOG IN");
            }

            Console.ReadLine();
        }

       
    }
}
