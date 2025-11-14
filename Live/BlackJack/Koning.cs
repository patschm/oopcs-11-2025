namespace BlackJack;

public record Koning(): Kaart(10)
{
    public override void Show()
    {
        Console.WriteLine($"{Token} Koning");
    }
}
