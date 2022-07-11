using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;
        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name) : this()
        {
            this.Name = name;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMeseges.NullOrWSNameExMessage);
                }
                this.name = value;
            }
        }
        public int Rating
        {
            get
            {
                if (this.players.Any())
                {
                    return (int)Math.Round(this.players.Average(p => p.Stats.GetOverallStat()), 0);
                }
                return 0;
            }
        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player playerToDell = this.players.FirstOrDefault(p => p.Name == playerName);
            if (playerToDell == null)
            {
                throw new InvalidOperationException(String.Format(ErrorMeseges.PlayerNotInTeam, playerName, this.Name));
            }
            this.players.Remove(playerToDell);
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
