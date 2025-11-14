using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace BlackJack;

public class Deck
{
    private Stack<Kaart> _kaarten = new Stack<Kaart>();

    public Kaart Draw()
    {
        if (_kaarten.Count <= 0) Vul();
        return _kaarten.Pop();
    }
    public void Vul()
    {
        var kaarten = GenerateKaarten();

        do
        {
            int index = Random.Shared.Next(0, kaarten.Count);
            var kaart = kaarten[index];
            _kaarten.Push(kaart);
            kaarten.Remove(kaart);
        }
        while(kaarten.Count > 0);
    }
    private List<Kaart> GenerateKaarten()
    {
        List<Kaart> kaarten = new List<Kaart>();
        char[] tokens = ['\u2660', '\u2663', '\u2665', '\u2666'];

        foreach (char token in tokens)
        {
            for (int i = 2; i < 11; i++)
            {
                kaarten.Add(new Kaart(i));
            }
            kaarten.Add(new Boer { Token = token });
            kaarten.Add(new Vrouw { Token = token });
            kaarten.Add(new Koning { Token = token });
            kaarten.Add(new Aas { Token = token });
        }
        return kaarten;
    }
}
