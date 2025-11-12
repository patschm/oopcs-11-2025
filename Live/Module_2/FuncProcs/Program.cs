namespace FuncProcs;

class Program
{
    static void Main(string[] args)
    {
        int result = Add(5, 10);
        result = Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
        Console.WriteLine($"The sum is: {result}");
        DisplayValue(value: result, name: "value", flag: true);

        //int res2;
        DoeIets(out int res2);
        System.Console.WriteLine($"After DoeIets: {res2}");
    }

    // Procedure
    static void DisplayValue(bool flag, int value = 10, string name = "Default Name")
    {
        Console.WriteLine($"The {name} is: {value}");
    }

    // Function
    static int Add(int a, int b)
    {
        return a + b;
    }
    // Overload Not the name is unique but the signature (parameters)
    static int Add(params int[] nummers)
    {
        return nummers.Sum();
    }
    static void DoeIets(out int number)
    {
        number = 1000;
    }
}
