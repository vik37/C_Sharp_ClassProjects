using System;
using System.Collections.Generic;
using System.Text;
using AcademyApp;
using AcademyApp.Enum;
using AcademyApp.Entities;

namespace AcademyApp.Helper
{
    class AcademyHelper
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
