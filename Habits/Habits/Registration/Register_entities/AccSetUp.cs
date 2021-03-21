using System;
using System.Collections.Generic;
using System.Text;
using Habits.Registration;
using Habits.Registration.Register_entities.Enum;
using Microsoft.VisualBasic;

namespace Habits.Registration.Register_entities
{
    public class AccSetUp : Register
    {

        public string Title { get; set; }
        public int HabitGroup { get; set; }

        public int ChoiseDificult { get; set; }
        public int ChoiseType { get; set; }
        
        
        public AccSetUp()
        {
           
        }
        public AccSetUp(string title, int habitGroup, int choiseDificult, int choiseType,
            string userName, string password, string firstName, string lastName, DateTime dateOfBirth) 
                : base(userName, password, firstName, lastName, dateOfBirth)
        {
            Title = title;
            HabitGroup = habitGroup;
            ChoiseDificult = choiseDificult;
            ChoiseType = choiseType;
        }
        Group activeHoby = Group.ActivitiesAndHobbies;
        Group sportExercise = Group.ExerciseAndSports;
        Group home = Group.HomeAndPersonal;
        Group other = Group.Other;
        Group studyLearn = Group.StudyAndLearning;
        Group work = Group.WorkAndCareer;
       

        public void ChoisingGroup()
        {
            switch (HabitGroup)
            {
                case 1:
                    Console.WriteLine(sportExercise);
                    break;
                case 2:
                    Console.WriteLine(studyLearn);
                    break;
                case 3:
                    Console.WriteLine(activeHoby);
                    break;
                case 4:
                    Console.WriteLine(work);
                    break;
                case 5:
                    Console.WriteLine(home);
                    break;
                case 6:
                    Console.WriteLine(other);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

           
        }
        
        public void ChoisingDificulty()
        {
            Dificulty low = Dificulty.Low;
            Dificulty medium = Dificulty.Medium;
            Dificulty hard = Dificulty.Hard;
            switch (ChoiseDificult)
            {
                case 1:
                    Console.WriteLine(low);
                    break;
                case 2:
                    Console.WriteLine(medium);
                    break;
                case 3:
                    Console.WriteLine(hard);
                    break;
                default:
                    Console.WriteLine("ERROR");

                    break;
            }
        }
        TypeGroups good = TypeGroups.Good;
        TypeGroups bad = TypeGroups.Bad;

        public void ChoisingType()
        {
            switch (ChoiseType)
            {
                case 1:
                    Console.WriteLine(good);
                    break;
                case 2:
                    Console.WriteLine(bad);
                    break;
                default:
                    break;
            }
        }
    }
}
