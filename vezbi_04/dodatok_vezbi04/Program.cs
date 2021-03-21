using System;
using dodatok_vezbi04.ProUsers;

namespace dodatok_vezbi04
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrUsers = new Users[]
            {
            new Users("Petar@hotmail.com","fry#LeO"),
            new Users("hogar@strasniot.com","kOn%an"),
            new Users("svetle@gmail.com","roDeo^m!eko")
            };
            
            
        Start:
            Console.WriteLine("Za login stisnete 1 ili za register 2");
            var input = Console.ReadLine();



            bool successfull = false;
            while (!successfull)
            {

                if (input == "1")
                {
                    Console.WriteLine("Write your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();


                    foreach (Users user in arrUsers)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                            successfull = true;
                            break;
                        }
                    }

                    if (!successfull)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }

                }

                else if (input == "2")
                {

                    Console.WriteLine("Enter your username:");
                    var userName = Console.ReadLine();                    

                    char[] userChar;
                    char[] passChar;

                    string trimmedUser = userName.Trim();
                    if (!String.IsNullOrEmpty(userName))
                    {
                        userChar = trimmedUser.ToCharArray();
                        foreach(char userNm in userChar)
                        {
                            if (Check(userNm))
                            {
                                 for(int i = 0;i < userChar.Length; i++)
                                {
                                    if (checkDoth(userChar[i]))
                                    {
                                        if(userChar.Length < 30)
                                        {
                                            if (LastElementIs(userChar))
                                            {
                                                
                                                userName = new string(userChar);
                                                continue;
                                            }                                           
                                        }
                                        
                                    }
                                }
                                //if (checkDoth(userNm))
                                //{
                                //Console.WriteLine("great");
                                //continue;
                                //}
                                //    else
                                //    {
                                //        Console.WriteLine("Try again !!!");
                                //        break;
                                //    }
                            }                            
                        }                       

                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("you did not enter anything");

                    }
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    string trimmedPass = password.Trim();
                    if (!String.IsNullOrEmpty(trimmedPass))
                    {
                        passChar = trimmedPass.ToCharArray();
                        for(int i = 0; i < passChar.Length; i++)
                        {
                            if(passChar.Length < 10)
                            {
                                //if (SpecialCharacter(passChar[i]))
                                //{
                                    if (Char.IsUpper(passChar[i]))
                                    {
                                        if (Char.IsLower(passChar[i]))
                                        {
                                        
                                            foreach (char pass in passChar)
                                            {
                                                if (SpecialCharacter(pass))
                                                {
                                                password = new string(passChar);
                                                    Console.WriteLine("Exelent pass");
                                                }
                                            }
                                        }

                                    }
                               // }
                            }
                        }
                    }
                        Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(userName, password);
                    successfull = true;
                    goto Start;

                }
                else
                {
                    Console.WriteLine("Try again !!!");
                    break;


                }

            }
            static bool Check(char a)
            {
                if (a == '@')
                {
                    return true;
                }
                return false;
            }
            static bool checkDoth(char doth)
            {
                if (doth == '.')
                {
                    return true;
                }
                return false;
            }
            static bool LastElementIs(char[] last)
            {
                for (int i = 0; i < last.Length; i++)
                {
                    if (char.IsLetter(last[last.Length - 1]))
                    {
                        if (char.IsLetter(last[0]))
                        {
                            return true;
                        }

                    }

                }
                return false;
            }

            static bool SpecialCharacter(char one)
            {
                //char first = '%';
                //char second = '#';
                //char thirth = '!';
                //char Fourth = '^';
                //char Fifth = '&';
                if (one == '%')
                {
                    return true;
                }
                else if (one == '#')
                {
                    return true;
                }
                else if (one == '!')
                {
                    return true;
                }
                else if (one == '^')
                {
                    return true;
                }
                else if (one == '&')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }

    
    
}
