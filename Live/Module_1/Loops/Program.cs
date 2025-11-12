namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;

        // for loop als je weet hoeveel iteraties je wilt doen
        for (Console.WriteLine("Init"); ; Console.WriteLine("Einde Iteratie"))
        {
            if (++x == 5) continue;
            if (x >= 10) break;
            Console.WriteLine($"Value of x is {x}");
        }

        // while loop als je niet weet hoeveel iteraties je wilt doen
        // (0 of meer keer)
        // Files lezen
        while (x < 20)
        {
            Console.WriteLine($"Value of x is {++x}");
            break;
        }

        // do while loop als je niet weet hoeveel iteraties je wilt doen
        // (1 of meer keer)
        // User input
        do
        {
            Console.WriteLine($"Value of x is {++x}");
        }
        while (x < 30);
    }
}
