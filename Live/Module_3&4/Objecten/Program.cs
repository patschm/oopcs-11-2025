using Objecten.Pennen;

namespace Objecten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Big bang. Hier ontstaat on virtuele universum.
            // p1 is nu een object. Een instantie van de class Pen
             Pen p1 = new Pen();
            //p1.kleur = ConsoleColor.Red;
            p1.Lijndikte = 12;

            p1.Schrijf("Hello, World!");

            Pen p2 = new Pen();
            p2.Kleur = ConsoleColor.Blue;
            p2.Lijndikte = 5;
            p2.Schrijf("Hello, Universe!");

            Pen p3 = new Pen();
            p3.Kleur = ConsoleColor.Green;
            p3.Lijndikte = 1;
            p3.Schrijf("Hello, Multiverse!");

            Pen p4 = new Pen { Kleur = ConsoleColor.Magenta, Lijndikte = 10 };
            p4.Schrijf("Hello, Parallelle Universums!");

            // Big Crunch. Hier eindigt ons virtuele universum.
        }
    }
    namespace Pennen
    {
        class Pen
        {
        }
    }
}

