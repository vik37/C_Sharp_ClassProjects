using System;
using System.Collections.Generic;
using System.Text;
using BackFunctionality;
using Habits.Log_in.Statist;

namespace Habits.Log_in.Habits
{
    class HabitsClass : LogIn
    {
        //public List<int> Date { get; set; }
        public bool IsComplated { get; set; }
        public Dictionary<string, string> Date;
        public List<int> GodDate;
        public List<int> BadDate;
    
        public HabitsClass()
        {
            
        BadDate = new List<int> { BackFunc.saveDayBad, BackFunc.saveHourBad, BackFunc.saveMinutesBad, BackFunc.saveSecBad };
        GodDate = new List<int> { BackFunc.saveDayGood, BackFunc.saveHourGood, BackFunc.saveMinutesGood, BackFunc.saveSecGood };
        }
        //public HabitsClass ( bool isComplated, List<string> infoNames) 
        //    : base(infoNames)
        //{

        //    //Date = date;
        //    IsComplated = isComplated;

        //}
        public HabitsClass(bool isComplated)
           : base()
        {

            //Date = date;
            IsComplated = isComplated;

        }

        public void Dailylog(string a)
        {
            Console.WriteLine($"TODAY{BackFunc.aDate}");
            if (IsComplated)
            {
               if(a == "good")
                {
                    Console.WriteLine(BackFunc.ReturnGoodTime());
                }
                if(a == "bad")
                {
                    Console.WriteLine(BackFunc.ReturnBadTime());
                }
                
                
            }

        }
        public Statistics statistic;
        public static bool SingleLog(List<int> GoodDate, LinkedList<int> BadDate)
        {
            foreach (var date in GoodDate)
            {
                if(date != BackFunc.aDate.Day)
                {
                    return false;
                }
                
            }
            foreach (var date in BadDate)
            {
                if (date != BackFunc.aDate.Day)
                {
                    return false;
                }
            }
            return true;
        }
        //public void SingleLog()
        //{
        //    foreach (KeyValuePair item in statistic.GoodHabits)
        //    {
        //        if(item.)
        //    }
        //}
    }
}
