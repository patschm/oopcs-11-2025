namespace Rekord;

class Program
{
    static void Main(string[] args)
    {
        Lijndikte dikte1 = new(10);
        //dikte1.Dikte = 20; // Dit veroorzaakt een compileerfout omdat records immutabel zijn standaard
        System.Console.WriteLine(dikte1.Dikte);

        Prijs prijs = new Prijs(30.99);
        Naam voornaam = new Naam("Jan");
        System.Console.WriteLine(prijs);
    }
}

class Naam2(string Name)
{
    // public string Name { get; init; }
    // public Naam2(string name)
    // {
    //     Name = name;
    // }
}
record Naam(string Name);
record Prijs(double bedrag)
{
    public double Bedrag { get; init; } = bedrag;
    public override string ToString()
    {
        return $"Prijs: {Bedrag:C2}";
    }
}
// Readonly type
record Lijndikte(int Dikte);
//{
    //public int Dikte { get; init; } = dikte;
//}
