using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class6.AnonimusFunc
{
    public static class ListExtensiions
    {
        public static string FindOrDefault(this List<string> list, Func<string, bool> predicate)
        {
            string resault = null;
            foreach (var item in list)
            {
                var isItemFound = predicate(item);
                if (isItemFound)
                {
                    resault = item;
                    break;
                }
            }
            return resault;
        }
    }
}
