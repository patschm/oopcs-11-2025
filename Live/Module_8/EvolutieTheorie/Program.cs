namespace EvolutieTheorie;

delegate int MathDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        // 2002/2003 .NET 1.0/1.1
        MathDel m1 = new MathDel(Add);
        result = m1(1, 2);

        // 2005 .NET 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;
        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3,4);

        // 2008 .NET 3.0/3.5
        MathDel m4 =  (a, b) => a + b + c;
        
        result = m4(4,5);

        // Procedures.
        Action<int> a1 = ShowResult;
        //a1(result)

        // Function
        Func<int, int, int> m5 = Add;
        result=m5(5,6);

        Func<int, int, int> m6 = (a, b) => a + b;
        result = m6(6,7);

        ShowResult(result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void ShowResult(int answer)
    {
        System.Console.WriteLine($"Het resultaat is: {answer}");
    }
}
