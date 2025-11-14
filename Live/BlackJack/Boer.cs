namespace BlackJack;

public record Boer() : Kaart(10)
{
  public override void Show()
    {
        Console.WriteLine($"{Token} Boer");
    }
}
