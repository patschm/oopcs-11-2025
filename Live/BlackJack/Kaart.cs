namespace BlackJack;

public record Kaart(int Waarde)
{
   public bool IsAce { get => Waarde == 11; } 
   public char Token { get; init;}

   public virtual void Show()
    {
        Console.WriteLine($"{Token} {Waarde}");
    }
}
