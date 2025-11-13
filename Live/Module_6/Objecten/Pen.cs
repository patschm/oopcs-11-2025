namespace Objecten;

public abstract class Pen
{
    private int lijndikte = 5;
    public int Lijndikte
    {
        get { return lijndikte; }
        set
        {
            if (value > 0 && value <= 20)
            {
                lijndikte = value;
            }
            else
            {
                Console.WriteLine("Ongeldige lijndikte!");
            }
        }
    }
    public ConsoleColor Kleur { get; set; } = ConsoleColor.DarkRed;
    
    // Met virtual geef ik aan dat dit gedrag polymorf-ready is.
    // Virtual betekent ook dat een afgeleide class niet verplicht is om te overriden
    // Indien dit niet gewenst is, moet ik de methode abstract maken.
    // Betekent wel dat de hele class abstract moet zijn.
    // En de methode geen body mag hebben.
    public abstract void Schrijf(string tekst);
    // {
    //     Console.ForegroundColor = Kleur;
    //     Console.WriteLine($"[{Lijndikte}] {tekst}");
    //     Console.ResetColor();
    // }
}
