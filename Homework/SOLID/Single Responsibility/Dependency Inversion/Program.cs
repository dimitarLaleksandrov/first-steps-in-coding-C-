// See https://aka.ms/new-console-template for more information
//high level classes shud NOT depend on low level classes all classes should depend on abstractions
// if we need to replace one of the interface's we can replace onli one they are not depends on each other
public interface IRemoteControlService 
{
    public void PressOnButton();
}
public interface ITVService 
{
    public void TurnOn();
}
public class RemoteControlService : IRemoteControlService 
{
    private readonly ITVService _tvService;
    public RemoteControlService(ITVService tvService)
    {
        _tvService = tvService;
    }
    public void PressOnButton() 
    {
        _tvService.TurnOn();
    }
}

