namespace NavalVessels.Models.Contracts
{
    public interface IBattleship : IVersion
    {
        bool SonarMode { get; }
        void ToggleSonarMode();
    }
}
