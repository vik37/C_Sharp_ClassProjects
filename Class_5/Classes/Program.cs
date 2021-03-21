using System;

namespace Classes
{
    public class Participant
    {

        ////Class = Properties + Methods

        // Class = Data + Odnesuvanje(behaviour)


        // Properties = DATA
        // Template
        public string FirstName;
        public string LastName;
        public int Age;


        // Methods = Behaviour
        // Template
        public void Greeting()
        {
            Console.WriteLine($"Hello Im {FirtName} {LastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            var participant1 = new Participant();
            participant1.FirstName = "Viktor";
            participant1.LastName = "Zafirovski";
            participant1.Greeting();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.Greeting();

            Console.ReadLine();
        }
    }
}
