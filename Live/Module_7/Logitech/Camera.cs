using Standards;

namespace Logitech;

public class Camera : IDevice
{
    public void Activate()
    {
        StartRecording();
    }
    public void StartRecording()
    {
        Console.WriteLine("Camera is gestart met opnemen.");
    }
}
