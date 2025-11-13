namespace Objecten;

// VulPen erft van Pen en hergebruikt eigenschappen en methoden daarvan
// Je mag maar van een class tegelijk erfen.
// Overerving bevordert het hergebruik van code.
public class VulPen : Pen
{
    private int aantalSchijfActies = 5;
  
    public void Vul()
    {
        aantalSchijfActies = 5;
        Console.WriteLine("De vulpen is bijgevuld.");
    }
    // Met override activeer ik polymorfisme
    public override void Schrijf(string tekst)
    {
        if (aantalSchijfActies <= 0)
        {
            Console.WriteLine("De vulpen is leeg!");
            return;
        }
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Vulpen schrijft in lijndikte {Lijndikte}: {tekst}");
        Console.ResetColor();
        aantalSchijfActies--;
    }
}
