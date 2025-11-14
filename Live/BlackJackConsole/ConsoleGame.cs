using BlackJack;

namespace BlackJackConsole;

public class ConsoleGame : IGame
{
    public void ShowFinalResult(Speler[] spelers)
    {
        Console.WriteLine(new string('=', 80));
        Speler? winner = null;
        foreach (Speler speler in spelers)
        {
            Console.WriteLine($"{speler.Naam}: {speler.Total}");
            if (winner == null && speler.Total <= 21)
            {
                winner = speler;

                continue;
            }

            if (speler.Total <= 21 && speler.Total > winner?.Total)
            {
                winner = speler;
            }
            
        }

        Console.WriteLine($"De winnaar is {winner?.Naam}");
    }
}