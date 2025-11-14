using System.Reflection;

namespace BlackJack;

public class Hand
{
    private List<Kaart> _kaarten = new List<Kaart>();

    public int Total
    {
        get
        {
            int totaal = _kaarten.Sum(k => k.Waarde);
            if (totaal > 21)
            {
                foreach(Aas ace in _kaarten.OfType<Aas>())
                {
                   if (!ace.IsEen)
                    {
                        ace.IsEen = true;
                        totaal -= 10;
                        break;
                    }
                }
            }
            return totaal;
        }
    }

    public void Add(Kaart kaart)
    {
        _kaarten.Add(kaart);
    }
    public void Clear()
    {
        _kaarten.Clear();
    }
    public void Show()
    {
        foreach (Kaart kaart in _kaarten)
        {
            kaart.Show();
        }
    }
}
