namespace BlackJack;

public record Aas(): Kaart(11)
{
    public bool IsEen { get; set; } = false;
    public override void Show()
    {
        Console.WriteLine($"{Token} Aas");
    }
}
