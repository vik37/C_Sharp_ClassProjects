using System;
using System.Collections.Generic;
using System.Text;
using Vezbi_exercise.Students;
using Vezbi_exercise.Students.Scools;

namespace Vezbi_exercise.Helper
{
    public class ReturnClass
    {
        public static DateTime today;
        public static int alloo;
        public ReturnClass()
        {
            Dic = new Dictionary<Children, HigthScools>();
        }
        public  static Dictionary<Children, HigthScools> Dic { get; set; } = new Dictionary<Children, HigthScools>();
        public static int ReturnDate(DateTime dateOfBirth)
        {
            //int alloo;
            //if (today.Month < dateOfBirth.Month)
            //{
                alloo = dateOfBirth.Year - today.Year;
            //}
                
            
            return alloo;
        }
        public static void Add(Children strKay, HigthScools DataType)
        {
            if (!Dic.ContainsKey(strKay))
            {
                Dic.Add(strKay, DataType);
            }
            else
            {
                Dic[strKay] = DataType;
            }
        }
        public static string ako;
        public static string ReturnFirstNames()
        {
            
            foreach (var item in Dic)
            {
                ako = $"{item.Key.FirstName} Hight scool{item.Value.Teachers}";
            }
            
            return ako;
        }
    }
}
