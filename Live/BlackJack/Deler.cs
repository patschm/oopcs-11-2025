namespace BlackJack;

public class Deler : Speler
{
    private Deck _dek = new Deck();

    public Deler(Tafel tafel, IPlayer player) : base(tafel, player)
    {
        Naam = "Deler";
    }

    public Kaart Hit()
    {
        return _dek.Draw();
    }
    public override void Play()
    {
        Console.WriteLine($"{Naam} is nu aan de beurt");
        do
        {
            Kaart kaart = Hit();
            _hand.Add(kaart);
            _hand.Show();
        }
        while (Total < 17);
    }
}
