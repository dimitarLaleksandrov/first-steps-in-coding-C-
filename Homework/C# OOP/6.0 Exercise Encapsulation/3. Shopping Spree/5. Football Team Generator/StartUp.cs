using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string cmd = string.Empty;
            while((cmd = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmdArguments = cmd.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    ProcessInput(teams, cmdArguments);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                catch (IndexOutOfRangeException iore) 
                {
                    Console.WriteLine(ErrorMeseges.NullOrWSNameExMessage);
                }
            }
        }
        static void ProcessInput(List<Team> teams, string[] cmdArguments)
        {
            string cmdTipe = cmdArguments[0];
            string teamName = cmdArguments[1];
            if (cmdTipe == "Team")
            {
                Team team = new Team(teamName);
                teams.Add(team);
            }
            else
            {
                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    throw new InvalidOperationException(String.Format(ErrorMeseges.TeamNotExisti, teamName));
                }
                if (cmdTipe == "Add")
                {
                    string playerName = cmdArguments[2];
                    Stats playerStats = GeneratePlayerStats(cmdArguments.Skip(3).ToArray());
                    Player player = new Player(playerName, playerStats);
                    team.AddPlayer(player);
                }
                else if (cmdTipe == "Remove")
                {
                    string playerName = cmdArguments[2];   
                    team.RemovePlayer(playerName);
                }
                else if (cmdTipe == "Rating")
                { 
                    Console.WriteLine(team);
                }
            }
           
        }
        static Stats GeneratePlayerStats(string[] stats)
        {
            int endurance = int.Parse(stats[0]);
            int sprint = int.Parse(stats[1]);
            int dribble = int.Parse(stats[2]);
            int passing = int.Parse(stats[3]);
            int shooting = int.Parse(stats[4]);
            Stats genStats = new Stats(endurance, sprint, dribble, passing, shooting);
            return genStats;
        }
    }
}
