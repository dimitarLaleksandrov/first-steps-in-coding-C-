namespace NavalVessels.Models.Contracts
{
    using System.Collections.Generic;
    public interface ICaptain
    {
        string FullName { get; }
        public int CombatExperience { get; }
        public ICollection<IVersion> Vessels { get; }
        void AddVessel(IVersion vessel);
        void IncreaseCombatExperience();
        string Report();
    }
}
