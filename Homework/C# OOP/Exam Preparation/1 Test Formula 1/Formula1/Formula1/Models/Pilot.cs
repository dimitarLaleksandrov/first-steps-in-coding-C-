﻿using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;
        private int numberOfWins;
        private bool canRace;
        public Pilot(string fullName)
        {
            this.FullName = fullName;
            this.canRace = false;
            this.NumberOfWins = 0;
        }
        public string FullName
        {
            get { return this.fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid pilot name: {value}.");
                }
                this.fullName = value;
            }
        }
        public IFormulaOneCar Car
        {
            get { return this.car; }
            private set
            {
                if(value == null)
                {
                    throw new NullReferenceException("Pilot car can not be null.");
                }
                this.car = value;
            }
        }

        public int NumberOfWins
        {
            get { return this.numberOfWins; }
            private set { this.numberOfWins = value; }
        }

        public bool CanRace
        {
            get { return this.canRace; }
            private set 
            {
                this.canRace = value;
            }
        }

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
        public override string ToString()
        {
            var str = $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
            return str.ToString();
        }
    }
}
