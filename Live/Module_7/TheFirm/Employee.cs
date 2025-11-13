namespace TheFirm;

public abstract class Employee : Person, IACMEContract
{
    public void DoWork()
    {
        Work();
    }

    public abstract void Work();
}
