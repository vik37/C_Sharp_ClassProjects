using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            var teamsStartWithLA = teams.Where(team => team.Name.StartsWith("La")).ToList();
            teamsStartWithLA.ForEach(team => Console.WriteLine(team.Name));
            var teamsPleyingInSteplesCenter = teams.Where(team => team.Arena == "Staples Center")
                                                         .Select(team => team.Name).ToList();
            teamsPleyingInSteplesCenter.ForEach(team => Console.WriteLine(team));

            var allCoaches = teams.Select(team => team.Coach).ToList();
            allCoaches.ForEach(a => Console.WriteLine(a.FullName));

            var allOldestAndNamesCoaches = allCoaches.OrderByDescending(coach => coach.Age)
                                                                      .Take(3)
                                                                      .Select(coach => coach.FullName).ToList();
            allOldestAndNamesCoaches.ForEach(a => Console.WriteLine(a));

            var GroupTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();

            var allPlayer = new List<Player> ();
            teams.ForEach(team => allPlayer.AddRange(team.Players));
            allPlayer.ForEach(pley => Console.WriteLine(pley.FullName));

            var pleyarWithMostPtsPerGame = allPlayer.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).FirstOrDefault();
            Console.WriteLine(pleyarWithMostPtsPerGame);
            Console.ReadLine();
        }
    }
}
