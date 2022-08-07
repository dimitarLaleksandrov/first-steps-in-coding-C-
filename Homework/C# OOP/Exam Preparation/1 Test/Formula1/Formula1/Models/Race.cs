using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private readonly ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
        }

        public string RaceName
        {
            get { return this.raceName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: {value}.");
                }
                this.raceName = value;
            }
        }
        public int NumberOfLaps
        {
            get { return this.numberOfLaps; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Invalid lap numbers: {value}.");
                }
                this.numberOfLaps = value;
            }
        }

        public bool TookPlace
        {
            get { return this.tookPlace; }
            set
            {
                value = false;
                this.tookPlace = value;
            }
        }

        public ICollection<IPilot> Pilots => this.pilots;
       

        public void AddPilot(IPilot pilot)
        {
            this.Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            var str = new StringBuilder();
            str.AppendLine($"The {this.RaceName} race has:");
            str.AppendLine($"Participants: {this.Pilots.Count}");
            str.AppendLine($"Number of laps: {this.NumberOfLaps}");
            str.AppendLine($"Took place: {this.TookPlace}");
            return str.ToString();
        }
    }
}
