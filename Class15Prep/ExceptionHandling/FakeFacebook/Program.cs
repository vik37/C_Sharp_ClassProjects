using FakeFacebook.Logger;
using System;
using WebApi.Service;
using WebApi.Exceptions;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = UserService.GetAllUsers();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            try
            {
                //var userById = UserService.GetUserById(4);
                var usersFriends = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFriends)
                {
                    Console.WriteLine(user.FirstName);
                }
                //Console.WriteLine(userById.FirstName);
            }
            catch(UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I proced to work");
            
            Console.ReadLine();
        }
    }
}
