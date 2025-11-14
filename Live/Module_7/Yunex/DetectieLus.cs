using Standards;

namespace Yunex;

public delegate void ActivateHandler();

public class DetectieLus
{
    private List<IDevice> devices = new List<IDevice>();
    private event ActivateHandler? Activate;


    public void Connect(ActivateHandler activateHandler)
    {
        this.Activate += activateHandler;
    }
    public void Connect(IDevice device)
    {
        devices.Add(device);
    }
    public void Activeer()
    {
        Console.WriteLine("De detectielus is geactiveerd.");
        foreach(var device in devices)
        {
            device.Activate();
        }

        Activate?.Invoke();
    }
}
