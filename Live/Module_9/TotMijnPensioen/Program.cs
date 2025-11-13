
namespace TotMijnPensioen;

class Program
{
    static void Main(string[] args)
    {
        Point<Kano> p1 = new Point<Kano>();// {X= 10, Y=20};
        Kano result = p1.Create();
        System.Console.WriteLine(result);
        

        decimal a = 10;
        decimal b = 20;     

        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }
    // static void Swap(ref double a, ref double b)
    // {
    //     double tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref float a, ref float b)
    // {
    //     float tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref int a, ref int b)
    // {
    //     int tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref long a, ref long b)
    // {
    //     long tmp = a;
    //     a = b;
    //     b = tmp;
    // }
}

internal class Kano
{
}