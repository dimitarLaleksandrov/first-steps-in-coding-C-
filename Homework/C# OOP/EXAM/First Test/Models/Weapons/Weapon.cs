﻿using PlanetWars.Models.Weapons.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private double price;
        
        protected Weapon(int destructionLevel, double price)
        {
            this.ValidateDestructionLevel(destructionLevel);
            this.DestructionLevel = destructionLevel;
            this.Price = price;
        }
        public double Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

        public int DestructionLevel
        {
            get;
<<<<<<< HEAD
            protected set;
=======
            private set;
>>>>>>> 0a4fa02efdd9b285fcd9b13367e5f1b314b56cf0
        }
        protected bool ValidateDestructionLevel(int destructionLevel)
        {
            if (destructionLevel < 1)
            {
                throw new ArgumentException("Destruction level cannot be zero or negative.");
            }
            else if (destructionLevel > 10)
            {
                throw new ArgumentException("Destruction level cannot exceed 10 power points.");
            }
            return true;
        }
        
    }
}
