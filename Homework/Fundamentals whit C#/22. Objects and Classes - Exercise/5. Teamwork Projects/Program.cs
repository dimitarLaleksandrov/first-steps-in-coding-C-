using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        class Team
        {
            public Team(string teamName, string creatorName)
            {
                this.Name = teamName;
                this.Criator = creatorName;
                this.Members = new List<string>(); // !!!! !!!! !! for lists   coz list == null ==  exeption
            }
            public string Name { get; set; }
            public string Criator { get; set; }
            public List<string> Members { get; set; }
            public void AddMember(string member)
            {
                this.Members.Add(member);
            }
        }
        static void Main(string[] args)
        {
            int numberForRegist = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            RegisterTeam(teams, numberForRegist);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArg = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = joinArg[0];
                string teamName = joinArg[1];
                Team team  = teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (IsAlreadymemberOfTeam(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                if (teams.Any(t => t.Criator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                team.AddMember(memberName);

            }
            List<Team> teamsWhitMember = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            List<Team> teamsToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
            PrintValidTeams(teamsWhitMember);
            Console.WriteLine($"Teams to disband:");
            InvalidTeams(teamsToDisband);
        } 
        static bool IsAlreadymemberOfTeam(List<Team> teams, string memberName)
        {
            //LINQ
            //if (teams.Any(t => t.Mmber.Contains(memberName)))
            //{
            //   Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
            //   continue;
            //}
            foreach (Team team in teams)
            {
                if (team.Members.Contains(memberName))
                {
                    return true;
                }
            }
            return false;
        }
        static void RegisterTeam(List<Team> teams, int numberForRegist)
        {
            for (int i = 1; i <= numberForRegist; i++)
            {
                string[] teamArg = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creatorName = teamArg[0];
                string teamName = teamArg[1];
                if (teams.Any(team => team.Name == teamName))  // object == object - Contains - by adres of referend - value type
                                                               //object == condition - Any - same data
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(team => team.Criator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
        }
        static void PrintValidTeams(List<Team> valdiTeams)
        {
            foreach (Team validTeam in valdiTeams)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Criator}");
                foreach (string member in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        static void InvalidTeams(List<Team> teamsToDisband)
        {
            foreach (Team invalidTeam in teamsToDisband)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }
        }
    }
}
