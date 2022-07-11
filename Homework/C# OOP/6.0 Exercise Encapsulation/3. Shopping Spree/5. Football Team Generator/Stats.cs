using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private const int MinRange = 0;
        private const int MaxRange = 100;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance 
        {  
            get { return endurance; }
            private set
            {
                if(value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException(String.Format(ErrorMeseges.StatInvalidvalue, nameof(this.Endurance)));
                }
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException(String.Format(ErrorMeseges.StatInvalidvalue, nameof(this.Sprint)));
                }
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException(String.Format(ErrorMeseges.StatInvalidvalue, nameof(this.Dribble)));
                }
                this.dribble = value;
            }
        }
        public int Passing
        {
            get { return passing; }
            set
            {
                if (value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException(String.Format(ErrorMeseges.StatInvalidvalue, nameof(this.Passing)));
                }
                this.passing = value;
            }
        }
        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException(String.Format(ErrorMeseges.StatInvalidvalue, nameof(this.Shooting)));
                }
                this.shooting = value;
            }
        }
        public double GetOverallStat() => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        
    }
}
