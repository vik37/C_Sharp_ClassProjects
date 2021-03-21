using System;
using System.Linq;
using Habits.Log_in;

// Registration 
using Habits.Registration;
using Habits.Registration.Register_entities;
using FirstIsNum;
using MustHaveNumber;
using System.Collections.Generic;
using Habits.Registration.Register_entities.Enum;
using LogicalContext;
using Habits.Log_in.Habits;
using BackFunctionality;
using Habits.Log_in.Statist;

namespace Habits
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISTA OD USER
            var pitDate = new DateTime(1972, 03, 23);
            var magdeDate = new DateTime(2008, 10, 08);
            var toniData = new DateTime(1995, 01, 01);
            
            var usertList = new List<AddInfo>()
            {
                new AddInfo(true,"PitBull","Frigo23_record","Dejan","Bogradnovski", pitDate),
                new AddInfo(true,"Apollo11","sRek@na4pati", "Magdalena","Masevska",magdeDate),
                new AddInfo(true, "franjo192","katanec&7raj","Toni","Micevski", toniData),

        };
            //foreach (var user in usertList)
            //{
            //    user.Password = new string(SomeContext.HidePass(user.Password.Length));
            //}
        
        StartLog:
            // REGISTER OD MOMENTALEN INPUT
            var regist = new AddInfo();
            
           
            bool isUser = false; 
            Console.WriteLine("For LOGIN 1 For REGISTER 2");

            var input = int.Parse(Console.ReadLine());
            
            if (input == 1)
            {              
                while (!isUser)
                {
                     Console.WriteLine("Write your username:");
                     var username = Console.ReadLine();
                     Console.WriteLine("Enter your password:");
                     var password = Console.ReadLine();

                     foreach (AddInfo user in usertList)
                     {
                         if (username == user.UserName && password == user.Password)
                         {
                                Console.WriteLine("You have successfully logged in !!!");
                                Console.WriteLine("Enter for continue");
                                Console.ReadLine();
                                isUser = true;
                                goto toHabbit;
                         }
                     }

                    if (!isUser)
                    {                        
                         Console.WriteLine("Your username or password is incorect, try again !!!");
                       
                    }

                 }               
            }
            
             StartRegister:
             if(input == 2)
            {
            
                Console.WriteLine("Enter your user name");
                regist.UserName = Console.ReadLine().Trim();
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("Enter your password");
                regist.Password = Console.ReadLine().Trim();
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("Enter your first name");
                regist.FirstName = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("Enter your last name");
                regist.LastName = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------");

                Console.Write("Enter your date of birth----");
                Console.WriteLine("Date of birth must be wrete in this queue: ex. (1978, 02, 29)");
                regist.DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            //char[] arrNew = new char[] { };
            //regist.ShowPass();
            //regist.ShowFallPass();
            //Console.WriteLine("LOGIN IS SUCCESSFULLY");                
            // USER METHODI DALI E ISPOLNETO
            var firstIfMethod = regist.IfUser();
            var secondIfMethod = regist.IfPass();
            var thirthIfMethod = regist.IfFName();
            var fourthIfMethod = regist.IfLastName();
            var ifForArray = new bool[] { firstIfMethod, secondIfMethod, thirthIfMethod, fourthIfMethod };
            for(int i = 0;i < ifForArray.Length; i++)
            {
                if(ifForArray[i] == true)
                {
                    usertList.Add(regist);
                    Console.WriteLine("GOOD GRATULATION. REGISTER IS SUCCESSFULLY");
                    goto StartLog;
                    // break;
                }
                else
                {
                    regist.succesfuly();
                    goto StartRegister;
                   
                }
                i++;
            }
            
            foreach (var item in usertList)
            {
                Console.WriteLine(item.FirstName);

            };
            regist.Older();

        // regist.succesfuly();


        // HABITS
        toHabbit:
            var registerAccSet = new AccSetUp();

            //int good;
            var goodTypeTitle = new List<string>();
            var goodTypeGroup = new List<int>();
            var goodTypeDificult = new List<int>();

            // BAD 
            //int bad;
            var badTypeTitle = new List<string>();
            var badTypeGroup = new List<int>();
            var badTypeDificult = new List<int>();

            Console.WriteLine("Must choise at least 1 good and 1 bad habit");
             bool IsYes = true;
            //while(IsYes)
            //{
                
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(@"Choise: 1 - GOOD  ""Habits"" ");
                Console.WriteLine("-------------------------------------------------");
                registerAccSet.ChoiseType = int.Parse(Console.ReadLine());
                if (registerAccSet.ChoiseType == 1)
                {                                
                    do{
                    
                    Console.WriteLine("name of the habit");
                        Console.WriteLine("-------------------------------------------------");
                        goodTypeTitle.Add(registerAccSet.Title = Console.ReadLine());

                        Console.WriteLine("in what group does the habit belong? ");
                        Console.WriteLine(" 1. Exercise and sport \n 2. Study and learning \n 3. Activities and hobbies \n" +
                            " 4. Work and career \n 5. Home and personal \n 6. Other");
                        goodTypeGroup.Add(registerAccSet.HabitGroup = int.Parse(Console.ReadLine()));
                        Console.WriteLine("-------------------------------------------------");

                        Console.WriteLine("Dificult of hoby? ");
                        Console.WriteLine(" 1. Low \n 2. Medium \n 3. Hard");
                        goodTypeDificult.Add(registerAccSet.ChoiseDificult = int.Parse(Console.ReadLine()));
                        Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("For more good habits (YES/NO)");
                    string yesNo = Console.ReadLine().ToUpper();
                    if (yesNo == "NO")
                        {
                            IsYes = false;
                            break;
                        }
                    } while (IsYes) ;
                }
            

            Console.WriteLine(@"Choise: 2: BAD - ""Habits""");
                Console.WriteLine("-------------------------------------------------");
                registerAccSet.ChoiseType = int.Parse(Console.ReadLine());

                if (registerAccSet.ChoiseType == 2)
                {                                      
                    do
                    {
                    
                    Console.WriteLine("name of the habit");
                        Console.WriteLine("-------------------------------------------------");
                        badTypeTitle.Add(registerAccSet.Title = Console.ReadLine());

                        Console.WriteLine("in what group does the habit belong? ");
                        Console.WriteLine("1. Exercise and sport \n 2. Study and learning \n 3. Activities and hobbies \n" +
                            " 4. Work and career \n 5. Home and personal \n 6. Other");
                        badTypeGroup.Add(registerAccSet.HabitGroup = int.Parse(Console.ReadLine()));
                        Console.WriteLine("-------------------------------------------------");

                        Console.WriteLine("Dificult of hoby? ");
                        Console.WriteLine("1. Low \n 2. Medium \n 3. Hard");
                        badTypeDificult.Add(registerAccSet.ChoiseDificult = int.Parse(Console.ReadLine()));
                        Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("For more good habits (YES/NO)");
                    string yesNo = Console.ReadLine().ToUpper();
                    if (yesNo == "NO")
                        {
                            IsYes = false;
                            break;
                        }

                    } while (IsYes);
                }
            
            Console.WriteLine("YOUR SETUP IS COMPLITED YOU MUST WRITE CURRENT TIME AND START ENTER FOR TRACKING YOUR HABITS");
            Console.WriteLine("#######################################################################################");
            string goodText = Console.ReadLine();
            Console.WriteLine("Save Time and date");
            Console.Write("Day");
            BackFunc.nameDateGood = Console.ReadLine();
            Console.Write("DayDate");
            BackFunc.saveDayGood = int.Parse(Console.ReadLine());
            Console.Write("Hour");
            BackFunc.saveHourGood = int.Parse(Console.ReadLine());
            Console.Write("Minutes");
            BackFunc.saveMinutesGood = int.Parse(Console.ReadLine());
            Console.Write("Seconds");
            BackFunc.saveSecGood = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            string badText = Console.ReadLine();
            Console.Write("Day");
            BackFunc.nameDateGood = Console.ReadLine();
            Console.WriteLine("Save Time about finish good habits");
            Console.Write("DayDate");
            BackFunc.saveDayBad = int.Parse(Console.ReadLine());
            Console.Write("Hour");
            BackFunc.saveHourBad = int.Parse(Console.ReadLine());
            Console.Write("Minutes");
            BackFunc.saveMinutesBad = int.Parse(Console.ReadLine());
            Console.Write("Seconds");
            BackFunc.saveSecBad = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            BackFunc.SomeTextOne.Add(badText);
            BackFunc.SomeTextTwo.Add(goodText);
            //good = registerAccSet.ChoiseType;
            //bad = registerAccSet.ChoiseType;

            var habitClass = new HabitsClass();
          
            
            
            

           
            var statist = new Statistics();

            statist.BadHabits.Add(badTypeTitle, BackFunc.SomeTextOne);
            
            
            
            registerAccSet.ChoisingType();
            registerAccSet.ChoisingGroup();
            registerAccSet.ChoisingDificulty();

            

            
            
            Console.ReadLine();
            
        }
    }
}
