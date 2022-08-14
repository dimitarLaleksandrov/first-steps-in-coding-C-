namespace NavalVessels.Models.Contracts
{
    public interface ISubmarine : IVersion
    {
        bool SubmergeMode { get; }
        void ToggleSubmergeMode();
    }
}
