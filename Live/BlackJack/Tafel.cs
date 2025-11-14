
namespace BlackJack;

public class Tafel
{
    private readonly Deler _deler;
    private readonly IGame _game;
    private List<Speler> _spelers = new List<Speler>();

    public Tafel(IGame game, IPlayer player)
    {
        _deler = new Deler(this, player);
        _game = game;
    }

    public Deler Deler { get => _deler;}

    public void DoeMee(Speler speler)
    {
        _spelers.Add(speler);
    }
    private void Init()
    {
        foreach (Speler speler in _spelers)
        {
            speler.Init();
        }
    }
    public void Start()
    {
        Init();
        _deler.Init();

        foreach (Speler speler in _spelers)
        {
            speler.Play();
        }
        _deler.Play();

        Evalueer();
    }

    private void Evalueer()
    {
        _game.ShowFinalResult([.._spelers.ToArray(), _deler]);

      
    }
}
