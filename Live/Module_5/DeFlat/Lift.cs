namespace DeFlat;

public class Lift
{
    private int _currentEtage = 0;
    public int CurrentEtage
    {
        get { return _currentEtage;}
    }

    public void Call(int etageNummer)
    {
        _currentEtage = etageNummer;
    }
    public Lift()
    {
        System.Console.WriteLine("Init lift ");
    }
}
