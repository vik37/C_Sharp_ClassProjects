using System;
using System.IO;
using System.Runtime.Serialization;

namespace CostumException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // throw new FileNotFoundException("File not found");

                throw new UserAllReady("Üser is log then");
            }
            catch(UserAllReady ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }
    }
    [Serializable]
    public class UserAllReady : Exception
    {
        public UserAllReady() : base()
        {

        }
        public UserAllReady(string message) : base(message)
        {

        }
        public UserAllReady(string message, Exception innerException) : base(message,  innerException)
        {

        }
        public UserAllReady(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
