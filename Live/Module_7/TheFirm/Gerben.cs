namespace TheFirm;

public class Gerben : Employee
{
    public void LoopHard()
    {
        Console.WriteLine("Gerben is loopt hard rond het gebouw");
    }

    public override void Work()
    {
        LoopHard();
    }
}
