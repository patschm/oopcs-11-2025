namespace HetCern;

public delegate T MathDel<T>(T a, T b);

public class WillemKlein
{
    public void Bereken<T>(MathDel<T> fun, T x, T y) where T: struct
    {
        System.Console.WriteLine("Willem gaat nu rekenen...");
        T result = fun(x,y);

        System.Console.WriteLine($"Willem kraait nu: Het antwoord is {result}");
    }
}
