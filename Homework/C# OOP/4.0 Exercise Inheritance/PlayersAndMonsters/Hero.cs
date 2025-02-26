﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }
        private string username;
        private int level;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public override string ToString()
        {
            return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
        }
    }
}
