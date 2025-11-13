using Standards;

namespace Philips;

public class Lamp : IDevice
{
    public void Activate()
    {
        Aan();
    }
    public void Aan()
    {
        Console.WriteLine("De Philips lamp gaat aan.");
    }
}
