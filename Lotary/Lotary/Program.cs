using Lotary.entities;
using Lotary.helpers;
using System;

namespace Lotary
{
    class Program
    {
        static void Main(string[] args)
        {
            // create structure
            User user = new User()
            {
                FullName = "Igor Djambazov"
            };
            user.SetAge(55);
            Ticket ticket = new Ticket()
            {
                Combination = new int[] { 8, 2, 33, 14, 25, 10, 7 },
                User = user
            };

            FirstSession firstSession = new FirstSession()
            {
                Tickets = new Ticket[] { ticket }
            };
            firstSession.StartSession();

            foreach(var number in ticket.Combination)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("----------------------------------------------------");
            foreach (var number in firstSession.WinningCombination)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("-------------------------------------------------------");
            var matches = LotaryHelpers.CheckTicket(firstSession.WinningCombination,ticket.Combination);

            switch (matches)
            {
                case (int)Prize.tv:
                    Console.WriteLine(Prize.tv);
                    break;
                case (int)Prize.Vacation:
                    Console.WriteLine(Prize.Vacation);
                    break;
                case (int)Prize.MotorBike:
                    Console.WriteLine(Prize.MotorBike);
                    break;
                case (int)Prize.Car:
                    Console.WriteLine(Prize.Car);
                    break;
                default:
                    break;
            }
            //firstSession.GetRandomTicket();
            Console.ReadLine();
        }
    }
}
