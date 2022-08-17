using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        private const double BattleshipArmorThickness = 300;
        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, BattleshipArmorThickness)
        {
            this.SonarMode = false;
        }
        public bool SonarMode
        {
            get { return this.SonarMode; }
            set { this.SonarMode = value; }
        }

        public void ToggleSonarMode()
        {
            if(this.SonarMode == false)
            {
                this.SonarMode = true;
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
            }
            else if (this.SonarMode == true)
            {
                this.SonarMode = false;
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
            }
        }
        public override void RepairVessel()
        {
            if (this.ArmorThickness < BattleshipArmorThickness)
            {
                this.ArmorThickness = BattleshipArmorThickness;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var onOrOff = this.SonarMode == true ? "ON" : "OFF";
            sb.Append(base.ToString());
            sb.AppendLine("*Sonar mode: " + onOrOff);
            return sb.ToString();
        }
    }
}
