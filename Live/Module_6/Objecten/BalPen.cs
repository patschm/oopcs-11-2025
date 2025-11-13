namespace Objecten;

// Met sealed kun je niet meer erven.
public sealed class BalPen : Pen
{
    // sealed voorkomt dat een afgeleide class deze methode nog kan overriden.
    public sealed override void Schrijf(string tekst)
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Balpen schrijft in lijndikte {Lijndikte}: {tekst}");
        Console.ResetColor();
    }
}
