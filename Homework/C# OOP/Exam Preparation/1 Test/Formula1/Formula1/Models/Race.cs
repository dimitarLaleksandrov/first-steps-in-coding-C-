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
        private readonly List<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this.TookPlace = false;
            this.pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get { return this.raceName; }
            private set
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
            private set
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
                this.tookPlace = value;
            }
        }

        public ICollection<IPilot> Pilots
        {
            get { return this.pilots; }
        }
       

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
            var place = TookPlace == true ? "Yes" : "No";
            str.AppendLine($"Took place: {place}");
            return str.ToString().TrimEnd();
        }
    }
}
