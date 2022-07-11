using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name, Stats stats)
        {
           this.Name = name;
           this.Stats = stats;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMeseges.NullOrWSNameExMessage);
                }
                this.name = value;
            }
        }
        public Stats Stats { get; private set; }
    }
}
