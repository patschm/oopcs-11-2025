namespace Basics;

class Program
{
    static void Main(string[] args)
    {
        // TypeName varname = initialization; // literal or new
        int getal = 5;
        // Accolades defineren een scope waarin variabelen leven.
        {
            string? tekst = null;
            //tekst = "Hallo";
            int? len = tekst?.Length; ;
            System.Console.WriteLine(tekst?.Length);
        }

        getal = getal + 1;
        getal += 1;

        Console.WriteLine(++getal);

        double result = 3 / 6D;
        Console.WriteLine(result);

        bool bres2 = false & getal++ > 5;

        System.Console.WriteLine(getal);
        int bres = 1 ^ 1;
        System.Console.WriteLine(bres);

        int? age = null;

        System.Console.WriteLine(age ?? -1);

        int x = 800;
        byte b = (byte)x;

        System.Console.WriteLine(b);

    }
}
