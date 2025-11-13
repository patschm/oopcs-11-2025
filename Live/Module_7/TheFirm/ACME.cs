namespace TheFirm;

public class ACME
{
    private List<IACMEContract> employees = new List<IACMEContract>();

    public void Hire(IACMEContract employee)
    {
        employees.Add(employee);
    }
    public void Start()
    {
        Console.WriteLine("ACME is starting up...");
        
        foreach (var employee in employees)
        {
            employee.DoWork();
        }
    }
}
