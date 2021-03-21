using Habits.Registration.Register_entities;
using Habits.Registration.Register_entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habits.Log_in.Statist
{
    class Statistics : LogIn
    {
        public TypeGroups GoodHab { get; set; } = TypeGroups.Good;
        public Dictionary<List<string>, List<string>> GoodHabits { get; set; }
        public TypeGroups BadHub { get; set; } = TypeGroups.Bad;
        public Dictionary<List<string>, List<string>> BadHabits { get; set; }
        
        public Statistics()
        {

        }
        public Statistics(int goodHab, Dictionary<List<string>, List<string>> goodHabits,int badHub, Dictionary<List<string>, List<string>> 
            badHabits)
            : base()
        {
            
            GoodHabits = goodHabits;
           
            BadHabits = badHabits;
        }

    }
}
