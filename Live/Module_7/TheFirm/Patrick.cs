namespace TheFirm;

public class Patrick : Employee, ITwiceContract, ICloneable
{
    void ITwiceContract.DoWork()
    {
        Console.WriteLine("Patrick doet werk voor Twice"); 
    }

    public void DoetIets()
    {
        Console.WriteLine("Patrick doet iets");
    }

    public override void Work()
    {
        DoetIets();
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
