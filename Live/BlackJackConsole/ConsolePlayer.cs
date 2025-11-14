using BlackJack;

namespace BlackJackConsole;

internal class ConsolePlayer : IPlayer
{
    public bool QueryAction()
    {
        Console.WriteLine("Wil je nog een kaart (Esc voor pas)");
        var key = Console.ReadKey().Key;
        return key != ConsoleKey.Escape;

    }

    public void ShowInfo(Speler speler)
    {
        Console.WriteLine($"Speler {speler.Naam}, met {speler.Total} punten, is aan de beurt(");
      
    }
}
