namespace TheFirm;

// Bokitp IMPLENENTEERT de interface IACMEContract
public class Bokito : IACMEContract
{
    public void DoWork()
    {
        Work();
    }

    public  void Work()
    {
        Console.WriteLine("Bokito mept vervelende dames in elkaar");
    }
}
