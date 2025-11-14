namespace TheLambdas;

class Program
{
    static void Main(string[] args)
    {
        var people = new Bogus.Faker<Person>()
            .RuleFor(p => p.Firstname, f => f.Person.FirstName)
            .RuleFor(p => p.Lastname, f => f.Person.LastName)
            .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
            .Generate(100)
            .ToList();

        string first = Console.ReadLine().ToUpper();
        var opeple = people.OrderBy(OrderByAge).Where(p => p.Lastname.StartsWith(first));

        foreach (var p in opeple)
        {
            System.Console.WriteLine(p);
        }

    }

    static bool LastnameStartsWithS(Person p)
    {
        return p.Lastname.StartsWith("S");
    }
    static bool LastnameStartsWithW(Person p)
    {
        return p.Lastname.StartsWith("W");
    }
    static string OrderByLastname(Person p)
    {
        return p.Lastname;
    }
    static int OrderByAge(Person p)
    {
        return p.Age;
    }
}
