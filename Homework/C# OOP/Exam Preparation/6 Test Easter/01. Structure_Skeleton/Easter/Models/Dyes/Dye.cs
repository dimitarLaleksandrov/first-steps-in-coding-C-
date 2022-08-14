using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        private int power;
        public Dye(int power)
        {
            this.Power = power;
        }
        public int Power
        {
            get
            {
                return this.power;
            }
            private set
            {
                this.power = value;

                if (value < 0)
                {
                    this.power = 0;
                }
            }
        }
        public bool IsFinished()
        {
            if (this.Power == 0)
            {
                return true;
            }
            return false;
        }
        public void Use()
        {
            this.Power -= 10;
            if (this.Power <= 0)
            {
                this.Power = 0;
            }
        }
    }
}
