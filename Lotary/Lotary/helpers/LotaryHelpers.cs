using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.helpers
{
    public class LotaryHelpers
    {
        public static int CheckTicket(int[] winningCombination,int[] ticketNumber)
        {
            int counter = 0;
            foreach (var number in winningCombination)
            {
                
                foreach (var num in ticketNumber)
                {
                    if(number == num)
                    {
                        counter++;
                    }
                }
                
            }
            return counter;
        }
    }
}
