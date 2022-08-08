namespace NavalVessels.Models.Contracts
{
    using System.Collections.Generic;
    public interface IVersion
    {
        string Name { get; }
        ICaptain Captain { get; set; }
        double ArmorThickness { get; set; }
        double MainWeaponCaliber { get; }
        double Speed { get; }
        ICollection<string> Targets { get; }
        void Attack(IVersion target);
        void RepairVessel();
        string ToString();
    }
}
