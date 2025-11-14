namespace BlackJack;

public record Vrouw(): Kaart(10)
{
public override void Show()
    {
        Console.WriteLine($"{Token} Vrouw");
    }
}
