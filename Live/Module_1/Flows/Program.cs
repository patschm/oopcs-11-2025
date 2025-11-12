using System.Security.Cryptography.X509Certificates;

namespace Flows;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments provided.");
        }
        else if (args.Length > 0 && args.Length < 3)
        {
            Console.WriteLine($"First argument: {args[0]}");
        }
        else
        { }
        System.Console.WriteLine("Whaterver");

        switch (args.Length)
        {
            case 0:
                Console.WriteLine("No arguments provided.");
                break;
            case 1:
                System.Console.WriteLine($"First argument: {args[0]}");
                break;
            case 2:
                System.Console.WriteLine("Two arguments provided.");
                break;
            case int n when n > 2:  // korter: case >2:
                System.Console.WriteLine("More than two arguments provided.");  
                break;
            default:
                System.Console.WriteLine("More than two arguments provided.");
                break;
        }
    }
}
