using System;
using System.Collections.Generic;
using System.Text;
using LottoServices;

namespace Lotary.entities
{
    public class Sessions
    {
        static int counter = 0;
        public Sessions()
        {
            counter += 1;
            SessionId = counter;
            WinningCombination = new int[7];
        }
        private int SessionId { get; set; }
        public int[] WinningCombination { get; set; }
       
        public Ticket[] Tickets { get; set; }
        public int[] LottoNumbersGenerator { get; private set; }

        public void StartSession()
        {
            WinningCombination = LottoNumberGeneration.GenerateNumber();

        }
    }
}
