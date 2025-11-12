using System.Collections;

namespace Verzamelingen;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        numbers.Add(6);
        numbers.Remove(2);
        numbers.Insert(1,23);
        System.Console.WriteLine(numbers[1]); // Output: 23

       Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["dertig"] = 30;
        ages["veertig"] = 40;
        ages["dertig"] = 50;
        ages.TryAdd("vijftig", 50);
        System.Console.WriteLine(ages["dertig"]); // Output: 50


        Stack<string> stack = new Stack<string>();
        stack.Push("Eerste");
        stack.Push("Tweede");

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Eerste");
        queue.Enqueue("Tweede");
        queue.Dequeue();

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(2); // Duplicate, will not be added

    }
}
