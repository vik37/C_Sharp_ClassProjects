using System;
using System.Linq;

namespace vezbi_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            string user = Console.ReadLine();
            Console.WriteLine("-----------");

            char[] usChar = new char[] { };
            usChar = user.ToCharArray();

            
            //if(user != "")
            //{
            //    string trimUser = user.Trim();
            //    usChar = trimUser.ToCharArray();

            //    if (!char.IsNumber(user, 4))
            //    {
            //        Console.WriteLine(usChar);
            //    }

            //}

            
            foreach(char userNm in usChar)
            {
                if (SpecialCharacter(userNm))
                {
                    Console.WriteLine("Exelent");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                //if (!Check(userNm)){
                //    Console.WriteLine(usChar);
                //    if (!SpecialCharacter(userNm))
                //    {
                //        if (!checkDoth(userNm))
                //        {
                //            Console.WriteLine("Error");
                            
                //            break;
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine(usChar);
                //        //}
                        
                //        //break;
                //    }
                //    else
                //    {
                //        ussers = new string(usChar);
                //        Console.WriteLine(ussers);
                        
                //    };

                //}
                
                //else
                //{
                //    Console.WriteLine("Error");

                //}

            }           
            Console.ReadLine();
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
            if(doth == '.')
            {
                return true;
            }
            return false;
        }
        static bool SpecialCharacter(char one)
        {
            char first = '%';
            char second = '#';
            char thirth = '!';
            char Fourth = '^';
            char Fifth = '&';
            if (one == first)
            {
                return true;
            }
            else if (one == second)
            {
                return true;
            }
            else if (one == thirth)
            {
                return true;
            }
            else if (one == Fourth)
            {
                return true;
            }
            else if (one == Fifth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool LastElementIs(char[] last)
        {
            for(int i = 0;i < last.Length; i++)
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
    }
}
