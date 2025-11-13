namespace Objecten;

// Blauwdruk van een pen
class Pen
{
    // Alle members van een class zijn standaard private
    // Eigenschappen slaan we op in fields (veredelde variabelen)
    //private ConsoleColor kleur = ConsoleColor.Yellow;
    private int lijndikte = 5;

    // Access methods. Geven gecontroleerde toegang (encapsulation) tot private fields
    // Dit is de C++ benadering (vroeger ook Java)
    // public void SetLijndikte(int dikte)
    // {
    //     if (dikte > 0 && dikte <= 20)
    //     {
    //         lijndikte = dikte;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Ongeldige lijndikte!");
    //     }
    // }
    // public int GetLijndikte()
    // {
    //     return lijndikte;
    // }


    // Dit is een properties. Het cosmetische alternatief voor access methods
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

    // Auto-generated property. Genereert zijn eigen field;
    public ConsoleColor Kleur { get; set; } = ConsoleColor.DarkRed;
    
    // Gedrag definieer je in methods (veredelde functies/procedures)
    public void Schrijf(string tekst)
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"[{Lijndikte}] {tekst}");
        Console.ResetColor();
    }

    // Constructors zijn bedoeld om FIELDS van een object te initialiseren
    // Als je geen constructor definieert, krijg je er automatisch een default constructor bij
    // Gebruik constructors alleen als de buitenwereld iets _MOET_ meegeven aan een field
    public Pen(ConsoleColor kleur, int lijndikte)
    {
        Kleur = kleur;
        Lijndikte = lijndikte;
    }
    public Pen() //: this(ConsoleColor.Yellow, 5)
    {

    }
}
