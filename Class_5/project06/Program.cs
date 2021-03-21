using System;

namespace project06
{
    public class Participant
    {
        public Participant(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


        }
        #region Class definition
        // Class = Properties +  METHODS
        // Class = DATA + BEHAVIOUR
        #endregion



        //DEFAULT CONSTRUCTOR


        // Properties = DATA
        //Template
        public string FirstName;
        public string LastName;

        public DateTime DateOfBirth;
        public string[] Subjects;
        // 0 is default value for INT
        // ACCESS MODIFIER - PRIVATE
        private int Age;

        //Template
        // Methods = BEHAVIOUR

        public AcademyRole;
        public void Greetings()
        {
            Console.WriteLine($"Hello, I`m {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I`m {Age} years old. :)");
        }

        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
                Age = today.Year - DateOfBirth.Year - 1;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
       
    }
    public enum AcademyRole
    {
        Trainer = 1,
        Assistant,
        Student
    }

    class Program
    {
        static void Main(string[] args)
        {
            //How to create a class -> NEW
            Participant participant1 = new Participant();

            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";

            //Due to its protection LEVEL -> PRIVATE
            //participant1.Age = 100;

            participant1.DateOfBirth = new DateTime(1989, 5, 15);

            //Due to its protection LEVEL -> PRIVATE
            //participant1.HowOld(DateTime.Today);

            participant1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            
            var participant3 = new Participant("Bob", " Marley");
            participant3.PrintFullName();

            var participant4 = new Participant()
            {

                FirstName = "Tupac",
                LastName = "Shakur",
                DateOfBirth = new DateTime(1971, 6, 20)
            };

            var participants = new Participant[4];
            participants[0] = participant1;
            participants[1] = participant2;
            participants[2] = participant3;
            participants[3] = participant4;

            FindParticipantByRoll(participants, AcademyRole.Assistant);
            Console.ReadLine();
        }

        public static void FindParticipantByRoll(Participant[] participants,AcademyRole role)
        {
            foreach (var participant in participants)
            {
                if(participant.Role == role)
                {
                    participant.PrintFullName()
                        participant.PrintFullName();
                }
            }
        }
    }
}
