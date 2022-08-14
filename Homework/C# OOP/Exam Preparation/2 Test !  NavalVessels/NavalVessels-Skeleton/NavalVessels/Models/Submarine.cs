using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        public const double SubmarineArmorThickness = 200;
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, SubmarineArmorThickness)
        {
            this.SubmergeMode = false;
        }

        public bool SubmergeMode
        {
            get { return this.SubmergeMode; }
            set { this.SubmergeMode = value; }
        }

        public void ToggleSubmergeMode()
        {
            if (this.SubmergeMode == false)
            {
                this.SubmergeMode = true;
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
            }
            else if (this.SubmergeMode == true)
            {
                this.SubmergeMode = false;
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }
        }
        public new void RepairVessel()
        {
            if (this.ArmorThickness < SubmarineArmorThickness)
            {
                this.ArmorThickness = SubmarineArmorThickness;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var onOrOff = this.SubmergeMode == true ? "ON" : "OFF";
            sb.AppendLine("*Sonar mode: " + onOrOff);
            return base.ToString() + sb.ToString();
        }
    }
}
