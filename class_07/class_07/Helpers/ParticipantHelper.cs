using AcademyApp.Entities;
using AcademyApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace class_07.Helpers
{
    class ParticipantHelper
    {
        public static void FindParticipantByRole(Participant[] participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }
    }

}
