
namespace DeFlat;

class Program
{
    static void Main(string[] args)
    {
        //FlatDemo();
        Console.WriteLine(new string('-', 80));
        Etage.ShowLiftPosition(); 

        PuntenDemo();
    }

     static void PuntenDemo()
    {
        Punt p1 = new Punt { X = 10, Y = 20 };
        Punt p2 = new Punt { X = -5, Y = 15 };

        p1.Show();
        p2.Show();

        Punt p3 = p1 + p2;
        p3.Show();

        System.Console.WriteLine(p1 == p2);

        System.Console.WriteLine(p3["x"]);

        double hypo = (double)p1;
        System.Console.WriteLine(hypo);

        System.Console.WriteLine(p1);
    }

    static void FlatDemo()
    {
        Etage._lift.Call(3);

        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage(i+1);
        }


        flat[14].CallLift();


        foreach (var etage in flat)
        {
            Etage.ShowLiftPosition();
        } 
    }
}
