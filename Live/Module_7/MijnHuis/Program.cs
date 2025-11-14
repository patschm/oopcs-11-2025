using Heras;
using Yunex;
using Philips;
using DoomsdayPreppers;
using Logitech;

namespace MijnHuis;

class Program
{
    static void Main(string[] args)
    {
        Hek hek = new Hek();
        Valkuil valkuil = new Valkuil();
        Camera camera = new Camera();
        Lamp lamp = new Lamp();

        DetectieLus detectieLus = new DetectieLus();

        detectieLus.Connect(hek);
        detectieLus.Connect(camera);
        detectieLus.Connect(valkuil);
        detectieLus.Connect(lamp);

        detectieLus.Connect(hek.Open);
        detectieLus.Connect(camera.StartRecording);
        detectieLus.Connect(valkuil.Open);
        detectieLus.Connect(lamp.Aan);


        detectieLus.Activeer();
        // Hier wil ik niks zien

    }
}
