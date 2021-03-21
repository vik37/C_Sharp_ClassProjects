using System;
using System.Collections.Generic;
using LogicalContext;

namespace BackFunctionality
{
    public class BackFunc
    {
        public static DateTime aDate = DateTime.Now;

        public static string nameDateGood;
        public static int saveDayGood;
        public static int saveHourGood;
        public static int saveMinutesGood;
        public static int saveSecGood;

        public static string nameDateBad;
        public static int saveDayBad;
        public static int saveHourBad;
        public static int saveMinutesBad;
        public static int saveSecBad;

        public static string ReturnGoodTime()
        {
            
            return SomeContext.GetDate(saveDayGood, saveHourGood, saveMinutesGood, saveSecGood);
        }
        public static string ReturnBadTime()
        {
            return SomeContext.GetDate(saveDayBad, saveHourBad, saveMinutesBad, saveSecBad);
        }
        public static DateTime ReturnDate()
        {
            return aDate;
        }
        public static List<string> SomeTextOne;
        public static List<string> SomeTextTwo;
        //public static string Recording(List<string> a, List<string> b)
        // {
        //     foreach (var item in a)
        //     {
        //         return item.
        //     }
        // }
    }
}
