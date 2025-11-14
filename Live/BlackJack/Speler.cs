namespace BlackJack;

public class Speler
{
    protected Hand _hand = new Hand();
    protected readonly Tafel _tafel;
    private readonly IPlayer _player;

    public string? Naam { get; set; }

    public Speler(Tafel tafel, IPlayer player)
    {
        _tafel = tafel;
        _player = player;
    }

    public int Total { get => _hand.Total; }

    public void Init()
    {
        _hand.Add(_tafel.Deler.Hit());
        _hand.Add(_tafel.Deler.Hit());
    }
    public virtual void Play()
    {
        bool canContinue = true;
        do
        {
            _player.ShowInfo(this);
            _hand.Show();
            if (_hand.Total > 21)
            {
                Console.WriteLine("Kapot");
                return;
            }
            canContinue = _player.QueryAction();
            if (!canContinue) return;
            Kaart kaart = _tafel.Deler.Hit();
            _hand.Add(kaart);
        }
        while (true);
    }
}
