using Standards;

namespace Yunex;

public class DetectieLus
{
    private List<IDevice> devices = new List<IDevice>();

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
    }
}
