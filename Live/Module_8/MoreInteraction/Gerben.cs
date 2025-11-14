namespace MoreInteraction;

// Blauwdruk van een functie
public delegate void Naam(int d);

public class Gerben
{
    public void DoeJijMaar(Naam functie)
    {
        Console.WriteLine("Gerben voert het volgende uit:");
        functie(4);
    }
}
